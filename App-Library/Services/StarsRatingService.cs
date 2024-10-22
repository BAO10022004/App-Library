using App_Library.Models;
using App_Library.Services.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace App_Library.Services
{
    public class StarsRatingService : IStarsRatingService
    {
        private readonly MongoDbContext _context;

        public StarsRatingService(MongoDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateRating(StarsRating rating, string currentUsername)
        {
            var user = await _context.Users.Find(u => u.Username == currentUsername).FirstOrDefaultAsync();

            if (user == null)
            {
                throw new UnauthorizedAccessException("You need to log in to rate the books.");
            }

            if (rating == null)
            {
                throw new ArgumentNullException(nameof(rating), "Rating is null.");
            }

            var existingRating = await _context.StarsRatings
                .Find(r => r.BookId == rating.BookId && r.UserId == user.Id)
                .FirstOrDefaultAsync();

            if (existingRating != null)
            {
                throw new InvalidOperationException("You have already rated this book.");
            }

            rating.UserId = user.Id ?? "";
            await _context.StarsRatings.InsertOneAsync(rating);
            return true; 
        }

        public async Task<StarsRating> GetRatingById(string id, string currentUsername)
        {
            var user = await _context.Users.Find(u => u.Username == currentUsername).FirstOrDefaultAsync();

            if (user == null)
            {
                throw new UnauthorizedAccessException("You are not allowed to get this rating");
            }

            var rating = await _context.StarsRatings.Find(r => r.Id == id).FirstOrDefaultAsync();
            if (rating == null)
            {
                throw new KeyNotFoundException("Rating not found");
            }
            return rating;
        }

        public async Task<bool> UpdateRating(string id, StarsRating updatedRating, string currentUsername)
        {
            var user = await _context.Users.Find(u => u.Username == currentUsername).FirstOrDefaultAsync();

            if (user == null)
            {
                throw new UnauthorizedAccessException("You are not allowed to update this rating");
            }

            if (updatedRating == null || updatedRating.Id != id)
            {
                throw new ArgumentException("Rating is null or ID mismatch.");
            }

            var rating = await _context.StarsRatings.Find(r => r.Id == id).FirstOrDefaultAsync();
            if (rating == null)
            {
                throw new KeyNotFoundException("Rating not found");
            }

            await _context.StarsRatings.ReplaceOneAsync(r => r.Id == id, updatedRating);
            return true; 
        }

        public async Task<bool> DeleteRating(string id, string currentUsername)
        {
            var user = await _context.Users.Find(u => u.Username == currentUsername).FirstOrDefaultAsync();

            if (user == null)
            {
                throw new UnauthorizedAccessException("You are not allowed to delete this rating");
            }

            var rating = await _context.StarsRatings.Find(r => r.Id == id).FirstOrDefaultAsync();
            if (rating == null)
            {
                throw new KeyNotFoundException("Rating not found");
            }

            await _context.StarsRatings.DeleteOneAsync(r => r.Id == id);
            return true; 
        }

        public async Task<List<BookRatingSummary>> GetHotBooks()
        {
            var hotBooks = await _context.StarsRatings.Aggregate()
                .Group(r => r.BookId, g => new BookRatingSummary
                {
                    BookId = g.Key,
                    AverageStars = g.Average(r => r.Stars),
                    OneStar = g.Count(r => r.Stars == 1),
                    TwoStars = g.Count(r => r.Stars == 2),
                    ThreeStars = g.Count(r => r.Stars == 3),
                    FourStars = g.Count(r => r.Stars == 4),
                    FiveStars = g.Count(r => r.Stars == 5)
                })
                .SortByDescending(g => g.AverageStars)
                .Limit(10)
                .ToListAsync();

            return hotBooks;
        }

        public async Task<object> GetBookRating(string bookId)
        {
            var bookRating = await _context.StarsRatings.Aggregate()
                .Match(r => r.BookId == bookId)
                .Group(r => r.BookId, g => new
                {
                    BookId = g.Key,
                    AverageStars = g.Average(r => r.Stars),
                    TotalRatings = g.Count()
                })
                .FirstOrDefaultAsync();

            if (bookRating == null)
            {
                throw new KeyNotFoundException("No ratings found for this book.");
            }

            return bookRating;
        }
    }
}

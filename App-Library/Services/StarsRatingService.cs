using App_Library.Models;
using App_Library.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Library.Services
{
    public class StarsRatingService : IStarsRatingService
    {
        private readonly MongoDbContext _context;
        //private readonly IHttpContextAccessor _httpContextAccessor;

        //public StarsRatingService(MongoDbContext context, IHttpContextAccessor httpContextAccessor)
        //{
        //    _context = context;
        //    _httpContextAccessor = httpContextAccessor;
        //}

        //public async Task<StarsRating> CreateRating(StarsRating rating)
        //{
        //    // Implement logic as in CreateRating from controller
        //}

        //public async Task<StarsRating> GetRatingById(string id)
        //{
        //    // Implement logic as in GetRatingById from controller
        //}

        //public async Task UpdateRating(string id, StarsRating updatedRating)
        //{
        //    // Implement logic as in UpdateRating from controller
        //}

        //public async Task DeleteRating(string id)
        //{
        //    // Implement logic as in DeleteRating from controller
        //}

        //public async Task<List<BookRatingSummary>> GetHotBooks()
        //{
        //    // Implement logic as in GetHotBooks from controller
        //}

        //public async Task<BookRatingSummary> GetBookRating(string bookId)
        //{
        //    // Implement logic as in GetBookRating from controller
        //}
    }
}

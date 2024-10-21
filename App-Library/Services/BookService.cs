using App_Library.Models;
using App_Library.Services.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unidecode.NET;

namespace App_Library.Services
{
    public class BookService : IBookService
    {
        private readonly MongoDbContext _context;

        public BookService(MongoDbContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            return await _context.Books.Find(FilterDefinition<Book>.Empty)
                                        .SortByDescending(book => book.CreatedAt)
                                        .ToListAsync();
        }

        public async Task<bool> AddBookAsync(Book newBook, string currentUsername)
        {
            var user = await _context.Users.Find(u => u.Username == currentUsername).FirstOrDefaultAsync();
            if (user == null || !user.IsAdmin)
            {
                return false;
            }

            //if (string.IsNullOrEmpty(newBook.Title) || string.IsNullOrEmpty(newBook.Content))
            //{
            //    throw new ArgumentException("Please provide all required fields!");
            //}

            var existingBook = await _context.Books.Find(b => b.Title == newBook.Title).FirstOrDefaultAsync();
            if (existingBook != null)
            {
                throw new InvalidOperationException("A book with this title already exists.");
            }

            newBook.Slug = newBook.Title.Unidecode().ToLower().Replace(" ", "-").Replace("[^a-zA-Z0-9-]", "");
            newBook.Username = currentUsername;

            await _context.Books.InsertOneAsync(newBook);
            return true;
        }

        //public async Task<List<Book>> SearchBooksAsync(string searchTerm, string sort, string genre, int startIndex, int limit)
        //{
        //    var filterBuilder = Builders<Book>.Filter;
        //    var filters = filterBuilder.Empty;

        //    if (!string.IsNullOrEmpty(searchTerm))
        //    {
        //        filters &= filterBuilder.Or(
        //            filterBuilder.Regex(b => b.Title, new BsonRegularExpression(searchTerm, "i")),
        //            filterBuilder.Regex(b => b.Content, new BsonRegularExpression(searchTerm, "i")),
        //            filterBuilder.Regex(b => b.Author, new BsonRegularExpression(searchTerm, "i"))
        //        );
        //    }

        //    if (!string.IsNullOrEmpty(genre) && genre != "none")
        //    {
        //        filters &= filterBuilder.Eq(b => b.Genre, genre);
        //    }

        //    var sortDefinition = sort == "asc"
        //        ? Builders<Book>.Sort.Ascending(b => b.UpdatedAt)
        //        : Builders<Book>.Sort.Descending(b => b.UpdatedAt);

        //    var books = await _context.Books.Find(filters)
        //        .Sort(sortDefinition)
        //        .Skip(startIndex)
        //        .Limit(limit)
        //        .ToListAsync();

        //    //var totalBooks = await _context.Books.CountDocumentsAsync(filters);

        //    return books;
        //}

        public async Task<bool> UpdateBookAsync(string id, UpdateBookDTO updateBookDTO, string currentUsername)
        {
            var user = await _context.Users.Find(u => u.Username == currentUsername).FirstOrDefaultAsync();
            if (user == null || !user.IsAdmin)
            {
                return false;
            }

            var filter = Builders<Book>.Filter.Eq("_id", new ObjectId(id));
            var updateDefinition = new List<UpdateDefinition<Book>>();

            if (!string.IsNullOrEmpty(updateBookDTO.Title))
            {
                updateDefinition.Add(Builders<Book>.Update.Set(b => b.Title, updateBookDTO.Title));
            }

            if (!string.IsNullOrEmpty(updateBookDTO.Author))
            {
                updateDefinition.Add(Builders<Book>.Update.Set(b => b.Author, updateBookDTO.Author));
            }

            if (updateBookDTO.PublishedYear >= 0)
            {
                updateDefinition.Add(Builders<Book>.Update.Set(b => b.PublishedYear, updateBookDTO.PublishedYear));
            }

            if (!string.IsNullOrEmpty(updateBookDTO.Genre))
            {
                updateDefinition.Add(Builders<Book>.Update.Set(b => b.Genre, updateBookDTO.Genre));
            }

            if (updateBookDTO.Price >= 0)
            {
                updateDefinition.Add(Builders<Book>.Update.Set(b => b.Price, updateBookDTO.Price));
            }

            if (!string.IsNullOrEmpty(updateBookDTO.Content))
            {
                updateDefinition.Add(Builders<Book>.Update.Set(b => b.Content, updateBookDTO.Content));
            }

            if (!string.IsNullOrEmpty(updateBookDTO.Username))
            {
                updateDefinition.Add(Builders<Book>.Update.Set(b => b.Username, updateBookDTO.Username));
            }

            if (!string.IsNullOrEmpty(updateBookDTO.Image))
            {
                updateDefinition.Add(Builders<Book>.Update.Set(b => b.Image, updateBookDTO.Image));
            }

            if (!string.IsNullOrEmpty(updateBookDTO.PdfUrl))
            {
                updateDefinition.Add(Builders<Book>.Update.Set(b => b.PdfUrl, updateBookDTO.PdfUrl));
            }

            if (!updateDefinition.Any())
            {
                throw new ArgumentException("No fields to update");
            }

            var update = Builders<Book>.Update.Combine(updateDefinition);
            var result = await _context.Books.FindOneAndUpdateAsync(filter, update, new FindOneAndUpdateOptions<Book>
            {
                ReturnDocument = ReturnDocument.After
            });

            return result != null;
        }

        public async Task<bool> DeleteBookAsync(string id, string currentUsername)
        {
            var user = await _context.Users.Find(u => u.Username == currentUsername).FirstOrDefaultAsync();
            if (user == null || !user.IsAdmin)
            {
                return false;
            }

            var filter = Builders<Book>.Filter.Eq("_id", new ObjectId(id));
            var result = await _context.Books.DeleteOneAsync(filter);

            return result.DeletedCount > 0;
        }
    }
}

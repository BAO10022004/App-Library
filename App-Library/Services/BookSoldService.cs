using App_Library.Models;
using App_Library.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Library.Services
{
    public class BookSoldService : IBookSoldService
    {
        private readonly MongoDbContext _context;
        //private readonly IHttpContextAccessor _httpContextAccessor;

        //public BookSoldService(MongoDbContext context, IHttpContextAccessor httpContextAccessor)
        //{
        //    _context = context;
        //    _httpContextAccessor = httpContextAccessor;
        //}

        //public async Task<List<BookSold>> GetBooksSoldAsync()
        //{
        //    // Implement logic to get books sold
        //}

        //public async Task<List<BookSold>> GetBooksInProgressAsync(string username)
        //{
        //    // Implement logic to get books in progress for the specified username
        //}

        //public async Task<List<BookSold>> GetBoughtBooksAsync(string username)
        //{
        //    // Implement logic to get bought books for the specified username
        //}

        //public async Task<(int totalSoldBooks, int lastMonthSoldBooks, List<BookSold> books)> GetSoldBooksAsync(string sort, int startIndex, int limit)
        //{
        //    // Implement logic to get sold books with pagination and sorting
        //}

        //public async Task<List<BookSold>> GetPendingBooksSoldAsync()
        //{
        //    // Implement logic to get pending books sold
        //}

        //public async Task<BookSold> GetBookSoldByIdAsync(string bookId, string username)
        //{
        //    // Implement logic to get book sold by ID
        //}

        //public async Task<string> CreateBookSoldAsync(BookSold newBookSold, string username)
        //{
        //    // Implement logic to create a new book sold entry
        //}

        //public async Task<bool> ApproveBookSoldAsync(string id)
        //{
        //    // Implement logic to approve a book sold entry
        //}

        //public async Task<bool> RejectBookSoldAsync(string id)
        //{
        //    // Implement logic to reject a book sold entry
        //}
    }
}

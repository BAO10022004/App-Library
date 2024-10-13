using App_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Library.Services.Interfaces
{
    public interface IBookService
    {
        Task<List<Book>> GetAllBooksAsync();
        Task<Book> GetBookBySlugAsync(string slug);
        Task<bool> AddBookAsync(Book newBook, string currentUsername);
        //Task<SearchResult<Book>> SearchBooksAsync(string searchTerm, string sort, string genre, int startIndex, int limit);
        //Task<bool> UpdateBookAsync(string id, UpdateBookDTO updateBookDTO, string currentUsername);
        Task<bool> DeleteBookAsync(string id, string currentUsername);
    }
}

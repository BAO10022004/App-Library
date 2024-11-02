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
        Task<bool> AddBookAsync(Book newBook);
        //Task<List<Book>> SearchBooksAsync(string searchTerm, string sort, string genre, int startIndex, int limit);
        Task<bool> UpdateBookAsync(string id, UpdateBookDTO updateBookDTO);
        Task<bool> DeleteBookAsync(string id);
    }
}

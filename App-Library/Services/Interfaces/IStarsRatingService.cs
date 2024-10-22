using App_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Library.Services.Interfaces
{
    public interface IStarsRatingService
    {
        Task<bool> CreateRating(StarsRating rating, string currentUsername);
        Task<StarsRating> GetRatingById(string id, string currentUsername);
        Task<bool> UpdateRating(string id, StarsRating updatedRating, string currentUsername);
        Task<bool> DeleteRating(string id, string currentUsername);
        Task<List<BookRatingSummary>> GetHotBooks();
        Task<object> GetBookRating(string bookId);
    }
}

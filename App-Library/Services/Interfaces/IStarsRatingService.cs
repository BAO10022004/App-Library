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
        Task<bool> CreateRating(StarsRating rating);
        Task<StarsRating> GetRatingById(string id);
        Task<bool> UpdateRating(string id, StarsRating updatedRating);
        Task<bool> DeleteRating(string id);
        Task<List<BookRatingSummary>> GetHotBooks();
        Task<object> GetBookRating(string bookId);
    }
}

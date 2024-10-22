using App_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Library.Services.Interfaces
{
    public interface ICommentService
    {
        Task<bool> CreateCommentAsync(Comment comment, string currentUsername);
        Task<List<Comment>> GetBookCommentsAsync(string bookId);
        Task<bool> LikeCommentAsync(string commentId, string userId);
        Task<bool> EditCommentAsync(string commentId, UpdateCommentDTO editCommentDto, string currentUsername);
        Task<bool> DeleteCommentAsync(string commentId, string userId, string currentUsername);
        Task<(List<Comment> comments, long totalComments, long lastMonthComments)> GetCommentsAsync(int startIndex, int limit, string sort, string currentUsername);
    }
}

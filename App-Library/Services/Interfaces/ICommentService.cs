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
        Task<bool> CreateCommentAsync(Comment comment);
        Task<List<Comment>> GetBookCommentsAsync(string bookId);
        Task<bool> LikeCommentAsync(string commentId);
        Task<bool> EditCommentAsync(string commentId, UpdateCommentDTO editCommentDto);
        Task<bool> DeleteCommentAsync(string commentId);
        Task<(List<Comment> comments, long totalComments, long lastMonthComments)> GetCommentsAsync(int startIndex, int limit, string sort);
    }
}

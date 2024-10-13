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
        //Task<Comment> CreateCommentAsync(Comment comment);
        Task<List<Comment>> GetBookCommentsAsync(string bookId);
        //Task<Comment> LikeCommentAsync(string commentId);
        //Task<Comment> EditCommentAsync(string commentId, UpdateCommentDTO editCommentDto);
        //Task<bool> DeleteCommentAsync(string commentId);
        //Task<(List<Comment> comments, int totalComments, int lastMonthComments)> GetCommentsAsync(int startIndex, int limit, string sort);
    }
}

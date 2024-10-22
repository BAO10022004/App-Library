using App_Library.Models;
using App_Library.Services.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace App_Library.Services
{
    public class CommentService : ICommentService
    {
        private readonly MongoDbContext _context;

        public CommentService(MongoDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateCommentAsync(Comment comment)
        {
            var user = await _context.Users.Find(u => u.Username == SessionManager.CurrentUsername).FirstOrDefaultAsync();

            if (user == null)
            {
                throw new UnauthorizedAccessException("You are not allowed to create this comment.");
            }

            comment.CreatedAt = DateTime.UtcNow;
            await _context.Comment.InsertOneAsync(comment);
            return true;
        }

        public async Task<List<Comment>> GetBookCommentsAsync(string bookId)
        {
            return await _context.Comment
                .Find(c => c.BookId == bookId)
                .SortByDescending(c => c.CreatedAt)
                .ToListAsync();
        }

        public async Task<bool> LikeCommentAsync(string commentId)
        {
            var comment = await _context.Comment.Find(c => c.Id == commentId).FirstOrDefaultAsync();
            if (comment == null)
            {
                throw new KeyNotFoundException("Comment not found!");
            }

            if (string.IsNullOrEmpty(SessionManager.CurrentUserId))
            {
                throw new UnauthorizedAccessException("You need to log in to like comment.");
            }

            var userIndex = Array.IndexOf(comment.Likes, SessionManager.CurrentUserId);

            if (userIndex == -1)
            {
                comment.NumberOfLikes += 1;
                var newLikes = comment.Likes?.ToList() ?? new List<string>();
                newLikes.Add(SessionManager.CurrentUserId);
                comment.Likes = newLikes.ToArray();
            }
            else
            {
                comment.NumberOfLikes -= 1;
                var updatedLikes = comment.Likes?.ToList() ?? new List<string>();
                updatedLikes.Remove(SessionManager.CurrentUserId);
                comment.Likes = updatedLikes.ToArray();
            }

            await _context.Comment.ReplaceOneAsync(c => c.Id == commentId, comment);
            return true;
        }

        public async Task<bool> EditCommentAsync(string commentId, UpdateCommentDTO editCommentDto)
        {
            var comment = await _context.Comment.Find(c => c.Id == commentId).FirstOrDefaultAsync();
            if (comment == null)
            {
                throw new KeyNotFoundException("Comment not found!");
            }

            var user = await _context.Users.Find(u => u.Username == SessionManager.CurrentUsername).FirstOrDefaultAsync();

            if (user == null)
            {
                throw new UnauthorizedAccessException("You do not have permission to edit the comment.");
            }

            comment.Content = editCommentDto.Content ?? comment.Content;
            comment.UpdatedAt = DateTime.UtcNow;

            await _context.Comment.ReplaceOneAsync(c => c.Id == commentId, comment);
            return true;
        }

        public async Task<bool> DeleteCommentAsync(string commentId)
        {
            var comment = await _context.Comment.Find(c => c.Id == commentId).FirstOrDefaultAsync();
            if (comment == null)
            {
                throw new KeyNotFoundException("Comment not found!");
            }

            var user = await _context.Users.Find(u => u.Username == SessionManager.CurrentUsername).FirstOrDefaultAsync();

            if (comment.UserId != SessionManager.CurrentUserId && !user.IsAdmin)
            {
                throw new UnauthorizedAccessException("You are not allowed to delete this comment.");
            }

            await _context.Comment.DeleteOneAsync(c => c.Id == commentId);
            return true;
        }

        public async Task<(List<Comment> comments, long totalComments, long lastMonthComments)> GetCommentsAsync(int startIndex, int limit, string sort)
        {
            var user = await _context.Users.Find(u => u.Username == SessionManager.CurrentUsername).FirstOrDefaultAsync();

            if (user == null && !user.IsAdmin)
            {
                throw new UnauthorizedAccessException("You do not have permission to get all comments.");
            }

            var sortDirection = sort == "desc" ? -1 : 1;
            var comments = await _context.Comment
                .Find(_ => true)
                .Sort(sortDirection == 1 ? Builders<Comment>.Sort.Ascending(c => c.CreatedAt) : Builders<Comment>.Sort.Descending(c => c.CreatedAt))
                .Skip(startIndex)
                .Limit(limit)
                .ToListAsync();

            var totalComments = await _context.Comment.CountDocumentsAsync(_ => true);
            var now = DateTime.UtcNow;
            var oneMonthAgo = now.AddMonths(-1);
            var lastMonthComments = await _context.Comment.CountDocumentsAsync(c => c.CreatedAt >= oneMonthAgo);

            return (comments, totalComments, lastMonthComments);
        }
    }
}

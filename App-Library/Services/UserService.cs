using App_Library.Models;
using App_Library.Services.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Library.Services
{
    internal class UserService : IUserService
    {
        private readonly MongoDbContext _context;

        public UserService(MongoDbContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetUsersAsync()
        {
            // Lấy danh sách người dùng từ cơ sở dữ liệu
            return await _context.Users.Find(FilterDefinition<User>.Empty).ToListAsync();
        }

        //public async Task<UserStatistics> GetUserStatisticsAsync(string sort, int startIndex, int limit)
        //{
        //    // Tính toán và trả về thông tin thống kê người dùng
        //    var sortDirection = sort == "desc" ? -1 : 1;
        //    var users = await _context.Users
        //        .Find(_ => true)
        //        .Sort(sortDirection == 1 ? Builders<User>.Sort.Ascending(u => u.CreatedAt) : Builders<User>.Sort.Descending(u => u.CreatedAt))
        //        .Skip(startIndex)
        //        .Limit(limit)
        //        .ToListAsync();

        //    var totalUsers = await _context.Users.CountDocumentsAsync(_ => true);
        //    var now = DateTime.UtcNow;
        //    var oneMonthAgo = now.AddMonths(-1);
        //    var lastMonthUsers = await _context.Users.CountDocumentsAsync(u => u.CreatedAt >= oneMonthAgo);

        //    return new UserStatistics
        //    {
        //        TotalUsers = totalUsers,
        //        LastMonthUsers = lastMonthUsers,
        //        Users = users
        //    };
        //}

        //public async Task<User> GetCurrentUserAsync()
        //{
        //    // Lấy thông tin người dùng hiện tại
        //    var currentUsername = //... (lấy từ context hoặc session)
        //return await _context.Users.Find(u => u.Username == currentUsername).FirstOrDefaultAsync();
        //}

        public async Task<User> GetUserByIdAsync(string id)
        {
            return await _context.Users.Find(u => u.Id == id).FirstOrDefaultAsync();
        }

        //public async Task<User> UpdateUserAsync(string id, UpdateUserDto updatedUser)
        //{
        //    var filter = Builders<User>.Filter.Eq("_id", new ObjectId(id));
        //    var updateDefinition = new List<UpdateDefinition<User>>();

        //    if (!string.IsNullOrEmpty(updatedUser.Email))
        //    {
        //        updateDefinition.Add(Builders<User>.Update.Set(u => u.Email, updatedUser.Email));
        //    }

        //    // ... thêm các thuộc tính khác

        //    if (!updateDefinition.Any())
        //    {
        //        throw new InvalidOperationException("No fields to update");
        //    }

        //    var update = Builders<User>.Update.Combine(updateDefinition);
        //    return await _context.Users.FindOneAndUpdateAsync(filter, update, new FindOneAndUpdateOptions<User>
        //    {
        //        ReturnDocument = ReturnDocument.After
        //    });
        //}

        public async Task<bool> SoftDeleteUserAsync(string id)
        {
            var filter = Builders<User>.Filter.Eq("_id", new ObjectId(id));
            var update = Builders<User>.Update.Set("IsActive", false);
            var result = await _context.Users.UpdateOneAsync(filter, update);
            return result.MatchedCount > 0;
        }

        public async Task<bool> ActivateUserAsync(string id)
        {
            var filter = Builders<User>.Filter.Eq("_id", new ObjectId(id));
            var update = Builders<User>.Update.Set("IsActive", true);
            var result = await _context.Users.UpdateOneAsync(filter, update);
            return result.MatchedCount > 0;
        }
    }
}

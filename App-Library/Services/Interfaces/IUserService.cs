using App_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Library.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<User>> GetUsersAsync();
        Task<(List<User>, long totalUser, long lastMonthUser)> GetUserStatisticsAsync(string sort, int startIndex, int limit);
        Task<User> GetCurrentUserAsync();
        Task<User> GetUserByIdAsync(string id);
        //Task<User> UpdateUserAsync(string id, UpdateUserDto updatedUser);
        Task<bool> SoftDeleteUserAsync(string id);
        Task<bool> ActivateUserAsync(string id);
    }
}

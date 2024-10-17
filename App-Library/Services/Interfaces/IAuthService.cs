using App_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Library.Services.Interfaces
{
    public interface IAuthService
    {
        Task LoginAsync(string username, string password);
        Task<bool> SignUpAsyn(SignUpRequest request);
        //Task<string> GoogleLoginAsync(GoogleLoginRequest request);
    }
}

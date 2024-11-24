using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace App_Library.Services
{
    internal class AuthService
    {
        private readonly HttpClient _httpClient;

        public AuthService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://books-webapplication-plh6.onrender.com/");
        }

        // Gọi API đăng nhập
        public async Task<bool> LoginAsync(string username, string password)
        {
            var request = new LoginRequest { Username = username, Password = password };
            var response = await _httpClient.PostAsJsonAsync("api/auth/login", request);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<AuthResponse>();
                Session.Token = result.Token;
                return true;
            }
            return false;
        }

        // Gọi API đăng ký
        public async Task<string> SignUpAsync(string username, string email, string password)
        {
            var request = new SignUpRequest { Username = username, Email = email, Password = password };
            var response = await _httpClient.PostAsJsonAsync("api/auth/signup", request);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<AuthResponse>();
                return "Success";
            }

            return await response.Content.ReadAsStringAsync();
        }

        // Gọi API đăng nhập bằng Google
        public async Task<bool> GoogleLoginAsync(GoogleLoginRequest googleLoginRequest)
        {
            //var request = new GoogleLoginRequest { Email = email, Name = name, GooglePhotoURL = googlePhotoURL };
            var response = await _httpClient.PostAsJsonAsync("api/auth/google-login", googleLoginRequest);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<AuthResponse>();
                Session.Token = result.Token;
                return true;
            }
            return false;
        }
    }

    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class SignUpRequest
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
    }

    public class GoogleLoginRequest
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string GooglePhotoURL { get; set; }
    }

    public class AuthResponse
    {
        public string Token { get; set; }
    }

}

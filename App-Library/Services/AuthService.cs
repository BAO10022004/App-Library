using App_Library.Models;
using App_Library.Views.ToolerForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public async Task<bool> LoginAsync(string username, string password, Control uiControl)
        {
            // Tạo LoadingForm
            LoadingForm loadingForm = new LoadingForm();

            // Hiển thị LoadingForm ngay lập tức
            loadingForm.Show();

            var request = new LoginRequest { Username = username, Password = password };

            // Gửi request đăng nhập trong khi loading form đang hiển thị
            var response = await _httpClient.PostAsJsonAsync("api/auth/login", request);

            // Sau khi hoàn thành yêu cầu HTTP, kiểm tra kết quả
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<AuthResponse>();
                Session.Token = result.Token;

                // Đóng LoadingForm khi thành công
                loadingForm.Hide();
                loadingForm.Close();

                (new AlertSuccess("Success")).ShowDialog();
                return true;
            }

            // Nếu đăng nhập thất bại, đóng LoadingForm
            loadingForm.Hide();
            loadingForm.Close();

            (new AlertFail("Login Fail")).ShowDialog();
            return false;
        }




        // Gọi API đăng ký
        public async Task<string> SignUpAsync(string username, string email, string password)
        {
            // Tạo LoadingForm
            // Tạo LoadingForm
            LoadingForm loadingForm = new LoadingForm();

            // Hiển thị LoadingForm ngay lập tức
            loadingForm.Show();
            var request = new SignUpRequest { Username = username, Email = email, Password = password };
            var response = await _httpClient.PostAsJsonAsync("api/auth/signup", request);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<AuthResponse>();
                Session.Token = result.Token;


                // Đóng LoadingForm khi thành công
                loadingForm.Hide();
                loadingForm.Close();

                (new AlertSuccess("Success")).ShowDialog();
                return "Success";
            }
            // Nếu đăng nhập thất bại, đóng LoadingForm
            loadingForm.Hide();
            loadingForm.Close();

            (new AlertFail("Login Fail")).ShowDialog();
            return await response.Content.ReadAsStringAsync();
        }

        // Lấy người dùng theo email
        public async Task<User> GetUserByEmail(string email)
        {
            var request = new {Email = email};
            var response = await _httpClient.PostAsJsonAsync("api/auth/getUserByEmail",request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<User>();
        }

        // Kiểm tra mật khẩu người dùng
        public async Task<bool> CheckPassword(string username, string password)
        {
            var request = new LoginRequest { Username = username, Password = password };
            var response = await _httpClient.PostAsJsonAsync("api/auth/checkPassword", request);

            return response.IsSuccessStatusCode;
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

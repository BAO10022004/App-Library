﻿using App_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;
using App_Library.Views.ToolerForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;

namespace App_Library.Services
{
    internal class UserService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;
        public UserService()
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");

                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException("appsettings.json file not found in the application directory.");
                }

                var json = File.ReadAllText(filePath);

                var settings = JsonConvert.DeserializeObject<AppConfig>(json);

                _baseUrl = settings?.ApiSettings?.BaseUrl ?? throw new Exception("BaseUrl is not configured in appsettings.json");

                _httpClient = new HttpClient();
                _httpClient.BaseAddress = new Uri(_baseUrl);
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Session.Token);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error initializing AuthService: {ex.Message}", ex);
            }
        }
        // Lấy danh sách tất cẩ người dùng
        public async Task<List<User>> GetUsersAsync()
        {
            var response = await _httpClient.GetAsync("api/users");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<User>>();
        }
        // Thống kê người dùng đã đăng ký tháng trước
        public async Task<UserResponse> GetUsersStatisticAsync(string sort = "asc", int startIndex = 0, int limit = 10)
        {
            var response = await _httpClient.GetAsync($"api/users/statistic?sort={sort}&startIndex={startIndex}&limit={limit}");
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            var userResponse = JsonSerializer.Deserialize<UserResponse>(responseBody);
            return userResponse;
        }
        // Lay nguoi dung hien tai
        public async Task<User> GetCurrentUserAsync()
        {
            var response = await _httpClient.GetAsync("api/users/me");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<User>();
        }
        // Lay nguoi dung theo ID
        public async Task<User> GetUserByIdAsync(string id)
        {
            var response = await _httpClient.GetAsync($"api/users/{id}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<User>();
        }
        public async Task<User> GetUserByUsernameAsync(string id)
        {
            // Gửi yêu cầu GET tới API
            var response = await _httpClient.GetAsync($"api/users/{id}");

            // Kiểm tra xem yêu cầu có thành công không
            if (response.IsSuccessStatusCode)
            {
                // Đọc dữ liệu trả về và chuyển thành đối tượng User
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var user = JsonConvert.DeserializeObject<User>(jsonResponse);
                return user;
            }
            else
            {
                // Nếu không thành công, xử lý lỗi (ví dụ: ném exception hoặc trả về null)
                return null;
            }
        }
        // Cap nhat nguoi dung theo ID
        public async Task<bool> UpdateUserAsync(string id, UpdateUserDTO updatedUser)
        {
            LoadingForm loadingForm = new LoadingForm();

            // Hiển thị LoadingForm ngay lập tức
            loadingForm.Show();
            var response = await _httpClient.PutAsJsonAsync($"api/users/update/{id}", updatedUser);
            Session.CurentUser = await response.Content.ReadFromJsonAsync<User>();
            // Sau khi hoàn thành yêu cầu HTTP, kiểm tra kết quả
            if (response.IsSuccessStatusCode)
            {

                // Đóng LoadingForm khi thành công
                loadingForm.Hide();
                loadingForm.Close();
                (new AlertSuccess("SAVES SUCCESS" + "\n" + "RE-LOGIN TO COUNTINUE")).ShowDialog();
                return true;
            }
            // Nếu đăng nhập thất bại, đóng LoadingForm
            loadingForm.Hide();
            loadingForm.Close();
            (new AlertFail(" Fail")).ShowDialog();
            return false;
        }
        // Tắc người dùng
        public async Task<bool> SoftDeleteUserAsync(string id)
        {
            var response = await _httpClient.DeleteAsync($"api/users/delete/{id}");
            return response.IsSuccessStatusCode;
        }
        // Kích hoạt người dùng
        public async Task<bool> ActivateUserAsync(string id)
        {
            var response = await _httpClient.PutAsync($"api/users/activate/{id}", null);
            return response.IsSuccessStatusCode;
        }
    }
}

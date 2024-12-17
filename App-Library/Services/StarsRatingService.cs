using App_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.IO;
using Newtonsoft.Json;

namespace App_Library.Services
{
    internal class StarsRatingService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;
        public StarsRatingService()
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
            // Tạo đánh giá mới 
            public async Task<StarsRating> CreateRatingAsync(StarsRating rating)
        {
            var response = await _httpClient.PostAsJsonAsync("api/starsrating", rating);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<StarsRating>();
            }
            else
            {
                throw new Exception($"Failed to create rating: {await response.Content.ReadAsStringAsync()}");
            }
        }
        // Lấy đánh giá theo ID
        public async Task<StarsRating> GetRatingByIdAsync(string id)
        {
            var response = await _httpClient.GetAsync($"api/starsrating/{id}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<StarsRating>();
            }
            else
            {
                throw new Exception($"Failed to get rating by ID: {await response.Content.ReadAsStringAsync()}");
            }
        }
        // Cập nhật đánh giá theo ID
        public async Task UpdateRatingAsync(string id, StarsRating updatedRating)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/starsrating/{id}", updatedRating);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Failed to update rating: {await response.Content.ReadAsStringAsync()}");
            }
        }
        // Xóa đánh giá theo ID
        public async Task DeleteRatingAsync(string id)
        {
            var response = await _httpClient.DeleteAsync($"api/starsrating/{id}");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Failed to delete rating: {await response.Content.ReadAsStringAsync()}");
            }
        }
        // Lấy danh sách các cuốn sách có đánh giá cao nhất 
        public async Task<List<BookRatingSummary>> GetHotBooksAsync()
        {
            var response = await _httpClient.GetAsync("api/starsrating/hot-books");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<BookRatingSummary>>();
            }
            else
            {
                throw new Exception($"Failed to get hot books: {await response.Content.ReadAsStringAsync()}");
            }
        }
        // Lấy tất cả đánh giá của 1 cuốn sách theo ID sách
        public async Task<BookRating> GetBookRatingAsync(string bookId)
        {
            var response = await _httpClient.GetAsync($"api/starsrating/book/{bookId}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<BookRating>();
            }
            else
            {
                return null;
            }
        }
    }
}

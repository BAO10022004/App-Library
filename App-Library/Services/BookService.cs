using App_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using System.Net.Http.Json;
using System.Windows;
using System.IO;
using Newtonsoft.Json;

namespace App_Library.Services
{
    internal class BookService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public BookService()
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
            // Lấy danh sách sách
            public async Task<List<Book>> GetBooksAsync()
        {
            var response = await _httpClient.GetAsync("api/books");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<Book>>() ?? new List<Book>();
            }
            throw new Exception("Lỗi khi tải danh sách sách.");
        }

        // Lấy sách theo Slug
        public async Task<Book> GetBookBySlugAsync(string slug)
        {
            if(slug == null)
            {
                return null;
            }
            var response = await _httpClient.GetAsync($"api/books/{slug}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Book>();
            }
            return null;
        }

        // Tạo sách mới
        public async Task<bool> PostBookAsync(Book newBook)
        {
            var response = await _httpClient.PostAsJsonAsync("api/books", newBook);
            return response.IsSuccessStatusCode;
        }

        // Tìm kiếm sách
        public async Task<SearchBooksResponse> SearchBooksAsync(string searchTerm, string sort = "desc", string genre = null, int startIndex = 0, int limit = 4)
        {
            var url = $"api/books/search?searchTerm={searchTerm}&sort={sort}&genre={genre}&startIndex={startIndex}&limit={limit}";
            var response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<SearchBooksResponse>();
            }
            throw new Exception("Lỗi khi tìm kiếm sách.");
        }

        // Cập nhật sách
        public async Task<Book> UpdateBookAsync(string id, UpdateBookDTO updateBookDTO)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/books/update/{id}", updateBookDTO);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Book>();
            }
            throw new Exception("Không thể cập nhật sách.");
        }

        // Xóa sách
        public async Task<bool> DeleteBookAsync(string id)
        {
            var response = await _httpClient.DeleteAsync($"api/books/delete/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}

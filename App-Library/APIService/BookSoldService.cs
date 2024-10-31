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

namespace App_Library.APIService
{
    internal class BookSoldService
    {
        private readonly HttpClient _httpClient;

        public BookSoldService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://books-webapplication-plh6.onrender.com/");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Session.Token);
        }

        // Lấy danh sách các sách đã bán
        public async Task<List<BookSold>> GetBooksSoldAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<BookSold>>("api/booksold");
        }

        // Lấy danh sách sách của người dùng đang trong quá trình xử lý
        public async Task<List<BookSold>> GetBooksInProgressAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<BookSold>>("api/booksold/user/books-in-progress");
        }

        // Lấy danh sách sách đã mua của người dùng
        public async Task<List<BookSold>> GetBoughtBooksAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<BookSold>>("api/booksold/user/bought-books");
        }

        // Lấy danh sách sách đã bán với phân trang và sắp xếp
        public async Task<SoldBooksResponse> GetSoldBooksAsync(string sort = "asc", int startIndex = 0, int limit = 10)
        {
            var url = $"api/booksold/sold-books?sort={sort}&startIndex={startIndex}&limit={limit}";
            var response = await _httpClient.GetFromJsonAsync<SoldBooksResponse>(url);
            return response;
        }

        // Lấy danh sách sách đang chờ duyệt
        public async Task<List<BookSold>> GetPendingBooksSoldAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<BookSold>>("api/booksold/pending");
        }

        // Lấy sách theo ID
        public async Task<BookSold> GetBookSoldByIdAsync(string bookId)
        {
            return await _httpClient.GetFromJsonAsync<BookSold>($"api/booksold/{bookId}");
        }

        // Tạo yêu cầu mua sách mới
        public async Task<string> CreateBookSoldAsync(BookSold newBookSold)
        {
            var response = await _httpClient.PostAsJsonAsync("api/booksold", newBookSold);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            return $"Error: {response.StatusCode}";
        }

        // Duyệt yêu cầu mua sách
        public async Task<bool> ApproveBookSoldAsync(string bookId)
        {
            var response = await _httpClient.PutAsync($"api/booksold/{bookId}/approve", null);
            return response.IsSuccessStatusCode;
        }

        // Từ chối yêu cầu mua sách
        public async Task<bool> RejectBookSoldAsync(string bookId)
        {
            var response = await _httpClient.PutAsync($"api/booksold/{bookId}/reject", null);
            return response.IsSuccessStatusCode;
        }
    }
}

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
using Firebase.Auth;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using User = App_Library.Models.User;
using System.IO;
using Newtonsoft.Json;

namespace App_Library.Services
{
    internal class BookSoldService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;
        public BookSoldService()
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

        public async Task<List<BookSold>> GetBooksInProgressByOnGiaBao(User _user)
        {
            string usernameCurrent = _user.Username;
            string passwordCurrent = _user.PasswordHash;
            AuthService db = new AuthService();
            bool result = await db.Login("admin", "123456", null);
            if (!result)
            {
                await db.Login(usernameCurrent, passwordCurrent, null);
                return null;
            }
            else
            {
                var dbBookSold = await GetBooksSoldAsync();
                List<BookSold> bookSolds = new List<BookSold>();
                dbBookSold.ForEach(x =>
                {
                    if (x.UserId == _user.Id && (x.Status.Equals("Pending") || x.Status.Equals("Approved")))
                    {
                        bookSolds.Add(x);
                    }
                });
                return bookSolds;
            }
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

using App_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using System.Net.Http.Json;
using static Google.Apis.Requests.BatchRequest;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace App_Library.Services
{
    internal class CommentService
    {
        private readonly HttpClient _httpClient;

        public CommentService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://books-webapplication-plh6.onrender.com/");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Session.Token);
        }

        // Tạo comment
        public async Task<Comment> CreateCommentAsync(Comment comment)
        {
            var response = await _httpClient.PostAsJsonAsync("api/comments", comment);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Comment>();
            }
            else
            {
                throw new Exception($"Failed to create comment: {await response.Content.ReadAsStringAsync()}");
            }
        }

        // Lấy comment của một sách
        public async Task<List<Comment>> GetBookCommentsAsync(string bookId)
        {
            var response = await _httpClient.GetAsync($"api/comments/book/{bookId}");

            // Kiểm tra xem yêu cầu có thành công không

            // Đọc dữ liệu trả về và chuyển thành danh sách Comment
            var jsonResponse = await response.Content.ReadAsStringAsync();
            var comments = JsonConvert.DeserializeObject<List<Comment>>(jsonResponse);
            return comments;
        }

        // Thích hoặc bỏ thích comment
        public async Task<Comment> LikeCommentAsync(string commentId)
        {
            var response = await _httpClient.PostAsync($"api/comments/{commentId}/likes", null);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Comment>(responseBody);
        }

        // Chỉnh sửa comment
        public async Task<Comment> EditCommentAsync(string commentId, string newContent)
        {
            var editDto = new UpdateCommentDTO { Content = newContent };
            var content = new StringContent(JsonSerializer.Serialize(editDto), Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"api/comments/{commentId}", content);

            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Comment>(responseBody);
        }

        // Xóa comment
        public async Task<bool> DeleteCommentAsync(string commentId)
        {
            var response = await _httpClient.DeleteAsync($"api/comments/{commentId}");
            return response.IsSuccessStatusCode;
        }

        // Lấy tất cả comments với phân trang
        public async Task<(List<Comment>, int, int)> GetCommentsAsync(int startIndex = 0, int limit = 10, string sort = "asc")
        {
            var response = await _httpClient.GetAsync($"api/comments?startIndex={startIndex}&limit={limit}&sort={sort}");
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();

            var jsonDocument = JsonDocument.Parse(responseBody);
            var comments = JsonSerializer.Deserialize<List<Comment>>(jsonDocument.RootElement.GetProperty("comments").GetRawText());
            var totalComments = jsonDocument.RootElement.GetProperty("totalComments").GetInt32();
            var lastMonthComments = jsonDocument.RootElement.GetProperty("lastMonthComments").GetInt32();

            return (comments, totalComments, lastMonthComments);
        }

        public async Task<CommentResponse> GetAllCommentAsync()
        {
            var response = await _httpClient.GetAsync("api/comments/all");
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();

            var jsonDocument = JsonDocument.Parse(responseBody);
            var comments = JsonSerializer.Deserialize<List<Comment>>(jsonDocument.RootElement.GetProperty("comments").GetRawText());
            var totalComments = jsonDocument.RootElement.GetProperty("totalComments").GetInt32();
            var lastMonthComments = jsonDocument.RootElement.GetProperty("lastMonthComments").GetInt32();

            return await response.Content.ReadFromJsonAsync<CommentResponse>();
            //return comments;
        }
    }
    class CommentResponse
    {
        public List<Comment> Comments { get; set; }
        public long TotalComments { get; set; }
        public long LastMonthComments { get; set; }
    }
}

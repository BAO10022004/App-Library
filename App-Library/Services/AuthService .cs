using App_Library.Models;
using App_Library.Services.Interfaces;
using App_Library.Views;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library.Services
{
    public class AuthService : IAuthService
    {
        private readonly MongoDbContext _context;

        public AuthService(MongoDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task LoginAsync(string username, string password)
        {
            // Giả sử _context là đối tượng bạn đang sử dụng để kết nối MongoDB
            var user = await _context.Users.Find(u => u.Username == username).FirstOrDefaultAsync();
            if (user == null)
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!user.IsActive)
            {
                MessageBox.Show("User is deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra mật khẩu hash
            if (!BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            {
                // Kiểm tra nếu mật khẩu chưa được hash
                if (user.PasswordHash == password)
                {
                    user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(password);
                    await _context.Users.ReplaceOneAsync(u => u.Id == user.Id, user);
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Sau khi đăng nhập thành công, tạo một phiên hoặc lưu trữ thông tin người dùng tại đây
            MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }

        public async Task<string> SignUpAsync(SignUpRequest request)
        {
            var existingUser = await _context.Users.Find(u => u.Username == request.Username).FirstOrDefaultAsync();
            var existingEmail = await _context.Users.Find(u => u.Email == request.Email).FirstOrDefaultAsync();
            if (existingUser != null) throw new InvalidOperationException("Username already exists");
            if (existingEmail != null) throw new InvalidOperationException("Email already exists");

            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(request.Password);
            var user = new User
            {
                Email = request.Email,
                Username = request.Username,
                PasswordHash = hashedPassword,
                IsActive = true
            };

            await _context.Users.InsertOneAsync(user);
            return GenerateJwtToken(user);
        }

        //public async Task<string> GoogleLoginAsync(GoogleLoginRequest request)
        //{
        //    var user = await _context.Users.Find(u => u.Email == request.Email).FirstOrDefaultAsync();
        //    if (user != null)
        //    {
        //        return GenerateJwtToken(user);
        //    }
        //    else
        //    {
        //        var generatedPassword = GenerateRandomPassword();
        //        var hashedPassword = BCrypt.Net.BCrypt.HashPassword(generatedPassword);
        //        var username = request.Name.ToLower().Replace(" ", "") + new Random().Next(1000, 9999);

        //        var newUser = new User
        //        {
        //            Username = username,
        //            Email = request.Email,
        //            PasswordHash = hashedPassword,
        //            PhotoURL = request.GooglePhotoURL,
        //            IsActive = true
        //        };

        //        await _context.Users.InsertOneAsync(newUser);
        //        return GenerateJwtToken(newUser);
        //    }
        //}

        //private string GenerateJwtToken(User user)
        //{
        //    var claims = new[]
        //    {
        //    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
        //    new Claim(ClaimTypes.Name, user.Username),
        //    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        //};

        //    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"] ?? throw new ArgumentNullException("Jwt:Key")));
        //    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        //    var token = new JwtSecurityToken(
        //        issuer: _configuration["Jwt:Issuer"],
        //        audience: _configuration["Jwt:Audience"],
        //        claims: claims,
        //        expires: DateTime.Now.AddDays(1),
        //        signingCredentials: creds);

        //    return new JwtSecurityTokenHandler().WriteToken(token);
        //}

        //private string GenerateRandomPassword()
        //{
        //    return Guid.NewGuid().ToString("N").Substring(0, 8) + Guid.NewGuid().ToString("N").Substring(0, 8);
        //}
    }
}

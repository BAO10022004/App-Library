using App_Library.Models;
using App_Library.Services.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace App_Library.Services
{
    internal class AuthService : IAuthService
    {
        //private readonly MongoDbContext _context;
        //private readonly IConfiguration _configuration;

        //public AuthService(MongoDbContext context, IConfiguration configuration)
        //{
        //    _context = context ?? throw new ArgumentNullException(nameof(context));
        //    _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        //}

        //public async Task<string> LoginAsync(LoginRequest request)
        //{
        //    var user = await _context.Users.Find(u => u.Username == request.Username).FirstOrDefaultAsync();
        //    if (user == null || !user.IsActive || !BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
        //    {
        //        throw new UnauthorizedAccessException("Invalid username or password");
        //    }

        //    return GenerateJwtToken(user);
        //}

        //public async Task<string> SignUpAsync(SignUpRequest request)
        //{
        //    var existingUser = await _context.Users.Find(u => u.Username == request.Username).FirstOrDefaultAsync();
        //    var existingEmail = await _context.Users.Find(u => u.Email == request.Email).FirstOrDefaultAsync();
        //    if (existingUser != null) throw new InvalidOperationException("Username already exists");
        //    if (existingEmail != null) throw new InvalidOperationException("Email already exists");

        //    var hashedPassword = BCrypt.Net.BCrypt.HashPassword(request.Password);
        //    var user = new User
        //    {
        //        Email = request.Email,
        //        Username = request.Username,
        //        PasswordHash = hashedPassword,
        //        IsActive = true
        //    };

        //    await _context.Users.InsertOneAsync(user);
        //    return GenerateJwtToken(user);
        //}

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

        private string GenerateRandomPassword()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 8) + Guid.NewGuid().ToString("N").Substring(0, 8);
        }
    }
}

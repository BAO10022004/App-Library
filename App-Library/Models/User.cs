using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Library.Models
{
    public class User
    {
        [BsonId]  // Indicates that this is the primary key (_id in MongoDB)
        [BsonRepresentation(BsonType.ObjectId)]  // Converts ObjectId to string for easier handling
        public string Id { get; set; }  // Loại bỏ nullable reference types

        [BsonElement("username")]  // Maps the property to the "username" field in MongoDB.
        public string Username { get; set; }  // Loại bỏ required

        [BsonElement("email")]
        public string Email { get; set; }  // Loại bỏ required

        [BsonElement("password_hash")]
        public string PasswordHash { get; set; }  // Loại bỏ required

        [BsonElement("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [BsonElement("is_active")]
        public bool IsActive { get; set; }

        [BsonElement("is_admin")]
        public bool IsAdmin { get; set; } = false;

        [BsonElement("photoURL")]
        public string PhotoURL { get; set; }  // Loại bỏ nullable reference
    }
    public class UserResponse
    {
        public long TotalUsers { get; set; }
        public long LastMonthUsers { get; set; }
        public List<User> Users { get; set; }
    }
}

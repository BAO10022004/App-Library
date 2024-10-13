using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Library.Models
{
    public class BookSold
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }  // Loại bỏ nullable reference

        [BsonElement("book_id")]
        public string BookId { get; set; }  // Loại bỏ nullable reference

        [BsonElement("title")]
        public string Title { get; set; }  // Loại bỏ nullable reference

        [BsonElement("price")]
        public decimal Price { get; set; }

        [BsonElement("user_id")]
        public string UserId { get; set; }  // Loại bỏ nullable reference

        [BsonElement("username")]
        public string Username { get; set; }  // Loại bỏ nullable reference

        [BsonElement("email")]
        public string Email { get; set; }  // Loại bỏ nullable reference

        [BsonElement("status")]
        public string Status { get; set; } = "Pending";  // Giá trị mặc định là "Pending"

        [BsonElement("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [BsonElement("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        [BsonElement("image")]
        public string Image { get; set; }  // Loại bỏ nullable reference

        [BsonElement("genre")]
        public string Genre { get; set; }  // Loại bỏ nullable reference

        [BsonElement("slug")]
        public string Slug { get; set; }  // Loại bỏ nullable reference
    }
}

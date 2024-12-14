using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Library.Models
{
    public class Comment
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }  // Loại bỏ nullable reference

        [BsonElement("content")]
        public string Content { get; set; }  // Loại bỏ nullable reference và required

        [BsonElement("userId")]
        public string UserId { get; set; }  // Loại bỏ nullable reference và required

        [BsonElement("bookId")]
        public string BookId { get; set; }  // Loại bỏ nullable reference và required

        [BsonElement("likes")]
        public string[] Likes { get; set; } = Array.Empty<string>();  

        [BsonElement("number_of_likes")]
        public int NumberOfLikes { get; set; } = 0;

        [BsonElement("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [BsonElement("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}

using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Library.Models
{
    public class StarsRating
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }  // Loại bỏ nullable reference

        [BsonElement("bookId")]
        public string BookId { get; set; }  // Loại bỏ required

        [BsonElement("title")]  // Maps the property to the "title" field in MongoDB
        public string Title { get; set; }  // Loại bỏ required

        [BsonElement("author")]
        public string Author { get; set; }  // Loại bỏ required

        [BsonElement("userId")]
        public string UserId { get; set; }  // Loại bỏ required

        [BsonElement("genre")]
        public string Genre { get; set; }  // Loại bỏ required

        [BsonElement("stars")]
        public int Stars { get; set; }

        [BsonElement("image")]
        public string Image { get; set; }  // Loại bỏ nullable reference

        [BsonElement("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }

    public class BookRatingSummary
    {
        public string BookId { get; set; }  // Loại bỏ required
        public double AverageStars { get; set; }
        public int OneStar { get; set; }
        public int TwoStars { get; set; }
        public int ThreeStars { get; set; }
        public int FourStars { get; set; }
        public int FiveStars { get; set; }
    }
    public class BookRating
    {
        public string BookId { get; set; }
        public double AverageStars { get; set; }
        public int TotalRatings { get; set; }
    }
}

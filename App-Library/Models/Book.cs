using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Library.Models
{
    public class Book
    {
        [BsonId]  // Indicates that this is the primary key (_id in MongoDB)
        [BsonRepresentation(BsonType.ObjectId)]  // Converts ObjectId to string for easier handling
        public string Id { get; set; } // Loại bỏ nullable reference

        [BsonElement("title")]  // Maps the property to the "title" field in MongoDB
        public string Title { get; set; } // Không cần dùng `required`

        [BsonElement("author")]
        public string Author { get; set; } // Không cần dùng `required`

        [BsonElement("published_year")]
        public int PublishedYear { get; set; }

        [BsonElement("genre")]
        public string Genre { get; set; } // Không cần dùng `required`

        [BsonElement("price")]
        public decimal Price { get; set; }

        [BsonElement("content")]
        public string Content { get; set; } // Không cần dùng `required`

        [BsonElement("username")]
        public string Username { get; set; } // Không cần dùng `required`

        [BsonElement("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [BsonElement("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        [BsonElement("slug")]
        public string Slug { get; set; } // Có thể để nullable nếu cần, dùng kiểu string thông thường

        [BsonElement("image")]
        public string Image { get; set; } // Có thể để nullable nếu cần, dùng kiểu string thông thường

        [BsonElement("pdfUrl")]
        public string PdfUrl { get; set; } // Có thể để nullable nếu cần, dùng kiểu string thông thường
    }
    public class SearchBooksResponse
    {
        public List<Book> Books { get; set; }
        public long TotalBooks { get; set; }
    }
}

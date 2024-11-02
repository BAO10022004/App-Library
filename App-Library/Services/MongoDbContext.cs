using App_Library.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library.Services
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }

        public IMongoCollection<Book> Books => _database.GetCollection<Book>("Books");
        public IMongoCollection<User> Users => _database.GetCollection<User>("Users");
        public IMongoCollection<BookSold> BookSold => _database.GetCollection<BookSold>("BookSold");
        public IMongoCollection<Comment> Comment => _database.GetCollection<Comment>("Comments");
        public IMongoCollection<StarsRating> StarsRatings => _database.GetCollection<StarsRating>("StarsRating");


        public IMongoDatabase Database => _database;

        public async Task<bool> UserExistsAsync(string username, string email)
        {
            var filter = Builders<User>.Filter.Or(
                Builders<User>.Filter.Eq(u => u.Username, username),
                Builders<User>.Filter.Eq(u => u.Email, email)
            );
            return await Users.Find(filter).AnyAsync();
        }
    }
}

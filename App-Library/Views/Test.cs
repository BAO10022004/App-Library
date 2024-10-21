using App_Library.Models;
using App_Library.Services;
using App_Library.Services.Interfaces;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library.Views
{
    public partial class Test : Form
    {
        private readonly MongoDbContext _context;
        private readonly IUserService _userService;
        private readonly IBookService _bookService;
        public Test(MongoDbContext context)
        {
            _context = context;
            _userService = new UserService(_context);
            _bookService = new BookService(_context);
            InitializeComponent();
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            var book = new Book
            {
                //Id = ObjectId.GenerateNewId().ToString(), // Tạo ObjectId mới và chuyển đổi thành chuỗi
                Title = "Example Book Title",
                //Author = "Author Name",
                PublishedYear = 2023,
                Genre = "Fiction",
                Price = 19.99m,
                Content = "This is the content of the book...",
                Username = "exampleUsername",
                //CreatedAt = DateTime.UtcNow, // Thời gian hiện tại
                //UpdatedAt = DateTime.UtcNow, // Thời gian hiện tại
                //Slug = "example-book-title", // Chuỗi slug (thường là URL thân thiện)
                Image = "https://example.com/image.jpg", // URL ảnh bìa
                PdfUrl = "https://example.com/book.pdf"  // URL file PDF của sách
            };

            var updateBookDto = new UpdateBookDTO
            {
                Title = "New Book Title",
                Author = "Author Name",
                PublishedYear = 2024,
                Genre = "Science Fiction",
                Price = 29.99m,
                Content = "This is the updated content of the book...",
                Username = "user123",
                Image = "https://example.com/new-image.jpg",
                PdfUrl = "https://example.com/new-book.pdf"
            };


            //var check = await _bookService.AddBookAsync(book, "admin");
            //var check1 = await _bookService.UpdateBookAsync("6716c0cfdd6aaaef32ce32d3", updateBookDto, "admin");
            var check2 = await _bookService.DeleteBookAsync("6716c0cfdd6aaaef32ce32d3", "admin");

            if (check2)
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Error");
            }

        }
    }
}

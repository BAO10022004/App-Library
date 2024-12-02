using App_Library.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Guna.UI2.WinForms;
using System.Net.Http;
using static Guna.UI2.Native.WinApi;
using App_Library.Views.ToolerForm;
using App_Library.Views;
using System.Drawing.Printing;
using App_Library.Views.UserView.CollectionHome;

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
        public async Task<Panel> CreateBookPanelAsync(int index, int rating = 4)
        {
            // Tạo panel mới với kích thước cố định
            PanelBook panel = new PanelBook(this);
            panel.Size = new Size(200, 350); // Kích thước giữ nguyên

            panel.BackColor = Color.FromArgb(240, 240, 255); // Màu nền tương tự hình

            // Thêm hình ảnh sách (tăng kích thước)
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(180, 270); // Tăng kích thước ảnh lớn    hơn
            pictureBox.Location = new Point(10, 10);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Name = "pictureBox" + index;
            // Load hình ảnh từ URL không đồng bộ
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var imageBytes = await client.GetByteArrayAsync(this.Image);
                    using (var ms = new System.IO.MemoryStream(imageBytes))
                    {
                        pictureBox.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }

            panel.Controls.Add(pictureBox);

            // Thêm nhãn số sao đánh giá
            Label ratingLabel = new Label();
            ratingLabel.Text = $"{rating} ★"; // Hiển thị số sao và biểu tượng ngôi sao
            ratingLabel.Location = new Point(75, 285); // Giảm kích thước thông tin
            ratingLabel.AutoSize = true;
            ratingLabel.Font = new Font("Arial", 9, FontStyle.Bold); // Giảm kích thước font chữ
            ratingLabel.Name = "rating" + index;
            panel.Controls.Add(ratingLabel);

            // Tạo nhãn tên sách (giảm kích thước hiển thị)
            Label titleLabel = new Label();
            titleLabel.Text = this.Title;
            titleLabel.Location = new Point(10, 305); // Giảm kích thước hiển thị của nhãn sách
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Arial", 10, FontStyle.Bold); // Giảm kích thước font chữ
            titleLabel.Name = "titleLabel" + index;
            panel.Controls.Add(titleLabel);
            titleLabel.ForeColor = Color.Blue;
            // Tạo nhãn tên tác giả (giảm kích thước hiển thị)
            Label authorLabel = new Label();
            authorLabel.Text = this.Author;
            authorLabel.Location = new Point(10, 325);
            authorLabel.AutoSize = true;
            authorLabel.Font = new Font("Arial", 9); // Giảm kích thước font chữ
            authorLabel.Name = "authorLabel" + index;
            panel.Controls.Add(authorLabel);
            panel.Margin = new Padding(5);
            panel.Name = "itemHotDeal" + index;
            panel.TabIndex = index;
            panel.BackColor = Color.White;
            //foreach(System.Windows.Forms.Control control in panel.Controls)
            //{
            //    control.Name = "Book" + control.Name + index;
            //}
            return panel;
        }
        public Panel CreateBookPanel(BoughtBook boughtBook)
        {
            Book book = this;
            // Tạo Panel chính
            PanelBook panel = new PanelBook(this);
            panel.Size = new Size(300, 400);
            panel.BackColor = System.Drawing.Color.White;
            panel.BorderColor = System.Drawing.Color.Blue;
            panel.BorderRadius = 15;
            panel.BorderThickness = 3;

            // Tạo PictureBox cho hình ảnh sách
            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(280, 200), // Kích thước hình ảnh
                Location = new Point(10, 10), // Vị trí trên Panel
                SizeMode = PictureBoxSizeMode.StretchImage,
                BorderStyle = BorderStyle.None,
                ImageLocation = this.Image // Đường dẫn đến ảnh của sách
            };

            // Tạo Label cho tiêu đề
            Label titleLabel = new Label
            {
                Text = this.Title,
                Font = new Font("Arial", 15, FontStyle.Bold),
                AutoSize = false,
                Size = new Size(280, 30),
                Location = new Point(10, 220),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Tạo Label cho thể loại (Genre)
            Label genreLabel = new Label
            {
                Text = this.Genre,
                Font = new Font("Arial", 10, FontStyle.Italic),
                AutoSize = false,
                Size = new Size(280, 20),
                Location = new Point(10, 260),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.Gray
            };

            // Tạo Label cho tác giả (Author)
            Label authorLabel = new Label
            {
                Text = $"Author: {this.Author}",
                Font = new Font("Arial", 10, FontStyle.Regular),
                AutoSize = false,
                Size = new Size(280, 20),
                Location = new Point(10, 290),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Tạo Button để mở PDF
            Button openPdfButton = new Button
            {
                Name = book.Title,
                Text = "Read PDF",
                Font = new Font("Arial", 10, FontStyle.Bold),
                Size = new Size(120, 30),
                Location = new Point(90, 330),
                BackColor = Color.LightBlue,
                FlatStyle = FlatStyle.Flat
            };

            // Gắn sự kiện cho nút "Read PDF"
            openPdfButton.Click += new EventHandler(boughtBook.clickRead);

            // Thêm các control vào Panel
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(titleLabel);
            panel.Controls.Add(genreLabel);
            panel.Controls.Add(authorLabel);
            panel.Controls.Add(openPdfButton);

            return panel;
        }

        internal void CreateBookAdPanel()
        {
            throw new NotImplementedException();
        }

        internal async Task<Panel> CreateBookPanelAsync()
        {
            throw new NotImplementedException();
        }
    }
    public class SearchBooksResponse
    {
        public List<Book> Books { get; set; }
        public long TotalBooks { get; set; }
    }
   
   
}

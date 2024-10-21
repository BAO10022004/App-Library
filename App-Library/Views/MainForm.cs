using App_Library.Models;
using App_Library.Services;
using App_Library.Services.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App_Library.Views
{
    public partial class MainForm : Form
    {
        private readonly MongoDbContext _context;
        private readonly IUserService _userService;
        private readonly IBookService _bookService;
        public MainForm(MongoDbContext context)
        {
            _context = context;
            _userService = new UserService(_context);
            _bookService = new BookService(_context);
            InitializeComponent();
            //this.Load += UserListForm_Load;
        }
        //private async void UserListForm_Load(object sender, EventArgs e)
        //{
        //    var users = await _userService.GetUsersAsync();
        //    MessageBox.Show($"Number of users fetched: {users.Count}");
        //    // Thiết lập ListView
        //    listView1.View = View.Details;  // Đặt chế độ hiển thị
        //    listView1.FullRowSelect = true;  // Cho phép chọn toàn bộ hàng
        //    listView1.GridLines = true;       // Hiển thị đường kẻ giữa các hàng
        //    listView1.Columns.Clear();         // Xóa các cột cũ nếu có
        //    listView1.Items.Clear();           // Xóa các item cũ nếu có

        //    // Thêm các cột vào ListView
        //    listView1.Columns.Add("Username", 150);  // Cột 1: Username
        //    listView1.Columns.Add("Email", 200);     // Cột 2: Email
        //    listView1.Columns.Add("Created At", 150);  // Cột 3: Created At

        //    // Thêm từng dòng dữ liệu người dùng vào ListView
        //    foreach (var user in users),
        //    {
        //        var listItem = new ListViewItem(user.Username);  // Cột 1: Username
        //        listItem.SubItems.Add(user.Email);               // Cột 2: Email
        //        listItem.SubItems.Add(user.CreatedAt.ToString());  // Cột 3: Created At
        //        listView1.Items.Add(listItem);  // Thêm vào ListView
        //    }

        //    // Điều chỉnh độ rộng của các cột tự động vừa với nội dung
        //    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public Panel CreateBookPanel(Book book, int index )
        {
            // Tạo panel mới
            Panel panel = new Panel();
            panel.Size = new Size(300, 150);
            panel.BorderStyle = BorderStyle.FixedSingle;

            // Thêm hình ảnh sách (nếu có)
            if (!string.IsNullOrEmpty(book.Image))
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(100, 150);
                pictureBox.Location = new Point(10, 10);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                // Load hình ảnh từ URL (hoặc từ file nếu có đường dẫn cục bộ)
                try
                {
                    pictureBox.Load(book.Image); // Đường dẫn hoặc URL của ảnh
                }
                catch (Exception)
                {
                }

                panel.Controls.Add(pictureBox);
            }

            // Tạo nhãn tên sách
            Label titleLabel = new Label();
            titleLabel.Text = $"Title: {book.Title}";
            titleLabel.Location = new Point(120, 10);
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Arial", 10, FontStyle.Bold);

            panel.Controls.Add(titleLabel);

            // Tạo nhãn tên tác giả
            Label authorLabel = new Label();
            authorLabel.Text = $"Author: {book.Author}";
            authorLabel.Location = new Point(120, 40);
            authorLabel.AutoSize = true;
            authorLabel.Font = new Font("Arial", 10);

            panel.Controls.Add(authorLabel);

            // Tạo nhãn năm xuất bản
            Label yearLabel = new Label();
            yearLabel.Text = $"Published Year: {book.PublishedYear}";
            yearLabel.Location = new Point(120, 70);
            yearLabel.AutoSize = true;
            yearLabel.Font = new Font("Arial", 9);

            panel.Controls.Add(yearLabel);
            panel.TabIndex =index;
            return panel;
        }
        private async void MainForm_Load(object sender, EventArgs e)
        {
            var books = await _bookService.GetAllBooksAsync();
            for(int i=0; i< 4; i++)
            {
                flowLayoutPanel1.Controls.Add(CreateBookPanel( books[i], i));
                flowLayoutPanel2.Controls.Add(CreateBookPanel(books[i+4], i));
                flowLayoutPanel3.Controls.Add(CreateBookPanel(books[i + 8], i));
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}

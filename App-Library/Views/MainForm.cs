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
        public Panel CreateBookPanel(Book book, int index, int rating = 4)
        {
            // Tạo panel mới với kích thước cố định
            Panel panel = new Panel();
            panel.Size = new Size(200, 350); // Kích thước giữ nguyên
            panel.BorderStyle = BorderStyle.None;
            panel.BackColor = Color.FromArgb(240, 240, 255); // Màu nền tương tự hình

            // Thêm hình ảnh sách (tăng kích thước)
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(180, 270); // Tăng kích thước ảnh lớn hơn
            pictureBox.Location = new Point(10, 10);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            // Load hình ảnh từ URL (hoặc từ file nếu có đường dẫn cục bộ)
            try
            {
                pictureBox.Load(book.Image); // Đường dẫn hoặc URL của ảnh
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
            panel.Controls.Add(ratingLabel);

            // Tạo nhãn tên sách (giảm kích thước hiển thị)
            Label titleLabel = new Label();
            titleLabel.Text = book.Title;
            titleLabel.Location = new Point(10, 305); // Giảm kích thước hiển thị của nhãn sách
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Arial", 10, FontStyle.Bold); // Giảm kích thước font chữ

            panel.Controls.Add(titleLabel);

            // Tạo nhãn tên tác giả (giảm kích thước hiển thị)
            Label authorLabel = new Label();
            authorLabel.Text = book.Author;
            authorLabel.Location = new Point(10, 325);
            authorLabel.AutoSize = true;
            authorLabel.Font = new Font("Arial", 9); // Giảm kích thước font chữ

            panel.Controls.Add(authorLabel);
            panel.TabIndex = index;
            return panel;
        }
        private async void MainForm_Load(object sender, EventArgs e)
        {
            var books = await _bookService.GetAllBooksAsync();
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight; // Dòng di chuyển từ trái sang phải
            flowLayoutPanel1.WrapContents = false; // Không tự động xuống dòng, sẽ tiếp tục tạo thanh cuộn ngang
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel2.FlowDirection = FlowDirection.LeftToRight; // Dòng di chuyển từ trái sang phải
            flowLayoutPanel2.WrapContents = false; // Không tự động xuống dòng, sẽ tiếp tục tạo thanh cuộn ngang
            flowLayoutPanel2.AutoScroll = true;
            for (int i=0; i<books.Count/2; i++)
            {
                if(CreateBookPanel(books[i], i) != null)
                {
                    flowLayoutPanel1.Controls.Add(CreateBookPanel(books[i], i));
                    flowLayoutPanel2.Controls.Add(CreateBookPanel(books[books.Count / 2 + i], i));
                }
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

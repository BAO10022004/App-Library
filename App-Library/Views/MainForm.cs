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
using static Guna.UI2.Native.WinApi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App_Library.Views
{
    public partial class MainForm : Form
    {
        private readonly MongoDbContext _context;
        private readonly IUserService _userService;
        private readonly IBookService _bookService;
        private readonly IStarsRatingService _starsRating;
        private bool isDragging = false;
        private Point dragStartPoint;
        private Control draggedControl;
        public MainForm(MongoDbContext context)
        {
            
            _context = context;
            _userService = new UserService(_context);
            _bookService = new BookService(_context);
            _starsRating = new StarsRatingService(_context);
            InitializeComponent();
            // timer1.Start();
            MessageBox.Show(pnContent.Size.Height + "" + pnContent.Size.Width);
          
      //      //this.Load += UserListForm_Load;
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
        public Panel CreateBookPanel(Book book, int index, int rating)
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
            foreach(Control items in panel.Controls)
            {
                items.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseDown);
                items.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseMove);
                items.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseUp);
            }
            panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseDown);
            panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseMove);
            panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseUp);
            return panel;
        }
        private async void MainForm_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Size = new Size(pnContent.Size.Width, flowLayoutPanel1.Height);
            var books = await _bookService.GetAllBooksAsync();

            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel1.WrapContents = false;
         
       

            await Task.Run(async () =>
            {
                foreach (var book in books)
                {
                    // var start = await _starsRating.GetBookRating(book.Id);
                    var bookPanel = CreateBookPanel(book, books.IndexOf(book), 4);

                    if (bookPanel != null)
                    {
                        flowLayoutPanel1.Invoke(new Action(() => flowLayoutPanel1.Controls.Add(bookPanel)));
                    }
                }
            });
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private Point mouseDownLocation;
        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            mouseDownLocation = e.Location;
        }

        private void flowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Tính toán thay đổi vị trí chuột khi kéo
                int dx = mouseDownLocation.X - e.X;
                int dy = mouseDownLocation.Y - e.Y;

                // Thay đổi vị trí cuộn của panel theo sự thay đổi của vị trí chuột
                flowLayoutPanel1.AutoScrollPosition = new Point(
                    flowLayoutPanel1.HorizontalScroll.Value + dx,
                    flowLayoutPanel1.VerticalScroll.Value + dy
                );
            }
        }

        private void flowLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        private void AutoScrollIfNeeded(MouseEventArgs e)
        {
            int scrollMargin = 20; // Khu vực gần rìa panel để bắt đầu autoscroll

            // Scroll lên trên
            if (e.Y < scrollMargin && panel1.VerticalScroll.Value > 0)
            {
                panel1.VerticalScroll.Value -= 5;
                panel1.PerformLayout();
            }

            // Scroll xuống dưới
            if (e.Y > panel1.Height - scrollMargin && panel1.VerticalScroll.Value < panel1.VerticalScroll.Maximum)
            {
                panel1.VerticalScroll.Value += 5;
                panel1.PerformLayout();
            }

            // Scroll sang trái
            if (e.X < scrollMargin && panel1.HorizontalScroll.Value > 0)
            {
                panel1.HorizontalScroll.Value -= 5;
                panel1.PerformLayout();
            }

            // Scroll sang phải
            if (e.X > panel1.Width - scrollMargin && panel1.HorizontalScroll.Value < panel1.HorizontalScroll.Maximum)
            {
                panel1.HorizontalScroll.Value += 5;
                panel1.PerformLayout();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            // Thay đổi vị trí cuộn của panel theo sự thay đổi của vị trí chuột
            flowLayoutPanel1.AutoScrollPosition = new Point(
                flowLayoutPanel1.HorizontalScroll.Value + 500,
                flowLayoutPanel1.VerticalScroll.Value + 500
            );
        }
        Form ActForm;
        public void activeFormChild(Form form, object obj)
        {
            if (ActForm != null)
            {
                ActForm.Close();
            }
            ActForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.pnContent.Controls.Add(form);
            this.pnContent.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
           
        }

        private void pn1_Click(object sender, EventArgs e)
        {
            activeFormChild(new Form1(_context), e);
        }

        private void pn2_Click(object sender, EventArgs e)
        {

        }

        private void pn3_Click(object sender, EventArgs e)
        {

        }

        private void pn4_Click(object sender, EventArgs e)
        {

        }

        private void pn5_Click(object sender, EventArgs e)
        {
        }
    }
}

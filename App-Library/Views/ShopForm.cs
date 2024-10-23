using App_Library.Services.Interfaces;
using App_Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_Library.Models;
using DnsClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App_Library.Views
{
    public partial class ShopForm : Form
    {
        private readonly MongoDbContext _context;
        private readonly IAuthService _authService;
        private readonly IUserService _userService;
        private readonly IBookService _bookService;
        List<Book> books;    
        public ShopForm(MongoDbContext context)
        {
            _context = context;
            _userService = new UserService(_context);
            _bookService = new BookService(_context);
            books = new List<Book>();
            InitializeComponent();
            flowLayoutPanel1.AutoScroll = true;
        }

        private async void HomeForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            flowLayoutPanel1.Size = new Size((new MainForm(_context).Size.Width), flowLayoutPanel1.Height);
            books = (await _bookService.GetAllBooksAsync()).ToList();
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel1.WrapContents = false;
            pbLoadDB.Maximum= books.Count-1;
            bgwLoadData.RunWorkerAsync();
        }

        private Control CreateBookPanel(Book book, int index , int rating)
        {
            Panel panel = new Panel();
            panel.Size = new Size((new MainForm(_context).Size.Width), flowLayoutPanel1.Height); // Kích thước giữ nguyên
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
            foreach (Control items in panel.Controls)
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

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
        }

        private Point mouseDownLocation;
        private bool isDragging = false;
        private Point dragStartPoint;
        private Control draggedControl;
        private void flowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Tính toán thay đổi vị trí chuột khi kéo
                int dx = mouseDownLocation.X - e.X;
                int dy = mouseDownLocation.Y - e.Y;

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            flowLayoutPanel1.AutoScrollPosition = new Point(
                flowLayoutPanel1.HorizontalScroll.Value + flowLayoutPanel1.Size.Width,
                flowLayoutPanel1.VerticalScroll.Value 
            );
        }

        private  void BgwLoadDB_DoWorkAsync(object sender, DoWorkEventArgs e)
        {
            
            //var listBook = books.OrderBy(o => o.PublishedYear).ToList();

            for (int i = 0; i < books.Count; i++)
            {
                var bookPanel = CreateBookPanel(books[i], i, 4);
                if (bookPanel != null)
                {
                    bgwLoadData.ReportProgress(0, bookPanel);
                }
            }
        }

        private void bgwLoadDB_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbLoadDB.Value = pbLoadDB.Value+1;
            var bookPanel = e.UserState as Control;
                flowLayoutPanel1.Controls.Add(bookPanel);
            
        }

        private void bgwLoadDB_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Công việc đã bị hủy.");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Có lỗi xảy ra: " + e.Error.Message);
            }
            else
            {
                //pbLoadDB.Value = pbLoadDB.Maximum;
            }
            this.Controls.Remove(pbLoadDB);
        }

    }
}

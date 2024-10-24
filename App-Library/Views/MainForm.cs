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
        private async void MainForm_Load(object sender, EventArgs e)
        {
            lbName.Text = SessionManager.CurrentUsername;

            foreach (Control item in pnListsButton.Controls)
            {
                item.MouseLeave += new System.EventHandler(this.lbShop_MouseLeave);
                item.MouseHover += new System.EventHandler(this.lbShop_MouseHover);
            }
            activeFormChild(new HomeForm(_context), e);
        }

        private Point mouseDownLocation;
        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            mouseDownLocation = e.Location;
        }

        private void flowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void flowLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
      
        private void timer1_Tick(object sender, EventArgs e)
        {
            
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

       

      

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbShop_MouseHover(object sender, EventArgs e)
        {
            var _lbShop = (Label)sender;
            _lbShop.BackColor = Color.MidnightBlue;
            _lbShop.ForeColor = Color.White;
        }

        private void lbShop_MouseLeave(object sender, EventArgs e)
        {
            var _lbShop = (Label)sender;
            _lbShop.BackColor = Color.DeepSkyBlue;
            _lbShop.ForeColor = Color.Black;
        }

        private void lbHome_Click(object sender, EventArgs e)
        {
            activeFormChild(new HomeForm(_context), e);
        }

     
        private void lbName_Click(object sender, EventArgs e)
        {

        }

        private void lbShop_Click(object sender, EventArgs e)
        {
            activeFormChild(new ShopForm(_context), e);
        }

      
        private void txbSearch_Click(object sender, EventArgs e)
        {
            txbSearch.Enabled = true;
        }

        private void pnSearchMain_Click(object sender, EventArgs e)
        {
            txbSearch.Enabled = true;
        }
    }
}

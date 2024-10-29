using App_Library.Models;
using App_Library.Services;
using App_Library.Services.Interfaces;
using App_Library.Views.ToolerForm;
using MongoDB.Driver;
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
using static Guna.UI2.Native.WinApi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App_Library.Views
{
    public partial class MainForm : FormHelper
    {
        private readonly MongoDbContext _context;
        private readonly IUserService _userService;
        private readonly IBookService _bookService;
        private readonly IStarsRatingService _starsRating;
        private bool isDragging = false;
        private Point dragStartPoint;
        private Control draggedControl;
        private HomeForm homeForm;
        private ShopForm shopForm;
        // compunent shop 
        List<Panel> listBookAd;
        List<Book> books;
        Dictionary<Control, Form> formDictionary;
        Form currentForm;
        public MainForm(MongoDbContext context)
        {
            
            _context = context;
            _userService = new UserService(_context);
            _bookService = new BookService(_context);
            _starsRating = new StarsRatingService(_context);
            books = new List<Book>();
            listBookAd = new List<Panel>();
            InitializeComponent();
            
        }
        
        
        public Panel CreateBookPanel(Book book, int index, int rating)
        {
            // Tạo panel mới với kích thước cố định
            Panel panel = new Panel();
            panel.Size = new Size(1259, 350); // Kích thước giữ nguyên
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
                    items.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseUp);   
            }
            panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseDown);
            panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseUp);
            return panel;
        }
        private async void MainForm_Load(object sender, EventArgs e)
        {
            lbName.Text = SessionManager.CurrentUsername;
            homeForm = new HomeForm(_context);
            shopForm = new ShopForm(_context, listBookAd, books);
            books = (await _bookService.GetAllBooksAsync()).ToList();
           
            //this.picHome.Image = global::App_Library.Properties.Resources.HomeNomal;
            pbLoadBook.Start();
            bgwLoadBook.RunWorkerAsync();
            
           
        }
        private void lbShop_MouseHover(object sender, EventArgs e)
        {
            var _lbShop = (Control)sender;
            _lbShop.BackColor = Color.MidnightBlue;
            _lbShop.ForeColor = Color.Red;
            var panel = FindControlContainer(pnListsButton.Controls, _lbShop);
            panel.BackColor = Color.MidnightBlue;
            panel.ForeColor = Color.Red;
            foreach (var item in panel.Controls)
            {
                if (item is PictureBox)
                {
                    var pictureBox = (PictureBox)item;

                    pictureBox.Image = GetImageFromResources(_lbShop.Name.Substring(2) + "Hover");
                    //MessageBox.Show(_lbShop.Name.Substring(2) + "Hover");
                    pictureBox.BackColor = panel.BackColor;
                }
            }
        }

        private void lbShop_MouseLeave(object sender, EventArgs e)
        {
            var _lbShop = (Control)sender;
            _lbShop.BackColor = Color.DeepSkyBlue;
            _lbShop.ForeColor = Color.Black;
            var panel = FindControlContainer(pnListsButton.Controls, _lbShop);
            panel.BackColor = Color.DeepSkyBlue;
            panel.ForeColor = Color.Black;
            foreach (var item in panel.Controls)
            {
                if (item is PictureBox)
                {
                    var pictureBox = (PictureBox)item;

                    pictureBox.Image = GetImageFromResources(_lbShop.Name.Substring(2) + "Origin1");
                    pictureBox.BackColor = panel.BackColor;
                }
            }
        }
        private void BgwLoadDB_DoWorkAsync(object sender, DoWorkEventArgs e)
        {

            //var listBook = books.OrderBy(o => o.PublishedYear).ToList();
           
            for (int i = 0; i < books.Count; i++)
            {
                var bookPanel = CreateBookPanel(books[i], i, 4);
                if (bookPanel != null)
                {
                    bgwLoadBook.ReportProgress(0, bookPanel);
                }
            }
        }

        private void bgwLoadDB_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
            var bookPanel = e.UserState as Control;
            listBookAd.Add((Panel)bookPanel);
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
                pbLoadBook.Stop();
                MessageBox.Show(listBookAd.Count + "");
                formDictionary = new Dictionary<Control, Form>();

                foreach (Control item in pnListsButton.Controls)
                {
                    if (item is Panel)
                    {
                        var controls = item.Controls;
                        foreach (Control control in controls)
                        {
                            control.MouseLeave += new System.EventHandler(this.lbShop_MouseLeave);
                            control.MouseHover += new System.EventHandler(this.lbShop_MouseHover);  
                        }
                    }
                }
                activeFormChild(pnContent, homeForm, e);
                currentForm = homeForm;
            }
        }
        private Point mouseDownLocation;
        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            mouseDownLocation = e.Location;
        }
        
        private void flowLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        private void txbSearch_Click(object sender, EventArgs e)
        {
            txbSearch.Enabled = true;
        }

        private void pnSearchMain_Click(object sender, EventArgs e)
        {
            txbSearch.Enabled = true;
        }
        Point pointSave;
        private void lbHome_Click(object sender, EventArgs e)
        {

            pointSave =picHome.Location;
            lbHome.Text = "";
            timerPicHome.Start();
        }
       
        private void lbShop_Click(object sender, EventArgs e)
        {
            pointSave = picHome.Location;
            lbShop.Text = "";
            timerPicShop.Start();
        }
        int deltaX = 5;
        
        private void timerPicHome_Tick(object sender, EventArgs e)
        {
            
            if (picHome.Location.X < lbHome.Location.X)
            {
                picHome.Location= new Point(picHome.Location.X +deltaX,picHome.Location.Y );
            }
            else
            {
                timerPicHome.Stop();
                picHome.Location = pointSave;
                lbHome.Text = lbHome.Name.Substring(2);
                
                if(!(currentForm is HomeForm))
                {
                    homeForm = new HomeForm(_context);
                    activeFormChild(pnContent, homeForm, e);
                    currentForm = homeForm;
                }
                
            }

        }

        private void timerPicShop_Tick(object sender, EventArgs e)
        {
            if (picShop.Location.X < lbShop.Location.X)
            {
                picShop.Location = new Point(picShop.Location.X + deltaX, picShop.Location.Y);
            }
            else
            {
                timerPicShop.Stop();
                picShop.Location = pointSave;
                lbShop.Text = lbShop.Name.Substring(2);
                
                if(!(currentForm is ShopForm))
                {
                    shopForm = new ShopForm(_context, listBookAd, books);
                    activeFormChild(pnContent, shopForm, e);
                    currentForm = shopForm;
                }
            }
        }
        public Form getCurrentForm() => currentForm;
    }
}

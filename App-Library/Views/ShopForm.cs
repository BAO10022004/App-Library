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
using SharpCompress.Compressors.PPMd;
using App_Library.Views.ToolerForm;

namespace App_Library.Views
{
    public partial class ShopForm : FormHelper
    {
        private readonly MongoDbContext _context;
        private readonly IAuthService _authService;
        private readonly IUserService _userService;
        private readonly IBookService _bookService;
        
        public const int WITH = 450;
        public const int HEIGHT =831;
        List<Panel> listBookAd;
        List<Book> books;
        int indexCurrentBookAd =0;
        bool revier = false;
        public ShopForm(MongoDbContext context, List<Panel> _listBookAd, List<Book> _books)
        {
            _context = context;
            _userService = new UserService(_context);
            _bookService = new BookService(_context);
           
            books = _books;
            listBookAd = new List<Panel>();
            listBookAd = _listBookAd;
            InitializeComponent();
            flowLayoutPanel1.AutoScroll = true;
        }

        private async void HomeForm_Load(object sender, EventArgs e)
        {
            
            flowLayoutPanel1.Size = new Size((new MainForm(_context).Size.Width), flowLayoutPanel1.Height);
           
            //flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel1.WrapContents = false;
            timer1.Start();
            flowLayoutPanel1.Controls.Add(listBookAd[indexCurrentBookAd]);

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
                indexCurrentBookAd++;
                if (indexCurrentBookAd != listBookAd.Count)
                {                
                    flowLayoutPanel1.Controls.Remove(listBookAd[indexCurrentBookAd - 1]);
                    flowLayoutPanel1.Controls.Add(listBookAd[indexCurrentBookAd]);
                }
                else
                {
                    flowLayoutPanel1.Controls.Remove(listBookAd[indexCurrentBookAd - 1]);
                    indexCurrentBookAd = 0;
                    flowLayoutPanel1.Controls.Add(listBookAd[indexCurrentBookAd]);
            }

                  
        }

        private void book_Click(object sender, EventArgs e)
        {
            pnShopMain.Size = new Size(this.Size.Width-WITH, this.Size.Height);
            pnProperties.Size = new Size (WITH, this.Height);
            //pnProperties.BackColor = Color.Black;
            pnProperties.Location = new Point (this.Size.Width + 300 - pnShopMain.Width, 0);
            //MessageBox.Show(pnProperties.Size.Width + " " + pnProperties.Size.Height + "\n" + pnProperties.Location.X + " " + pnProperties.Location.Y);
            activeFormChild(pnProperties, new PropertiesBookForm(), e);
        }

        private void pnShopMain_Click(object sender, EventArgs e)
        {
            pnShopMain.Size = new Size(this.Size.Width, this.Size.Height);
            pnProperties.Size = new Size(0, 1);
            ////pnProperties.BackColor = Color.Black;
            //pnProperties.Location = new Point(this.Size.Width + 300 - pnShopMain.Width, 0);
            ////MessageBox.Show(pnProperties.Size.Width + " " + pnProperties.Size.Height + "\n" + pnProperties.Location.X + " " + pnProperties.Location.Y);
            //activeFormChild(new PropertiesBookForm(), e);
        }
    }
}

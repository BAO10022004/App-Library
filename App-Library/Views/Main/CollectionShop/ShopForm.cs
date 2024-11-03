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
using MongoDB.Driver;
using Guna.UI2.WinForms;
using System.Net.Http;
using System.Runtime.InteropServices;
using App_Library.Views.Main.CollectionShop;
using App_Library.Services;


namespace App_Library.Views
{
    public partial class ShopForm : FormHelper
    {
        private readonly AuthService _authService;
        private readonly UserService _userService;
        private readonly BookService _bookService;
        Guna2ProgressIndicator guna2ProgressIndicator;
        public const int WITH = 450;
        public const int HEIGHT = 831;
        List<System.Windows.Forms.Panel> listBookAd;
        List<Panel> listPanelAllBook;
        List<Book> books;
        int indexCurrentBookAd = 0;
        Dictionary<Control, Book> getBookFromPanelAd;
        Dictionary<Control, Book> getBookFromPanelHotDeal;
        bool revier = false;
        public ShopForm(List<Panel> panels = null)
        {
            if (panels != null)
            {
                listBookAd = panels.ToList();
            }
            _userService = new UserService();
            _bookService = new BookService();
            InitializeComponent();
            gnpGroupBookForCategory.BackColor = Color.FromArgb(50, Color.Gray);
            flowLayoutPanel1.AutoScroll = false;
            this.AutoScroll = true;
            this.DoubleBuffered = true;

            // Thiết lập các thuộc tính để cải thiện hiệu suất
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);

        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            if (Parent != null)
            {
                var parentGraphics = Parent.CreateGraphics();
                var parentBrush = new SolidBrush(Parent.BackColor);
                e.Graphics.FillRectangle(parentBrush, this.Bounds);
                parentGraphics.Dispose();
            }
        }
        private async void HomeForm_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if ((control.Visible == true) && !(control.Name.Equals("pbLoadData")))
                {
                    control.Visible = false;
                }
                guna2ProgressIndicator = new Guna2ProgressIndicator();
                guna2ProgressIndicator.Start();
                guna2ProgressIndicator.ProgressColor = Color.Navy;
                guna2ProgressIndicator.Location = new Point(this.Size.Width / 2, this.Size.Height / 2);
                this.Controls.Add(guna2ProgressIndicator);
            }
            books = await _bookService.GetBooksAsync();
            //flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel1.WrapContents = false;
            listBookAd = new List<Panel>();
            getBookFromPanelAd = new Dictionary<Control, Book>();
            getBookFromPanelHotDeal = new Dictionary<Control, Book>();
            pnShopMain.BackColor = Color.Transparent;
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel2.BackColor = Color.Transparent;
            gnpContainCaterogyBook.BackColor = Color.Transparent;
            pnContainHotDeal.BackColor = Color.Transparent;
            setEventButtonGuna(gnpContainCaterogyBook.Controls);

            BWLoadData.RunWorkerAsync();

        }
        public Panel CreateBookAdPanel(Book book, int index, int rank = 4)
        {
            // Tạo Panel với kích thước cố định 1259 x 335
            Panel panel = new Panel();
            panel.Size = new Size(1037, 294);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.BackColor = Color.FromArgb(245, 245, 245); // Màu nền nhẹ nhàng

            // Thêm PictureBox để hiển thị hình ảnh của cuốn sách
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(300, 335); // Kích thước cố định cho hình ảnh
            pictureBox.Location = new Point(10, 0); // Đặt ở góc trái của Panel
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Hiển thị ảnh đúng tỷ lệ mà không bị méo

            // Tải hình ảnh từ URL
            try
            {
                pictureBox.Load(book.Image); // Đường dẫn hoặc URL của ảnh
            }
            catch (Exception)
            {
                // Nếu có lỗi khi tải ảnh, có thể đặt ảnh mặc định hoặc để trống
                return null; // Ảnh trống kích thước 300x335
            }
            panel.Controls.Add(pictureBox);

            // Tạo phần chứa thông tin sách bên phải ảnh
            int infoStartX = 330; // Bắt đầu phần thông tin sau hình ảnh (300 + 30 khoảng trống)

            // Thêm tiêu đề sách với kích thước lớn hơn và màu sắc nổi bật
            Label titleLabel = new Label();
            titleLabel.Text = book.Title;
            titleLabel.Location = new Point(infoStartX, 20);
            titleLabel.AutoSize = false;
            titleLabel.Size = new Size(900, 50); // Đặt kích thước cố định để kiểm soát dòng chữ
            titleLabel.Font = new Font("Arial", 18, FontStyle.Bold); // Tăng kích thước font
            titleLabel.ForeColor = Color.FromArgb(34, 34, 34);
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            panel.Controls.Add(titleLabel);

            // Thêm tên tác giả với màu xám nhẹ
            Label authorLabel = new Label();
            authorLabel.Text = $"Author: {book.Author}";
            authorLabel.Location = new Point(infoStartX, 80);
            authorLabel.AutoSize = false;
            authorLabel.Size = new Size(900, 30);
            authorLabel.Font = new Font("Arial", 14, FontStyle.Italic); // Tăng kích thước font
            authorLabel.ForeColor = Color.FromArgb(100, 100, 100);
            authorLabel.TextAlign = ContentAlignment.MiddleLeft;
            panel.Controls.Add(authorLabel);

            // Thêm nhãn giá với màu sắc nổi bật và kích thước chữ lớn hơn
            Label priceLabel = new Label();
            priceLabel.Text = $"Price: ${book.Price}";
            priceLabel.Location = new Point(infoStartX, 120);
            priceLabel.AutoSize = false;
            priceLabel.Size = new Size(900, 35);
            priceLabel.Font = new Font("Arial", 16, FontStyle.Bold); // Tăng kích thước font
            priceLabel.ForeColor = Color.FromArgb(0, 153, 51); // Màu xanh lá nổi bật
            priceLabel.TextAlign = ContentAlignment.MiddleLeft;
            panel.Controls.Add(priceLabel);

            // Thêm nhãn xếp hạng (rank) với biểu tượng sao màu cam
            Label rankLabel = new Label();
            rankLabel.Text = $"Rank: {rank} ★";
            rankLabel.Location = new Point(infoStartX, 160);
            rankLabel.AutoSize = false;
            rankLabel.Size = new Size(900, 35);
            rankLabel.Font = new Font("Arial", 16, FontStyle.Bold); // Tăng kích thước font
            rankLabel.ForeColor = Color.FromArgb(255, 140, 0); // Màu cam cho xếp hạng
            rankLabel.TextAlign = ContentAlignment.MiddleLeft;
            panel.Controls.Add(rankLabel);

            // Thêm mô tả ngắn về sách (nếu có) để lấp đầy khoảng trống
            Label descriptionLabel = new Label();
            descriptionLabel.Text = book.Content.Length > 100 ? book.Content.Substring(0, 100) + "..." : book.Content;
            descriptionLabel.Location = new Point(infoStartX, 210);
            descriptionLabel.AutoSize = false;
            descriptionLabel.Size = new Size(900, 100); // Kích thước lớn hơn để hiển thị nội dung dài
            descriptionLabel.Font = new Font("Arial", 12, FontStyle.Regular);
            descriptionLabel.ForeColor = Color.FromArgb(34, 34, 34);
            descriptionLabel.TextAlign = ContentAlignment.TopLeft;
            descriptionLabel.MaximumSize = new Size(900, 100); // Giới hạn chiều cao mô tả
            panel.Controls.Add(descriptionLabel);
            panel.Cursor = System.Windows.Forms.Cursors.Hand;
            foreach (Control items in panel.Controls)
            {

                items.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseDown);
                items.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseMove);
                items.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseUp);
                items.Click += new EventHandler(this.book_Click);
            }
            panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseDown);
            panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseMove);
            panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseUp);
            panel.Name = book.Username;
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
            if (timerAd.Interval == 1) timerAd.Interval = 10000;

            indexCurrentBookAd++;
            if (indexCurrentBookAd < listBookAd.Count)
            {
                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel1.Controls.Add(listBookAd[indexCurrentBookAd]);
            }
            else
            {
                flowLayoutPanel1.Controls.Remove(listBookAd[indexCurrentBookAd - 1]);
                indexCurrentBookAd = 0;
                timer1_Tick(sender, e);
            }
        }
        public async Task<Panel> CreateBookPanelAsync(Book book, int index, int rating = 4)
        {
            // Tạo panel mới với kích thước cố định
            Guna2Panel panel = new Guna2Panel();
            panel.Size = new Size(200, 350); // Kích thước giữ nguyên

            panel.BackColor = Color.FromArgb(240, 240, 255); // Màu nền tương tự hình

            // Thêm hình ảnh sách (tăng kích thước)
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(180, 270); // Tăng kích thước ảnh lớn hơn
            pictureBox.Location = new Point(10, 10);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Name = "pictureBox" + index;
            // Load hình ảnh từ URL không đồng bộ
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var imageBytes = await client.GetByteArrayAsync(book.Image);
                    using (var ms = new System.IO.MemoryStream(imageBytes))
                    {
                        pictureBox.Image = Image.FromStream(ms);
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
            titleLabel.Text = book.Title;
            titleLabel.Location = new Point(10, 305); // Giảm kích thước hiển thị của nhãn sách
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Arial", 10, FontStyle.Bold); // Giảm kích thước font chữ
            titleLabel.Name = "titleLabel" + index;
            panel.Controls.Add(titleLabel);

            // Tạo nhãn tên tác giả (giảm kích thước hiển thị)
            Label authorLabel = new Label();
            authorLabel.Text = book.Author;
            authorLabel.Location = new Point(10, 325);
            authorLabel.AutoSize = true;
            authorLabel.Font = new Font("Arial", 9); // Giảm kích thước font chữ
            authorLabel.Name = "authorLabel" + index;
            panel.Controls.Add(authorLabel);
            panel.Margin = new Padding(5);
            panel.Name = "itemHotDeal" + index;
            panel.TabIndex = index;

            foreach (Control control in panel.Controls)
            {

                control.MouseHover += new EventHandler(this.LPHotDeal_MouseHover);
                control.MouseLeave += new EventHandler(this.LPHotDeal_MouseLeave);
                control.Click += new EventHandler(this.bookHotDeal_Click);
            }
            panel.BackColor = Color.White;
            panel.MouseHover += new EventHandler(this.LPHotDeal_MouseHover);
            panel.MouseLeave += new EventHandler(this.LPHotDeal_MouseLeave);
            panel.Click += new EventHandler(this.bookHotDeal_Click);
            return panel;
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void book_Click(object sender, EventArgs e)
        {
            pnShopMain.Size = new Size(this.Size.Width - WITH, this.Size.Height);
            pnProperties.Size = new Size(WITH, this.Height);
            //pnProperties.BackColor = Color.Black;
            pnProperties.Location = new Point(this.Size.Width + 300 - pnShopMain.Width, 0);
            //MessageBox.Show(pnProperties.Size.Width + " " + pnProperties.Size.Height + "\n" + pnProperties.Location.X + " " + pnProperties.Location.Y);

            activeFormChild(pnProperties, new PropertiesBookForm(getBookFromPanelAd[FindControlContainer(flowLayoutPanel1.Controls, sender as Control)]), e);
            foreach (Panel pn in guna2Panel2.Controls)
            {
                pn.BackColor = Color.Transparent;
            }
            pnContainHotDeal.BackColor = Color.Transparent;
            pnHotDeal.BackColor = Color.Transparent;
        }
        async Task<Book> getBookFromPanelHotDealAsync(Panel panel1)
        {
            var ListBookForThisF = await _bookService.GetBooksAsync();
            ListBookForThisF.OrderBy(book => book.Price);

            String titlePanel = null;
            foreach (var item2 in panel1.Controls)
            {
                if (item2 is Label && (item2 as Label).Location == new Point(10, 305))
                {
                    titlePanel = (item2 as Label).Text;
                }
            }
            return ListBookForThisF.Where(book => book.Title.Equals(titlePanel)).FirstOrDefault();

        }
        private async void bookHotDeal_Click(object sender, EventArgs e)
        {
            pnShopMain.Width = this.Width - WITH;
            pnProperties.Size = new Size(WITH, this.Height);
            //pnProperties.BackColor = Color.Black;
            pnProperties.Location = new Point(this.Size.Width + 300 - pnShopMain.Width, 0);
            //MessageBox.Show(pnProperties.Size.Width + " " + pnProperties.Size.Height + "\n" + pnProperties.Location.X + " " + pnProperties.Location.Y);
            if (sender is Panel)
            {
                activeFormChild(pnProperties, new PropertiesBookForm(await getBookFromPanelHotDealAsync(sender as Panel)), e);
            }
            else
            {
                activeFormChild(pnProperties, new PropertiesBookForm(await getBookFromPanelHotDealAsync(FindControlContainer(LPHotDeal.Controls, sender as Control) as Panel)), e);
            }

            foreach (Panel pn in guna2Panel2.Controls)
            {
                pn.BackColor = Color.Transparent;
            }
            pnContainHotDeal.BackColor = Color.Transparent;
            pnHotDeal.BackColor = Color.Transparent;
            pnShopMain.Width = this.Width;
        }
        private void pnShopMain_Click(object sender, EventArgs e)
        {
            //pnShopMain.Width = this.Width;
            pnProperties.Size = new Size(0, 1);
            ////pnProperties.BackColor = Color.Black;
            //pnProperties.Location = new Point(this.Size.Width + 300 - pnShopMain.Width, 0);
            ////MessageBox.Show(pnProperties.Size.Width + " " + pnProperties.Size.Height + "\n" + pnProperties.Location.X + " " + pnProperties.Location.Y);
            //activeFormChild(new PropertiesBookForm(), e);
        }

        private void BWLoadData_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                var bookPanel = CreateBookAdPanel(books[i], i, 4);
                if (bookPanel != null)
                {
                    getBookFromPanelAd[bookPanel] = books[i];

                    BWLoadData.ReportProgress(0, bookPanel);
                }
            }
        }

        private void BWLoadData_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var bookPanel = e.UserState as Panel;
            listBookAd.Add(bookPanel);
        }

        private async void BWLoadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
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
                flowLayoutPanel1.Visible = true;
                foreach (Control control in this.Controls)
                {
                    control.Visible = true;
                }
                LPHotDeal.AutoScroll = true;
                LPHotDeal.AutoScrollMinSize = new Size(gnpContainFpHotDeal.Width * 2, 0);
                LPHotDeal.HorizontalScroll.Enabled = true;
                LPHotDeal.HorizontalScroll.Visible = true;
                LPHotDeal.VerticalScroll.Enabled = false;
                LPHotDeal.VerticalScroll.Visible = false;
                // Ẩn thanh cuộn
                HideVerticalScrollBar(LPHotDeal.Handle);
                guna2ProgressIndicator.Start();
                guna2ProgressIndicator.Visible = false;
                this.Controls.Remove(guna2ProgressIndicator);
                //activeFormChild(pnContainHotDeal, new PanelListBookHotSale(await _bookService.GetAllBooksAsync()), e);

                var listBooks = await _bookService.GetBooksAsync();
                listBooks.OrderBy(book => book.Price);
                int sizeBookHotDeal = 13;
                var tasks = new List<Task<Panel>>();
                var tasksThisform = new List<Task<Panel>>();

                // Thêm hoặc cập nhật các control tại đây
                for (int i = 0; i < sizeBookHotDeal; i++)
                {
                    tasks.Add(CreateBookPanelAsync(listBooks[i], i, 4));
                    tasksThisform.Add(CreateBookPanelAsync(listBooks[i], i, 4));
                }
                listPanelAllBook = new List<Panel>();
                var panels = await Task.WhenAll(tasks);
                listPanelAllBook = (await Task.WhenAll(tasksThisform)).ToList();
                foreach (var panel in panels)
                {
                    if (panel != null)
                    {
                        getBookFromPanelHotDeal[panel] = listBooks[Array.IndexOf(panels, panel)];
                        LPHotDeal.Controls.Add(panel);
                    }
                }
                LPHotDeal.ResumeLayout();
                pnContainHotDeal.BackColor = Color.Transparent;
                foreach (Panel pn in pnShopMain.Controls)
                {
                    pn.BackColor = Color.Transparent;
                }
                int wightHotDeal = 0;
                foreach (Control pn in LPHotDeal.Controls)
                {
                    wightHotDeal += (pn.Width + pn.Margin.Right);
                }
                if (wightHotDeal > gnpContainFpHotDeal.Width)
                {
                    wightHotDeal = gnpContainFpHotDeal.Width;
                }
                // LPHotDeal.Size = new Size(wightHotDeal,400);
                gnpContainFpHotDeal.Size = new Size(wightHotDeal, 370);
                timerAd.Start();

            }
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int ShowScrollBar(IntPtr hWnd, int wBar, int bShow);

        private void HideVerticalScrollBar(IntPtr handle)
        {
            ShowScrollBar(handle, (int)ScrollBarDirection.SB_VERT, 0);
        }

        // Enum để định nghĩa hướng thanh cuộn
        private enum ScrollBarDirection
        {
            SB_HORZ = 0,
            SB_VERT = 1,
            SB_BOTH = 3
        }
        private void timerAd2_Tick(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                panel = control as Panel;
            }
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(listBookAd[listBookAd.IndexOf(panel) + 1]);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            // Đảm bảo chỉ vẽ lại các vùng cần thiết
            base.OnPaint(e);
        }
        private void pnShopMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbLoadData_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);
            g.DrawLine(pen, 10, 50, 380, 50);
            pen.Dispose();

        }

        private void flowLayoutPanel1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void LPHotDeal_MouseHover(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control is Panel)
            {
                foreach (var c in control.Controls)

                {
                    control.BackColor = Color.DeepSkyBlue;

                }
                control.Size = new Size(200, 350);
            }
            else
            {
                var panel = FindControlContainer(LPHotDeal.Controls, control);
                panel.BackColor = Color.DeepSkyBlue;
            }
        }
        private void LPHotDeal_MouseLeave(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control is Panel)
            {
                foreach (var c in control.Controls)

                {
                    control.BackColor = Color.White;

                }
                control.Size = new Size(200, 350);
            }
            else
            {
                var panel = FindControlContainer(LPHotDeal.Controls, control);
                panel.BackColor = Color.White;
            }
        }

        private void gnpContainCaterogyBook_MouseHover(object sender, EventArgs e)
        {

        }

        void setEventButtonGuna(Control.ControlCollection listButtonGuna)
        {
            foreach (Control control in listButtonGuna)
            {
                if (control is Guna2Panel)
                {
                    Guna2Panel ControlPanel = (Guna2Panel)control;
                    ControlPanel.MouseLeave += new System.EventHandler(this.gnpButtonAll_MouseLeave);
                    ControlPanel.MouseHover += new System.EventHandler(this.gnpButtonAll_MouseHover);
                    foreach (Control control2 in ControlPanel.Controls)
                    {
                        control2.MouseLeave += new System.EventHandler(this.gnpButtonAll_MouseLeave);
                        control2.MouseHover += new System.EventHandler(this.gnpButtonAll_MouseHover);
                    }
                }

            }
        }

        private void gnpButtonAll_MouseHover(object sender, EventArgs e)
        {
            if (sender is Guna2Panel)
            {
                Guna2Panel guna2Panel = (Guna2Panel)sender;
                guna2Panel.ForeColor = Color.Aqua;
                guna2Panel.BorderColor = Color.Aqua;
            }
            else
            {
                Guna2Panel guna2Panel = FindControlContainer(gnpGroupButtonCategory.Controls, sender as Label) as Guna2Panel;
                guna2Panel.ForeColor = Color.Aqua;

                guna2Panel.BorderColor = Color.Aqua;
            }
        }
        private void gnpButtonAll_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Guna2Panel)
            {
                Guna2Panel guna2Panel = (Guna2Panel)sender;
                guna2Panel.ForeColor = Color.Black;
                guna2Panel.BorderColor = Color.Black;
            }
            else
            {
                Guna2Panel guna2Panel = FindControlContainer(gnpGroupButtonCategory.Controls, sender as Label) as Guna2Panel;
                guna2Panel.ForeColor = Color.Black;
                guna2Panel.BorderColor = Color.Black;
            }
        }

        private void gnpButtonAll_Click(object sender, EventArgs e)
        {
            //activeFormChild(gnpGroupBookForCategory, new AllBookForm(listPanelAllBook, this), e);

            gnpGroupBookForCategory.BackColor = Color.Transparent;
        }

        private void pnProperties_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LPHotDeal_Paint(object sender, PaintEventArgs e)
        {

        }



        private void pnHotDeal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gnpGroupButtonCategory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gnpGroupBookForCategory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

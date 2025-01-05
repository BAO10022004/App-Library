using App_Library.Models;
using App_Library.Services;
using App_Library.Views.Main.CollectionShop;
using App_Library.Views.ToolerForm;
using SharpCompress.Compressors.Xz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library.Views.UserView.CollectionShop
{
     

    public partial class AdFormNew : FormHelper
    {
        class BookColor
        {
            private Book data;
            private Color color;
            public BookColor()
            {
                data = new Book();
            }
            public Book Data { get => data; set => data = value; }
            public Color Color { get => color; set => color = value; }
        }
        List<Image> listBook;
        NewShopMain shop;
        Dictionary<Image, BookColor> books;
        // index Book in Ad
        int indexCurrentBookAd = 0;
        private int startWidth = 749;  // Chiều rộng ban đầu
        private int targetWidth = 0;   // Mục tiêu chiều rộng
        private int currentWidth;      // Chiều rộng hiện tại
        private int totalTime = 1000;  // Thời gian hoàn thành (1 giây)
        private int totalTicks = 60;   // Số lần tick (60 FPS x 1 giây = 60 lần)
        private int incrementPerTick;  // Gia tăng chiều rộng mỗi lần tick
        public AdFormNew(NewShopMain formParent)
        {

            InitializeComponent();
            currentWidth = startWidth;
            pnAd.Size = new Size(currentWidth, 450);
            pnSubAd.Size = new Size(0, 450);

            totalTicks = totalTime / 16;  // 16ms mỗi lần tick, khoảng 60 lần cập nhật trong 1 giây
            incrementPerTick = (startWidth - targetWidth) / totalTicks;  // Tính tốc độ thay đổi mỗi lần tick

            timerAnimation.Interval = 16; // 16ms mỗi lần tick
            this.timerAd.Tick += new System.EventHandler(this.timer1_Tick);
            DoubleBuffered(pnAd, true);
            DoubleBuffered(pnSubAd, true);
            this.shop = formParent;
            books = new Dictionary<Image, BookColor>();

        }
        Form form1;
        private void AdForm_Load(object sender, EventArgs e)
        {
            listBook = new List<Image>();
            getAllImage();
            loadAd(0);
            timerAd.Start();
            
        }
        void loadAd(int index)
        {
            timerAd.Interval = 15000;
            activeFormChild(pnAd, new Advertisement(listBook[index], books[listBook[index]].Data, shop, books[listBook[index]].Color), null, ref form1);
            if (indexCurrentBookAd + 1 == listBook.Count)
                    indexCurrentBookAd = 0;


        }
        Form form2;
        private void timer1_Tick(object sender, EventArgs e)
        {
            activeFormChild(pnAd, new Advertisement(listBook[indexCurrentBookAd ], books[listBook[indexCurrentBookAd]].Data, shop, books[listBook[indexCurrentBookAd ]].Color), null, ref form1);
            if (indexCurrentBookAd +1 < listBook.Count)
                activeFormChild(pnSubAd, new Advertisement(listBook[indexCurrentBookAd +1], books[listBook[indexCurrentBookAd + 1]].Data, shop, books[listBook[indexCurrentBookAd + 1]].Color), null, ref form2);
            else
            {
                activeFormChild(pnSubAd, new Advertisement(listBook[0], books[listBook[0]].Data, shop, books[listBook[0]].Color), null, ref form2);
            }
            timerAnimation.Start();
        }
        public async void getAllImage()
        {
            BookService bookService = new BookService();
            var resourceNames = typeof(Properties.Resources)
            .GetProperties(BindingFlags.Static | BindingFlags.NonPublic)
                           .Select(p => p.Name)
                           .Where(name => name.ToLower().Contains("banner")) // Kiểm tra tên có chứa từ "banner"
                           .ToList();
            resourceNames.ForEach(async x =>
            {
                var propertyInfo = typeof(Properties.Resources).GetProperty(x, BindingFlags.Static | BindingFlags.NonPublic);
                if (propertyInfo != null)
                {
                    Image image = propertyInfo.GetValue(null) as Image;
                    listBook.Add(image);
                    books[image] = new BookColor();
                    switch (x)
                    {
                        case "bannerBraveNewWord":
                            {
                                try
                                {

                                    books[image].Data = await bookService.GetBookBySlugAsync("brave-new-world");
                                    books[image].Color = Color.OrangeRed;
                                }
                                catch
                                {
                                    // listBook.Remove(image);
                                }
                                break;
                            }
                        case "bannerElonMusk":
                            {
                                try
                                {
                                    books[image].Data = await bookService.GetBookBySlugAsync("elon-musk");
                                    books[image].Color = Color.Black;

                                }
                                catch
                                {
                                    // listBook.Remove(image);
                                }
                                break;
                            }
                        case "bannerNhagiakim":
                            {
                                try
                                {
                                    books[image].Data = await bookService.GetBookBySlugAsync("nha-gia-kim");
                                    books[image].Color = Color.DarkOrange;

                                }
                                catch
                                {
                                    //listBook.Remove(image);
                                }
                                break;
                            }
                        case "bannerMatBiec":
                            {
                                try
                                {
                                    books[image].Data = await bookService.GetBookBySlugAsync("mat-biec");
                                    books[image].Color = Color.Orange;

                                }
                                catch
                                {
                                    // listBook.Remove(image);
                                }
                                break;
                            }
                        case "bannerConan":
                            {
                                try
                                {
                                    books[image].Data = await bookService.GetBookBySlugAsync("case-closed");
                                    books[image].Color = Color.RoyalBlue;
                                }
                                catch
                                {
                                    //listBook.Remove(image);
                                }
                                break;
                            }
                        case "bannerDoreamon":
                            {
                                try
                                {
                                    books[image].Data = await bookService.GetBookBySlugAsync("doraemon");
                                    books[image].Color = Color.RoyalBlue;

                                }
                                catch
                                {
                                    //listBook.Remove(image);
                                }
                                break;
                            }
                        case "bannerTheGreatGatsby":
                            {
                                try
                                {
                                    books[image].Data = await bookService.GetBookBySlugAsync("the-great-gatsby");
                                    books[image].Color = Color.DarkGray;
                                }
                                catch
                                {
                                    // listBook.Remove(image);
                                }
                                break;
                            }
                    }

                }
            });


        }

        private void picSubAd1_Click(object sender, EventArgs e)
        {
            shop.bookClick(books[listBook[indexCurrentBookAd + 1]].Data);
        }

        private void picSubAd2_Click(object sender, EventArgs e)
        {
            shop.bookClick(books[listBook[indexCurrentBookAd + 2]].Data);

        }

        private void pnSubAd_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            // Tính tiến trình ngược
            double progress = 1.0 - (double)(currentWidth - targetWidth) / (startWidth - targetWidth);

            // Tính toán easing (Ease-Out Quadratic)
            double easedProgress = 1 - Math.Pow(1 - progress, 2); // Gia tốc giảm chậm dần

            // Tính giá trị giảm động, tỉ lệ giảm theo easedProgress
            int decrement = (int)((currentWidth - targetWidth) * easedProgress); // Tính giảm theo gia tốc

            // Đảm bảo giá trị giảm hợp lý không quá nhỏ
            decrement = Math.Max(decrement, 1); // Giảm tối thiểu 1 pixel để tránh không thay đổi

            // Cập nhật chiều rộng
            currentWidth -= decrement;

            // Kiểm tra kết thúc
            if (currentWidth <= targetWidth)
            {
                currentWidth = 749; // Reset chiều rộng
                timerAnimation.Stop();
                pnAd.Size = new Size(749, 450);
                pnSubAd.Size = new Size(0, 450);
                pnSubAd.Controls.Clear();
                loadAd(++indexCurrentBookAd);
            }
            else
            {
                pnAd.SuspendLayout();
                pnSubAd.SuspendLayout();
                // Cập nhật giao diện
                pnAd.Size = new Size(currentWidth, 450);
                pnSubAd.Size = new Size(startWidth - currentWidth, 450);
                pnSubAd.Location = new Point(pnAd.Width + pnAd.Location.X + 5, pnSubAd.Location.Y);
                pnAd.ResumeLayout();
                pnSubAd.ResumeLayout();
            }
        }
        public static void DoubleBuffered(Control control, bool setting)
        {
            var prop = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance);
            prop.SetValue(control, setting, null);
        }
    }
}

using App_Library.Models;
using App_Library.Services;
using App_Library.Views.Main.CollectionShop;
using App_Library.Views.Orthers.CollectionProfile;
using App_Library.Views.ToolerForm;
using App_Library.Views.UserView.CollectionHome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library.Views
{
    public partial class HomeForm : FormHelper
    {
        BookSoldService bookSoldService;
        MainForm main;
        private readonly AuthService _authService;
        public HomeForm(MainForm main)
        {
            this.Size = main.Size;
            InitializeComponent();
            bookSoldService = new BookSoldService();
            this.main = main;

                pnNameForm.Controls.Remove(pnBack);
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void HomeForm_Load(object sender, EventArgs e)
        {
            lbNumberBoughtBook.Text =(await bookSoldService.GetBoughtBooksAsync()).Count.ToString();
            BookService bookService = new BookService();
            List<Book> bookForUser = new List<Book>();
            var result = await bookSoldService.GetBooksInProgressAsync();
            //this.Controls.Remove(pnNameForm);
            lbNumberHistory.Text = result.Count.ToString();
            var lisBookPending = new List<BookSold>();
            foreach (BookSold bookSold in result)
            {
                if(!bookSold.Status.Equals("Approved"))
                {
                    lisBookPending.Add(bookSold);
                }
            }
        }
        private void HomeForm_Resize(object sender, EventArgs e)
        {
            lbNameForm.Location = new Point((pnNameForm.Width - lbNameForm.Width) / 2, (pnNameForm.Height - lbNameForm.Height) / 2);
            pnGroup1.Width = this.Width / 2-10;
            pnGroup.Width = this.Width / 2-10;
            btnBoughtBook.Location =new Point( (pnGroup1.Width - btnBoughtBook.Width) / 2, btnBoughtBook.Location.Y);
            btnSetting.Location = new Point((pnGroup2.Width - btnSetting.Width) / 2, btnSetting.Location.Y);
            pnHistory.Location = new Point((pnGroup2.Width - btnSetting.Width) / 2, pnHistory.Location.Y);
            pnProFile.Location = new Point((pnGroup1.Width - btnBoughtBook.Width) / 2, pnProFile.Location.Y);
        }
        Form actForm;
        private async void label4_Click(object sender, EventArgs e)
        {
            pnNameForm.Controls.Add(pnBack);

            BookService bookService = new BookService();
            List<Book> bookForUser = new List<Book>();
            List<BookSold> bookSolds = new List<BookSold>();
            bookSolds =await bookSoldService.GetBoughtBooksAsync();
            
            foreach(BookSold bookSold in bookSolds)
            {
                Book book = new Book();
                book =await bookService.GetBookBySlugAsync(bookSold.Slug);
                bookForUser.Add(book);
            }
            activeFormChild(pnMain, new BoughtBook(bookForUser), null,ref actForm);
            lbNameForm.Text = "BOUGHT BOOK";
            HomeForm_Resize(sender,e);
        }
        Form actFormFrofile;
        private void lbProfile_Click(object sender, EventArgs e)
        {
            pnNameForm.Controls.Add(pnBack);
            this.Controls.Remove(pnNameForm);
            activeFormChild(pnMain, new ProfileForm(main), null, ref actFormFrofile);
        }

        private async void label2_Click_1(object sender, EventArgs e)
        {
            pnNameForm.Controls.Add(pnBack);
            lbNameForm.Text = "HISTORY";
            BookService bookService = new BookService();
            List<Book> bookForUser = new List<Book>();
            var result =await bookSoldService.GetBooksInProgressAsync();
            activeFormChild(pnMain, new HistoryForm(result), null, ref actFormFrofile);
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            
                main.clickBackHome(sender, e);
        }

        private void lbSetting_MouseHover(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private Image RotateImage(Image img, float angle)
        {
            // Tạo một Bitmap mới từ hình ảnh gốc
            Bitmap rotatedBitmap = new Bitmap(img);

            // Tạo đối tượng Graphics từ Bitmap mới
            Graphics g = Graphics.FromImage(rotatedBitmap);

            // Lấy tọa độ trung tâm của hình ảnh
            PointF center = new PointF(img.Width / 2, img.Height / 2);

            // Di chuyển hệ tọa độ Graphics để gốc nằm ở giữa hình ảnh
            g.TranslateTransform(center.X, center.Y);

            // Xoay hệ tọa độ Graphics
            g.RotateTransform(angle);

            // Di chuyển ngược lại để khôi phục vị trí gốc ban đầu
            g.TranslateTransform(-center.X, -center.Y);

            // Vẽ hình ảnh gốc vào Graphics đã xoay
            g.DrawImage(img, new Point(0, 0));

            // Trả về hình ảnh đã xoay
            return rotatedBitmap;
        }
        float angle = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(angle < 360)
            {
                angle += 10;
                RotateImage(picSetting.Image, angle);
                picSetting.Invalidate();
            }
            else
            {
                angle += 10;
                RotateImage(picSetting.Image, angle);
                picSetting.Invalidate();
                timer1.Stop();
            }
        }

        private void lbSetting_MouseLeave(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}

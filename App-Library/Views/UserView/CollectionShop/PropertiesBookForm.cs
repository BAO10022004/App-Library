using App_Library.Models;
using App_Library.Services;
using App_Library.Views.Main.CollectionShop;
using App_Library.Views.ToolerForm;
using App_Library.Views.UserView.CollectionHome;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Xml.Linq;
using static Guna.UI2.Native.WinApi;
using Label = System.Windows.Forms.Label;
using Panel = System.Windows.Forms.Panel;

namespace App_Library.Views
{
    public partial class PropertiesBookForm : FormHelper
    {
        List<System.Windows.Forms.Panel> listPanelRecommed = new List<Panel>();
        Book book;int ranting;
        NewShopMain shop;
        List<Comment> comments;
        List<BookSold> bookSolds;
        public PropertiesBookForm(Book book, int ranting, NewShopMain shop, List<BookSold> bookSolds)
        {
            InitializeComponent();
            this.book = book;
            this.ranting = ranting;
            this.shop = shop;
            this.bookSolds = bookSolds;
        }

        private async void PropertiesBookForm_LoadAsync(object sender, EventArgs e)
        {
            LoadingForm loadingForm = new LoadingForm();
            loadingForm.Show();
            int count = 0;
            foreach(PictureBox pic in pnRating.Controls)
            {
                count++;
                if (count <= ranting)
                {
                    pic.Image = global::App_Library.Properties.Resources.Star;
                }
            }
            // Tải hình ảnh từ URL
            try
            {
                picImageBook.Load(book.Image); // Đường dẫn hoặc URL của ảnh
            }
            catch (Exception)
            {
                // Nếu có lỗi khi tải ảnh, có thể đặt ảnh mặc định hoặc để trống
               // return null; // Ảnh trống kích thước 300x335
            }
            lblNameProduct.Text = book.Title;

            lblAuthor.Text = book.Author;
            lblGenre.Text = book.Genre;
            lblPrice.Text = book.Price+ "$";
            lblPublishYear.Text = book.PublishedYear.ToString();
            lblContent.Text = book.Content;
            pnNameBook.Width = lblNameProduct.Width + 20;
            pnRating.Location =new Point( pnNameBook.Location.X + pnNameBook.Width, pnRating.Location.Y);
            // Recommend
            var books =await (new BookService()).GetBooksAsync();
            
            for(int i=0; i<4; i++ )
            {
                var book = books[(new Random()).Next(books.Count)];
                books.Remove(book);
                flowpnRecommed.Controls.Add(shop.createPanel( book,i, null));
            }
            // fixed scroll
            int HEIGHT = 0;
            foreach (Control control in pnDescription.Controls)
            {
                HEIGHT += control.Height;
            }
            pnDescription.Height = HEIGHT;
            // set button Buy
            var getUserId = (await shop._user.GetCurrentUserAsync()).Id;
            var getBookId = book.Id;
            var getBookBought = shop.listBookSold;
            foreach (var item in getBookBought)
            {
                if (item.BookId.Equals(getBookId) && item.UserId.Equals(getUserId))
                {
                    pnReadBook.Location = btnBuy.Location;
                    pnReadBook.Visible = true;
                    btnBuy.Visible = false;
                    btnPending.Visible = false;
                }
            }
            
            foreach(var item in bookSolds)
            {
                if (item.BookId.Equals(getBookId) && item.Status == "Pending")
                {
                    btnPending.Location = btnBuy.Location;
                    btnPending.Visible = true;
                    btnBuy.Visible = false;
                    pnReadBook.Visible = false;
                }
            }
            CommentService _commentDb = new CommentService();
            comments = new List<Comment>();
            comments = await _commentDb.GetBookCommentsAsync(book.Id);
            pnToolComment.Height = 300 + comments.Count * 200;
            activeFormChild(pnToolComment, new CommentForm(book, shop), null, ref formComment);
            loadingForm.Close();
        }
        

        Form form;
        Form formComment;
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel4_MouseHover(object sender, EventArgs e)
        {
            if(sender is Guna2Panel)
            {
                Guna2Panel panelSender = (Guna2Panel)sender;
                panelSender.FillColor = panelSender.BorderColor;
                foreach(Control control in panelSender.Controls)
                {
                    if (control is Label)
                    {
                        control.ForeColor = Color.White;
                    }
                    control.BackColor = panelSender.FillColor;  
                }
            }
        }

        private void btnBuy_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Guna2Panel)
            {
                Guna2Panel panelSender = (Guna2Panel)sender;
                panelSender.FillColor = Color.White;
                foreach (Control control in panelSender.Controls)
                {
                    if (control is Label)
                    {
                        control.ForeColor = (sender as Guna2Panel).BorderColor;
                    }
                    control.BackColor = Color.White;
                }
            }
        }

        private void guna2TextBox1_Click(object sender, EventArgs e)
        {
            (sender as Guna2TextBox).Text = "";
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if ((sender as Guna2TextBox).Text.Equals("Add Comment ..."))
            {
                (sender as Guna2TextBox).Text = "";
            }
            if ((sender as Guna2TextBox).Text.Equals(""))
            {
                (sender as Guna2TextBox).Text = "Add Comment ...";
            }
        }
        void ReSize()
        {
            pnMainPropertiesBook.Size = new Size(Width, pnMainPropertiesBook.Height);
            pnInfoBook.Size = new Size(Width, pnInfoBook.Height);
            guna2Panel2.Size = new Size(Width, guna2Panel2.Height);
            foreach(Control control in pnMainPropertiesBook.Controls)
            {
                control.Size = new Size(pnMainPropertiesBook.Width, control.Height);
            }
            if(btnBuy.Visible == true)
            {
                btnBuy.Location = new Point((pnContainButtonBuy.Width - btnBuy.Width) / 2, (pnContainButtonBuy.Height - btnBuy.Height) / 2);
            }
            else
            {
                pnReadBook.Location = new Point((pnContainButtonBuy.Width - pnReadBook.Width) / 2, (pnContainButtonBuy.Height - pnReadBook.Height) / 2);
            }

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pnMainInfoBook_Resize(object sender, EventArgs e)
        {
            ReSize();
        }

        private void btnBuy_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnBuy_Click(object sender, EventArgs e)
        {
            User user =await ( new UserService()).GetCurrentUserAsync();
            BookSold bookSold = new BookSold()
            {
                BookId = book.Id,
                UserId = (await (new UserService()).GetCurrentUserAsync()).Id,
                Username = (await (new UserService()).GetCurrentUserAsync()).Username,
                Status = "Pending",
                Slug = book.Slug,
                Title = book.Title,
                Email = user.Email,
                Image = book.Image,
                Genre = book.Genre,
                Price = book.Price,
            };
            LoadingForm loadingForm = new LoadingForm();
            loadingForm.Show();
            String mes = await (new BookSoldService()).CreateBookSoldAsync(bookSold);
            loadingForm.Close();
            (new AlertSuccess("Your book is pedding")).ShowDialog();            
        }
        Form formAct;
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            activeFormChild(shop.parent.pnContent, new NewShopMain(shop.parent), null,ref formAct);
        }

        private void btnPending_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbBtnPedding_Click(object sender, EventArgs e)
        {

            shop.parent.nextPageToHistory(sender);
        }
    }
}

using App_Library.Models;
using App_Library.Services;
using App_Library.Views.Main.CollectionShop;
using App_Library.Views.ToolerForm;
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
        public PropertiesBookForm(Book book, int ranting, NewShopMain shop)
        {
            InitializeComponent();
            this.book = book;
            this.ranting = ranting;
            this.shop = shop;
        }

        private async void PropertiesBookForm_LoadAsync(object sender, EventArgs e)
        {
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
            //list book
            List<Task<Panel>> tasks = new List<Task<Panel>>();
            for (int i = 0; i < 6; i++)
            {
                var tack = shop.listBook[i].CreateBookPanelAsync(i, 4);
                if (await tack != null && !shop.listBook[i].Title.Equals(book.Title))
                {
                    tasks.Add(tack);
                }
            }
        
            listPanelRecommed = ((await Task.WhenAll(tasks)).ToList());


            // Load Recommend
            activeFormChild(pnRecommend, new HotDealForm(listPanelRecommed, shop, "Recommend"),null, ref form);
            this.pictureBox2.Click += new System.EventHandler(this.shop.back_Click);
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
                }
            }
            //CommentService _commentDb = new CommentService();
            
            // comments =await  _commentDb.GetBookCommentsAsync(book.Id);
            //pnToolComment.Height = 300 + comments.Count *200;

            //activeFormChild(pnToolComment, new CommentForm(comments, book, shop), null, ref formComment);
        }
        Form form;
        Form formComment;
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

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
    }
}

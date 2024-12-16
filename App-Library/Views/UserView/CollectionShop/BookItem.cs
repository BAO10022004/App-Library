using App_Library.Models;
using App_Library.Services;
using App_Library.Views.Main.CollectionShop;
using App_Library.Views.ToolerForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library.Views.UserView.CollectionShop
{
    public partial class BookItem : Form
    {
        NewShopMain parent;
        Book book;
        PanelBook bookBook;
        public BookItem(PanelBook pnBook, NewShopMain parent )
        {
            InitializeComponent();
            this.parent = parent;
            this.book = pnBook.Data;
            bookBook = pnBook;

        }

        private async void BookItem_Load(object sender, EventArgs e)
        {
            // Load hình ảnh từ URL không đồng bộ
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var imageBytes = await client.GetByteArrayAsync(book.Image);
                    using (var ms = new System.IO.MemoryStream(imageBytes))
                    {
                        picImage.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
            }
            catch (Exception)
            {
            }
            lbPrice.Text = book.Price + "$";
            lbNameBook.Text = book.Title;
            var bookRating = (await (new StarsRatingService()).GetBookRatingAsync(book.Id));
            int start = bookRating != null? bookRating.TotalRatings : 0;
            lbInfo.Text = start + "* |" + book.Genre;
        }

        private void picImage_Click(object sender, EventArgs e)
        {
            if (bookBook.Parent != null)
            {
                parent.bookClick(book, bookBook);
            }else
            parent.bookClick(book);

        }

        private void lbInfo_Click(object sender, EventArgs e)
        {

        }
    }
}

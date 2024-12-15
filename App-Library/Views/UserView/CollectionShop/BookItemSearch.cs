using App_Library.Models;
using App_Library.Services;
using App_Library.Views.Main.CollectionShop;
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
    public partial class BookItemSearch : Form
    {
        Book book;
        NewShopMain NewShopMain;
        public BookItemSearch(Book book, NewShopMain newShopMain )
        {
            InitializeComponent();
            this.book = book;
            this.NewShopMain = newShopMain;
        }

        private async void BookItemSearch_Load(object sender, EventArgs e)
        {
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
            lbAuthor.Text = book.Author;
            lbNameBook.Text = book.Title.ToString();
        }

        private void lbNameBook_Click(object sender, EventArgs e)
        {
            NewShopMain.bookClick(book);
        }
    }
}

using App_Library.Models;
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

namespace App_Library.Views.UserView.CollectionHome
{
    public partial class BookItemList : Form
    {
        Book book;
        public BookItemList(Book book)
        {
            InitializeComponent();
            this.book = book;
        }

        private async void BookItemList_Load(object sender, EventArgs e)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var imageBytes = await client.GetByteArrayAsync(book.Image);
                    using (var ms = new System.IO.MemoryStream(imageBytes))
                    {
                        picBook.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
            }
            catch (Exception)
            {

            }
            lbAuthor.Text = book.Author;
            lbGence.Text = book.Genre;
            lbNameBook.Text = book.Title;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            (new PdfViewerForm(book.PdfUrl)).ShowDialog();
        }
    }
}

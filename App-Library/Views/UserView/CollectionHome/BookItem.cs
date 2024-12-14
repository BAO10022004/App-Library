using App_Library.Models;
using Guna.UI2.WinForms;
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
    public partial class BookItem : Form
    {
        Book book;
        BoughtBook parent;
        public BookItem(Book book, BoughtBook parent)
        {
            InitializeComponent();
            this.book = book;
            this.parent = parent;
        }

        private async void  BookItem_Load(object sender, EventArgs e)
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
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            (new PdfViewerForm(book.PdfUrl)).ShowDialog();
        }


        private void pnNoSee_MouseHover(object sender, EventArgs e)
        {
            foreach(Guna2Panel pn in parent.pnContent.Controls)
            {
                foreach(BookItem bookItem in  pn.Controls)
                {
                    bookItem.pnContainRead.Controls.Clear();
                }
            }
            pnContainRead.Controls.Add(btnRead);
        }

        private void pnNoSee_MouseLeave(object sender, EventArgs e)
        {
           // pnContainRead.Controls.Remove(btnRead);
           
        }

        private void pnContainRead_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

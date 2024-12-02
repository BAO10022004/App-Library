using App_Library.Models;
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
using System.Xml.Linq;

namespace App_Library.Views.UserView.CollectionHome
{
    public partial class HistoryChild : Form
    {
        HistoryForm myParent;
        BookSold bookSold;
        public HistoryChild(HistoryForm parent, BookSold bookSold)
        {
            InitializeComponent();
            myParent = parent;
            this.bookSold = bookSold;
        }

        private async void HistoryChild_Load(object sender, EventArgs e)
        {
            
            BookService bookService = new BookService();
            Book book =await bookService.GetBookBySlugAsync(bookSold.Slug);
            lbBookName.Text = book.Title;
            lbAuthor.Text = book.Author;
            lbPrice.Text = book.Price + "$";
            lbTime.Text = bookSold.CreatedAt.ToString();
            lbStatus.Text = bookSold.Status;
            if (bookSold.Status.Equals("Approved"))
                lbStatus.ForeColor = System.Drawing.Color.Green;
            else
                lbStatus.ForeColor = System.Drawing.Color.Red;
        }

        private void lbTime_Click(object sender, EventArgs e)
        {

        }

        private void lbAuthor_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}

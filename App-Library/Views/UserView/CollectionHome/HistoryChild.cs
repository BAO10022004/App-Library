using App_Library.Models;
using App_Library.Services;
using App_Library.Views.ToolerForm;
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
    public partial class HistoryChild : FormHelper
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
            lbTime.Text ="  " + bookSold.CreatedAt.ToString();
            lbStatus.Text = bookSold.Status;
            if (!bookSold.Status.Equals("Approved"))
            {
                lbStatus.ForeColor = System.Drawing.Color.Red;
             
            }
            else
            {
                lbStatus.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void HistoryChild_Resize(object sender, EventArgs e)
        {
            //this.Width = myParent.Width;
            //pnBookName.Width = Convert.ToInt32(this.Width * 0.226);
            //pnAuthor.Width = Convert.ToInt32(this.Width * 0.166);
            //pnPrice.Width = Convert.ToInt32(this.Width * 0.10);
            //pnStatus.Width = Convert.ToInt32(this.Width * 0.17);
            //pnTime.Width = Convert.ToInt32(this.Width * 0.19);
        }
        int countDown = 4;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(countDown > 0)
            {
                countDown--;
            }
            else
            {
                countDown = 4;
                timer1.Stop();
            }
        }

        private void lbBookName_Click(object sender, EventArgs e)
        {

        }
    }
}

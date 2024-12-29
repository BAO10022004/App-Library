using App_Library.Models;
using App_Library.Services;
using Guna.UI2.WinForms;
using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto.Macs;
using App_Library.Views.ToolerForm;
using Firebase.Auth;

namespace App_Library.Views.UserView.CollectionHome
{
    public partial class HistoryForm : FormHelper
    {
        List<BookSold> BookSolds;
        String mailPassword;
        public  HistoryForm(List<BookSold> bookSolds)
        {
            BookSolds = new List<BookSold>();
            InitializeComponent();
            foreach(BookSold book in bookSolds)
            {
                if(book.Slug != null)
                {
                    this.BookSolds.Add(book);
                }
            }
        }
        private void HistoryForm_Load(object sender, EventArgs e)
        {
            for(int i=0; i< BookSolds.Count; i++)
            {
                pnListProcessing.Controls.Add(this.createPanel(BookSolds[i],this.Width -100, i));
            }
            pnListProcessing.AutoScroll = true;
            pnListProcessing.AutoScrollMinSize = new System.Drawing.Size(0, 64 * BookSolds.Count);
        }
        Guna2Panel createPanel(BookSold bookSold,int width,  int index)
        {
            Guna2Panel gn = new Guna2Panel();
            if ( bookSold != null )
            {
                Form form = null;
                
                gn.Size = new System.Drawing.Size(width, 64);
                gn.Name = bookSold.Title;
                gn.TabIndex = index;
                activeFormChild(gn, new HistoryChild(this, bookSold), null, ref form);
               
            }
            return gn;
        }
        private void label1_Resize(object sender, EventArgs e)
        {

        }

        private void HistoryForm_Resize(object sender, EventArgs e)
        {
            pnBookName.Width = Convert.ToInt32(this.Width * 0.226);
            pnAuthor.Width = Convert.ToInt32(this.Width * 0.166);
            pnPrice.Width = Convert.ToInt32(this.Width * 0.14);
            pnStatus.Width = Convert.ToInt32(this.Width * 0.13);
            pnTime.Width = Convert.ToInt32(this.Width * 0.19);
            pnListProcessing.Width = this.Width;
            //pnListProcessing.Controls.Clear();
            
            //for (int i = 0; i < BookSolds.Count; i++)
            //{
            //    pnListProcessing.Controls.Add(this.createPanel(BookSolds[i], this.Width - 50, i));
            //}
            pnListProcessing.AutoScroll = true;
            pnListProcessing.AutoScrollMinSize = new System.Drawing.Size(0, 64 * BookSolds.Count);
        }
       
    }
}
     
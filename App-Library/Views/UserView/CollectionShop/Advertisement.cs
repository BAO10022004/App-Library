using App_Library.Models;
using App_Library.Views.ToolerForm;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Suite.Descriptions;

namespace App_Library.Views.Main.CollectionShop
{
    public partial class Advertisement : Form
    {
        internal Book book ;
        NewShopMain shopMain;
        Dictionary<Image, Book> mapBanner;
        public Advertisement(Image img, Book book,  NewShopMain shop)
        {
            InitializeComponent();
            this.book = book;
            picImageBook.Image = img;
            this.shopMain = shop;
        }

        private void Advertisement_Load(object sender, EventArgs e)
        {
           
        }

        private void picImageBook_Click(object sender, EventArgs e)
        {
            shopMain.bookClick(book);
        }
    }
}

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
        Color color;
        public Advertisement(Image img, Book book,  NewShopMain shop, Color color)
        {
            InitializeComponent();
            this.book = book;
            picImageBook.Image = img;
            this.shopMain = shop;
            this.color = color;
        }

        private void Advertisement_Load(object sender, EventArgs e)
        {
           
        }

        private void picImageBook_Click(object sender, EventArgs e)
        {
            shopMain.bookClick(book);
        }

        private void timerHover_Tick(object sender, EventArgs e)
        {
            int target = 250;
            int current = pnMain.ShadowShift;

            int delta = Math.Max(1, (target - current) / 10); 

            if (current < target)
            {
                pnMain.ShadowShift += delta;
            }
            else
            {
                pnMain.ShadowShift = target; 
                timerHover.Stop();
            }
        }


        private void picImageBook_MouseHover(object sender, EventArgs e)
        {
            
            pnMain.ShadowShift = 50;
            pnMain.ShadowColor = color; 
            timerHover.Start();
        }

        private void picImageBook_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void picImageBook_MouseLeave_1(object sender, EventArgs e)
        {
            pnMain.ShadowColor = Color.White;
        }
    }
}

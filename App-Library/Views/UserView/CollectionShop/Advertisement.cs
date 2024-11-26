﻿using App_Library.Models;
using App_Library.Views.ToolerForm;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Suite.Descriptions;

namespace App_Library.Views.Main.CollectionShop
{
    public partial class Advertisement : Form
    {
        internal Book book;
        NewShopMain shopMain;
        public Advertisement(Book book, NewShopMain shop)
        {
            InitializeComponent();
            this.book = book;
            this.shopMain = shop;

        }

        private void Advertisement_Load(object sender, EventArgs e)
        {
            try
            {
                picImageBook.Load(book.Image); // Đường dẫn hoặc URL của ảnh
            }
            catch (Exception)
            {

            }
            lbTittelBook.Text = book.Title;
            lbPrice.Text += book.Price + "$";
           
            btnShowMore.FillColor = Color.FromArgb(40, 224, 224, 224);
        }
        private void bookAd_Click(object sender, EventArgs e)
        {
            
        }

        private void lbPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnShowMore_MouseHover(object sender, EventArgs e)
        {
            btnShowMore.BackColor = Color.CornflowerBlue;
        }

        private void btnShowMore_MouseLeave(object sender, EventArgs e)
        {
           
            btnShowMore.BackColor= Color.LightSteelBlue;
        }

        private void lbShowMore_Click(object sender, EventArgs e)
        {
            shopMain.bookClick(book);
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnShowMore_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

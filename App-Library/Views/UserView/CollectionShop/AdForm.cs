using App_Library.Models;
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

namespace App_Library.Views.Main.CollectionShop
{
    public partial class AdForm : FormHelper
    {
        List<Book> listBook;
        NewShopMain shop;
        // index Book in Ad
        int indexCurrentBookAd = 3;

        public AdForm(List<Book> listBook, NewShopMain formParent)
        {
            this.listBook = listBook;
            InitializeComponent();
            this.timerAd.Tick += new System.EventHandler(this.timer1_Tick);
            timerAd.Start();
            this.shop = formParent;
        }
        Form form1;
        private void AdForm_Load(object sender, EventArgs e)
        {
            loadAd(3);
        }
        void loadAd(int index)
        {
            timerAd.Interval = 10000;
            activeFormChild(pnAdMain, new Advertisement(listBook[index], shop), null, ref form1);
            if(index != listBook.Count -1)
            {
                shop.loadImageAsync(picSubAd1, listBook[index + 1].Image);
            }
            if (index != listBook.Count - 2)
            {
                shop.loadImageAsync(picSubAd2, listBook[index + 2].Image);
                return;
            }
            indexCurrentBookAd = 2;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            indexCurrentBookAd++;
            loadAd(indexCurrentBookAd);
        }
    }
}

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
        int indexCurrentBookAd = 0;

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
            activeFormChild(panel, new Advertisement(listBook[indexCurrentBookAd], shop), null, ref form1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timerAd.Interval == 1) timerAd.Interval = 10000;
            
            indexCurrentBookAd++;
            if (indexCurrentBookAd !=2)
                activeFormChild(panel, new Advertisement(listBook[indexCurrentBookAd], shop), null, ref form1);
        }
    }
}

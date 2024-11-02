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
    public partial class AdForm : Form
    {
        List<Panel> ListPanelAd;
        Form FormParent;
        // index Book in Ad
        int indexCurrentBookAd = 0;

        public AdForm(List<Panel> listPanelAd, Form formParent)
        {
            ListPanelAd = listPanelAd;
            InitializeComponent();
            this.timerAd.Tick += new System.EventHandler(this.timer1_Tick);
            timerAd.Start();
            FormParent = formParent;
        }

        private void AdForm_Load(object sender, EventArgs e)
        {
            //fpAdBook.Controls.Add(ListPanelAd[0]);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timerAd.Interval == 1) timerAd.Interval = 10000;

            indexCurrentBookAd++;
            if (indexCurrentBookAd < ListPanelAd.Count)
            {
                fpAdBook.Controls.Clear();
                fpAdBook.Controls.Add(ListPanelAd[indexCurrentBookAd]);
            }
            else
            {
                fpAdBook.Controls.Remove(ListPanelAd[indexCurrentBookAd - 1]);
                indexCurrentBookAd = 0;
                timer1_Tick(sender, e);
            }
        }
    }
}

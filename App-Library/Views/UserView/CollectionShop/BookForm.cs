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
    public partial class BookForm : Form
    {
        List<Panel> listPanel;
        NewShopMain shop;
        public BookForm(List<Panel> listPanel, NewShopMain shopMain, String title)
        {
            InitializeComponent();
            this.listPanel = listPanel;
            shop = shopMain;
            lblTitle.Text = title;
            pictureBox1.Click += new EventHandler(shop.back_Click);
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            

            foreach (Panel panel in listPanel)
            {
                flowLayoutPanel1.Controls.Add(panel);
            }

           

        }
    }
}

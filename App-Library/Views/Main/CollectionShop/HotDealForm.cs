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
    public partial class HotDealForm : Form
    {
        List<Panel> ListPanelHotDealBook = new List<Panel>();
        Form formParent;

        public HotDealForm(List<Panel> listPanelHotDealBook, NewShopMain FormParent)
        {
            formParent = FormParent;
            ListPanelHotDealBook = listPanelHotDealBook;
            InitializeComponent();
            fpHotDealBook.AutoScrollMinSize = new System.Drawing.Size((listPanelHotDealBook.Count + 1) * listPanelHotDealBook[0].Width, 0);
        }

        private void HotDealForm_Load(object sender, EventArgs e)
        {
            foreach (Panel panel in ListPanelHotDealBook)
            {
                fpHotDealBook.Controls.Add(panel);
            }

        }
    }
}

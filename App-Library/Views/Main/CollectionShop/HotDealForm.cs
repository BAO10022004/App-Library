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
        

        public HotDealForm(List<Panel> listPanelHotDealBook)
        {
            ListPanelHotDealBook = listPanelHotDealBook;
            InitializeComponent();
            //fpHotDealBook.Controls.Add(ListPanelHotDealBook[0]);
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

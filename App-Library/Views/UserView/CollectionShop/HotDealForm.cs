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
    public partial class HotDealForm : FormHelper
    {
        List<Panel> ListPanelBook = new List<Panel>();
        Form formParent;
        String titleForm;
        
        public HotDealForm(List<Panel> listPanelBook, NewShopMain FormParent, string titleForm)
        {
            formParent = FormParent;
            ListPanelBook = listPanelBook;
            InitializeComponent();
            this.titleForm = titleForm;
            lbTittle.Text = titleForm;
            pictureBox1.Location = new System.Drawing.Point(lbTittle.Location.X +  lbTittle.Size.Width, lbTittle.Location.Y);
            pnTittle.Size = new System.Drawing.Size(lbTittle.Size.Width + 10 +pictureBox1.Size.Width, 50);
            listPanelBook.ForEach(p => p.Click += new EventHandler(FormParent.bookHotDeal_Click));
        }

        private void HotDealForm_Load(object sender, EventArgs e)
        {
            fpListBook.SuspendLayout(); // Tạm dừng việc vẽ lại khi thêm các phần tử

            if (ListPanelBook.Count > 6)
            {
                for (int i = 0; i < 6; i++)
                {
                    fpListBook.Controls.Add(ListPanelBook[i]);
                }
            }
            else
            {
                foreach (Panel panel in ListPanelBook)
                {
                    fpListBook.Controls.Add(panel);
                }
            }

            fpListBook.ResumeLayout(); // Kích hoạt lại việc vẽ giao diện sau khi thêm xong


        }

        private void fpHotDealBook_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pnTittle_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox1.Image = global::App_Library.Properties.Resources.ArrowTittle;
        }

        private void pnTittle_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox1.Image = null;
        }
    }
}

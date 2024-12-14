using App_Library.Services;
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

namespace App_Library.Views.UserView.CollectionHome
{
    public partial class History : FormHelper
    {
        Form actForm;
        MainForm mainForm;
        SideBarUserForm sideBarUserForm;
        public History(MainForm parent, SideBarUserForm sideBarUserForm)
        {
            InitializeComponent();
           this.mainForm = parent;
            this.sideBarUserForm = sideBarUserForm;
        }

        private async void History_Load(object sender, EventArgs e)
        {
            
            var dbBookBold =await (new BookSoldService()).GetBooksInProgressAsync();
            if (dbBookBold.Count > 0)
            {
                pnMain.Controls.Clear();
                activeFormChild(pnMain, new HistoryForm(dbBookBold), null, ref actForm);
            }
            
        }

        private void btnNextShop_MouseHover(object sender, EventArgs e)
        {
            btnNextShop.TextAlign = HorizontalAlignment.Right;
        }

        private void btnNextShop_MouseLeave(object sender, EventArgs e)
        {
            btnNextShop.TextAlign = HorizontalAlignment.Left;
        }

        private void btnNextShop_Click(object sender, EventArgs e)
        {
            sideBarUserForm.lbHome_Click(sideBarUserForm.btnHome,e);
        }
    }
}

using App_Library.Models;
using App_Library.Services;
using App_Library.Views.ToolerForm;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace App_Library.Views.UserView.CollectionHome
{
    public partial class History : FormHelper
    {
        Form actForm;
        MainForm mainForm;
        SideBarUserForm sideBarUserForm;
        List<BookSold> books;
        public History(SideBarUserForm sideBarUserForm, List<BookSold> models)
        {
            InitializeComponent();
            this.sideBarUserForm = sideBarUserForm;
            this.books = models;
        }

        private void History_Load(object sender, EventArgs e)
        {
            
            
            if(books != null)
            {
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show();
                pnMain.Controls.Clear();
                activeFormChild(pnMain, new HistoryForm(books), null, ref actForm);
                loadingForm.Close();
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

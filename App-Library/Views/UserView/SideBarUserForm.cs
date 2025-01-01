using App_Library.Views.Main.CollectionShop;
using App_Library.Views.Orthers.CollectionProfile;
using App_Library.Views.ToolerForm;
using App_Library.Views.UserView.CollectionHome;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace App_Library.Views.UserView
{
    public partial class SideBarUserForm : FormHelper
    {
        MainForm _mainForm;
        Dictionary<Control, bool> isClick = new Dictionary<Control, bool>();
        public SideBarUserForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;


        }
        private void SideBarUserForm_Load(object sender, EventArgs e)
        {
            foreach (Control item in pnSideBar.Controls)
            {
                isClick[item] = false;
            }
            setIsClick(btnHome);

        }
        public void setIsClick(object sender)
        {
            Guna2Button myButton = sender as Guna2Button;
            myButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            myButton.FillColor = Color.SkyBlue;
            isClick[myButton] = true;
            foreach (Guna2Button control in pnSideBar.Controls)
            {
                if (!control.Name.Equals(myButton.Name))
                {
                    control.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    control.FillColor = Color.White;
                    isClick[control] = false;
                }
            }
        }
        public void lbHome_Click(object sender, EventArgs e)
        {
            setIsClick(sender as Control);
            _mainForm.activeFormChildForMainForm(new NewShopMain(_mainForm), e);
        }

        private async void lbStore_Click(object sender, EventArgs e)
        {
            setIsClick(sender as Control);
            _mainForm.activeFormChildForMainForm(new StockForm(this, await _mainForm.getListSold()), e);
        }
        private async void btnHistory_Click(object sender, EventArgs e)
        {
            setIsClick(sender as Control);
            _mainForm.activeFormChildForMainForm(new History(this,await _mainForm.getListSold()), e);
        }
        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            setIsClick(sender as Control);
            _mainForm.activeFormChildForMainForm(new NewProfileForm(_mainForm, await _mainForm.getListSold()), e);
        }
        
    }
}

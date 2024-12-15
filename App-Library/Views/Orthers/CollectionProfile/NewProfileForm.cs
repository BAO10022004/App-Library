using App_Library.Models;
using App_Library.Services;
using App_Library.Views.Orthers.CollectionEditProfile;
using App_Library.Views.ToolerForm;
using App_Library.Views.UserView;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library.Views.Orthers.CollectionProfile
{
    public partial class NewProfileForm : FormHelper
    {
        User user;
        public MainForm mainForm;
        public NewProfileForm(MainForm parent)
        {
            InitializeComponent();
            this.mainForm = parent;
        }

        private async void NewProfileForm_Load(object sender, EventArgs e)
        {
            user =await (new UserService()).GetCurrentUserAsync();
            lbEmail.Text = user.Email;
            lbUsername.Text = user.Username;
            try
            {
                picAvatar.Load(user.PhotoURL);

            }
            catch (Exception ex)
            {
            }
            //lbPending.Text = (await (new BookSoldService()).GetPendingBooksSoldAsync()).Count + "";
            //lbStock.Text = (await (new BookSoldService()).GetBoughtBooksAsync()).Count + "";
        }
        Form actFormEdit;
        Form actFormChange;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            activeFormChild(mainForm.pnContent, new CollectionEditProfile.EditprofileForm(this), null, ref actFormEdit); 
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (Program.checkLoginGG)
            {
                (new AlertFail("Acount login with Google cann't change password")).ShowDialog();
            }
            else
            {
                (new ChangePasswordForm(user)).ShowDialog();
            }
            
        }
    }
}

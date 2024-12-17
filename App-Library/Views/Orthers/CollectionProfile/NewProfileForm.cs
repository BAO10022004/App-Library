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
        private BookSoldService _bookSoldService;

        public NewProfileForm(MainForm parent)
        {
            InitializeComponent();
            _bookSoldService = new BookSoldService();
            this.mainForm = parent;
        }

        private async void NewProfileForm_Load(object sender, EventArgs e)
        {
            lbEmail.Text = Session.CurentUser.Email;
            lbUsername.Text = Session.CurentUser.Username;
            try
            {
                picAvatar.Load(Session.CurentUser.PhotoURL);
            }
            catch (Exception ex)
            {
            }
            var result = await _bookSoldService.GetBooksInProgressAsync();
            lbPending.Text = result.Where(n=>n.Status == "Pending").Count().ToString();
            lbStock.Text = result.Where(n => n.Status == "Approved").Count().ToString();
        }

        Form actFormEdit;
        //Form actFormChange;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            activeFormChild(mainForm.pnContent, new EditprofileForm(this), null, ref actFormEdit);
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

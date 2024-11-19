using App_Library.Models;
using App_Library.Services;
using App_Library.Views.Orthers.CollectionEditProfile;
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
    public partial class ProfileForm : Form
    {
        private User currentUser;
        private UserService _userService;
        public ProfileForm()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private async void ProfileForm_Load(object sender, EventArgs e)
        {
            currentUser = await _userService.GetCurrentUserAsync();
            lblUserName.Text = currentUser.Username;
            lblEmail.Text = currentUser.Email;
            picAvatar.Load(currentUser.PhotoURL);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var editForm = new EditprofileForm();
            editForm.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

        }
    }
}

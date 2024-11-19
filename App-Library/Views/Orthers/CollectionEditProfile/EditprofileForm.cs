using App_Library.Models;
using App_Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library.Views.Orthers.CollectionEditProfile
{
    public partial class EditprofileForm : Form
    {
        private User currentUser;
        private UserService _userService;
        public EditprofileForm()
        {
            InitializeComponent();
            _userService = new UserService();
        }
        private async void EditprofileForm_Load(object sender, EventArgs e)
        {
            currentUser = await _userService.GetCurrentUserAsync();
            txtName.Text = currentUser.Username;
            txtEmail.Text = currentUser.Email;
            picAvatar.Load(currentUser.PhotoURL);
        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnChangeAvartar_Click(object sender, EventArgs e)
        {

        }
    }
}

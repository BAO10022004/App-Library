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
        private MainForm _mainForm;
        public ProfileForm(MainForm mainForm)
        {
            InitializeComponent();
            _userService = new UserService();
            _mainForm = mainForm;
            LoadData();
        }

        public void LoadData()
        {
            Console.WriteLine("load profile");
            //currentUser = await _userService.GetCurrentUserAsync();
            //lblUserName.Text = currentUser.Username;
            //lblEmail.Text = currentUser.Email;
            //picAvatar.Load(currentUser.PhotoURL);
            lblUserName.Text = Session.CurentUser.Username;
            lblEmail.Text = Session.CurentUser.Email;
            picAvatar.Load(Session.CurentUser.PhotoURL);
            _mainForm.LoadUser();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var editForm = new EditprofileForm(this);
            editForm.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            var changeForm = new ChangePasswordForm();
            changeForm.ShowDialog();
        }
    }
}

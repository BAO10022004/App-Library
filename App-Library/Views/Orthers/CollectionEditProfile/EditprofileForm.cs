using App_Library.Models;
using App_Library.Services;
using App_Library.Views.Orthers.CollectionProfile;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace App_Library.Views.Orthers.CollectionEditProfile
{
    public partial class EditprofileForm : Form
    {
        private UserService _userService;
        private FirebaseService _firebaseService;
        private ProfileForm _profileForm;
        private string _pathImage = "";
        public EditprofileForm(ProfileForm form)
        {
            InitializeComponent();
            _userService = new UserService();
            _firebaseService = new FirebaseService();
            _profileForm = form;
            txtName.Text = Session.CurentUser.Username;
            txtEmail.Text = Session.CurentUser.Email;
            picAvatar.Load(Session.CurentUser.PhotoURL);
        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var photoUrl = Session.CurentUser.PhotoURL;
            if (!string.IsNullOrWhiteSpace(_pathImage))
            {
                photoUrl = await _firebaseService.UploadFileAsync(_pathImage, "");
            }
            var updateuser = new UpdateUserDTO
            {
                Email = txtEmail.Text,
                Username = txtName.Text,
                PasswordHash = Session.CurentUser.PasswordHash,
                PhotoURL = photoUrl
            };

            var result = await _userService.UpdateUserAsync(Session.CurentUser.Id, updateuser);
            if (result)
            {
                MessageBox.Show("Cập nhật thành công");
                _profileForm.LoadData();
                this.Close();
            }
            else
            {
                MessageBox.Show("Không thể cập nhật");
            }
        }

        private void btnChangeAvartar_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picAvatar.Load(openFileDialog.FileName);
                _pathImage = openFileDialog.FileName;
            }
        }
    }
}

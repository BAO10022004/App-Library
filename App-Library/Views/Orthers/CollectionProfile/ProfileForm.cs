using App_Library.Models;
using App_Library.Services;
using App_Library.Views.Orthers.CollectionEditProfile;
using App_Library.Views.ToolerForm;
using Microsoft.IdentityModel.Abstractions;
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
    public partial class ProfileForm : FormHelper
    {
        private User currentUser;
        private UserService _userService;
        Control.ControlCollection listControl;
        public MainForm mainForm;
        public ProfileForm(MainForm main)
        {
            InitializeComponent();
            _userService = new UserService();
            listControl = new Control.ControlCollection(pnMain);
            main.refresh();
            this.mainForm = main;
        }

        private async void ProfileForm_Load(object sender, EventArgs e)
        {
            currentUser = await _userService.GetCurrentUserAsync();
            lblUserName.Text = currentUser.Username;
            lblEmail.Text = currentUser.Email;
            try
            {
                picAvatar.Load(currentUser.PhotoURL);

            }
            catch (Exception ex)
            {
            }
        }


        private void btnChangePassword_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            timerOpenEditForm.Start();
        }
        Form formEditForm;
        private void timerOpenEditForm_Tick(object sender, EventArgs e)
        {
            if (pnBackground.Height > 0)
            {
                pnBackground.Height -= 10;
            }
            else
            {
                pnBackground.Height = 0;
                timerOpenEditForm.Stop();
                pnMain.Controls.Clear();
                activeFormChild(pnMain, new EditprofileForm(this), null, ref formEditForm);

            }
        }
        public void startTimerClose()
        {
            timerCloseEditForm.Start();
        }
        private void timerCloseEditForm_Tick(object sender, EventArgs e)
        {
            if (pnBackground.Height < 360)
            {
                pnBackground.Height += 10;
            }
            else
            {
                pnBackground.Height = 360;
                timerCloseEditForm.Stop();
                pnMain.Controls.Clear();
                foreach (Control control in listControl)
                {
                    if (control != null)
                    {
                        pnMain.Controls.Add(control);

                    }
                }

            }
        }
        Form actFormChangePassword;
        private void btnChangePassword_Click_1(object sender, EventArgs e)
        {
            timeropenChangePassword.Start();
        }

        private void timeropenChangePassword_Tick(object sender, EventArgs e)
        {
            if (pnBackground.Height > 0)
            {
                pnBackground.Height -= 10;
            }
            else
            {
                pnBackground.Height = 0;
                timeropenChangePassword.Stop();
                pnMain.Controls.Clear();
                activeFormChild(pnMain, new ChangePasswordForm(), null, ref actFormChangePassword);

            }
        }
    }
}

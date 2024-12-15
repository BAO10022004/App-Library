using App_Library.Models;
using App_Library.Services;
using App_Library.Views.ToolerForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library.Views.Orthers.CollectionEditProfile.ChangePasswordCollection
{
    public partial class NewPasswordForm : FormHelper
    {
        User user;
        ChangePasswordForm parent;
        AuthService authService;
        UserService userService;
        public NewPasswordForm(Models.User user, ChangePasswordForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.user = user;
            authService = new AuthService();
            userService = new UserService();
            txtPassword.PasswordChar = '•';
            txtConfirmPassword.PasswordChar = '•';
        }
        private void btnNext_MouseHover(object sender, EventArgs e)
        {
            btnNext.Text = "Next";
            timerHHoverNext.Start();
        }

        private void timerHHoverNext_Tick(object sender, EventArgs e)
        {
            if (btnNext.Width < 170)
            {
                btnNext.Width += 10;
                btnNext.Location = new Point(btnNext.Location.X - 10, btnNext.Location.Y);
            }
            else
            {
                btnNext.Width = 170;
                btnNext.Location = new Point(413, 469);
                timerHHoverNext.Stop();
            }
        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            timerHHoverNext.Stop();
            btnNext.Text = "";
            timerLeave.Start();
        }

        private void timerLeave_Tick(object sender, EventArgs e)
        {
            if (btnNext.Width > 80)
            {
                btnNext.Width -= 10;
                btnNext.Location = new Point(btnNext.Location.X + 10, btnNext.Location.Y);
            }
            else
            {
                btnNext.Width = 80;
                btnNext.Location = new Point(503, 469);
                timerLeave.Stop();
            }
        }


        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (CheckConfirmPass() && CheckNewPass())
            {
                var updateuser = new UpdateUserDTO
                {
                    Email = user.Email,
                    Username = user.Username,
                    PasswordHash = txtPassword.Text,
                    PhotoURL = user.PhotoURL
                };
                parent.Hide();
                var result = await userService.UpdateUserAsync(user.Id, updateuser);
            }
        }

        private bool CheckNewPass()
        {
            var passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            bool check = true;
            // Kiểm tra rổng
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                if (lbMessegeErrorPassword.Equals(""))
                {
                    lbMessegeErrorPassword.Text = "Please enter password";
                }
                check = false;
            }
            else if (txtPassword.Text.Length < 5)
            {
                if (lbMessegeErrorPassword.Equals(""))
                {
                    lbMessegeErrorPassword.Text = "Password must be at least 5 characters long";
                }
                check = false;
            }
            else if (txtPassword.Text.Length > 20)
            {
                if (lbMessegeErrorPassword.Equals(""))
                {
                    lbMessegeErrorPassword.Text = "Password must be less than 20 characters long";
                }
                check = false;
            }
            // Kiểm tra định dạng
            if (!Regex.IsMatch(txtPassword.Text, passwordPattern))
            {
                if (lbMessegeErrorPassword.Equals(""))
                {
                    lbMessegeErrorPassword.Text = "Password must contain uppercase, lowercase, numbers and special characters";
                }
                check = false;
            }
            if (!check)
            {
                txtPassword.BorderColor = Color.Red;
            }
            return check;
        }

        public bool CheckConfirmPass()
        {
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                if (lbMessegeErrorConfirm.Equals(""))
                {
                    lbMessegeErrorConfirm.Text = "Please confirm password";
                }
                return false;
            }
            else
            // Kiểm tra định dạng
            if (!txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                if (lbMessegeErrorConfirm.Equals(""))
                {
                    lbMessegeErrorConfirm.Text = "Password confirm incorrect";
                }
                return false;
            }
            else
            {
                return true;
            }
        }
        bool isEyeForConfirmClose = false;
        bool isEyeForPassClose = false;
        void closeEye(PictureBox pic)
        {
            try
            {
                pic.Image = global::App_Library.Properties.Resources.eye_slash;
                if (pic.Name.Contains("C"))
                {
                    // Confirm
                    isEyeForConfirmClose = true;
                    txtConfirmPassword.PasswordChar = '•';
                    picEyeConfirm.Click += new EventHandler(this.picEyeConfirm_Click);
                }
                else
                {
                    isEyeForPassClose = true;
                    txtPassword.PasswordChar = '•';
                    picEyePassword.Click += new EventHandler(this.picEyePassword_Click);
                }

            }
            catch (Exception ex)
            {
            }

        }
        void openEyeFor(PictureBox pic)
        {
            try
            {
                pic.Image = global::App_Library.Properties.Resources.eye;
                if (pic.Name.Contains("Confirm"))
                {
                    // Confirm
                    isEyeForConfirmClose = false;
                    txtConfirmPassword.PasswordChar = '\0';
                    timerOpenEyeForConfirm.Start();
                    picEyeConfirm.Click -= new EventHandler(this.picEyeConfirm_Click);
                }
                else
                {
                    isEyeForPassClose = false;
                    txtPassword.PasswordChar = '\0';
                    timerOpenEyeForPassWord.Start();
                    picEyePassword.Click -= new EventHandler(this.picEyePassword_Click);
                }

            }
            catch (Exception ex)
            {
            }

        }

        private void picEyeConfirm_Click(object sender, EventArgs e)
        {
            openEyeFor(picEyeConfirm);
        }

        private void picEyePassword_Click(object sender, EventArgs e)
        {
            openEyeFor(picEyePassword);
        }
        int countDown = 3;
        private void timerOpenEyeForConfirm_Tick(object sender, EventArgs e)
        {
            if (countDown > 0)
            {
                countDown--;
            }
            else
            {
                countDown = 3;
                timerOpenEyeForConfirm.Stop();
                closeEye(picEyeConfirm);
            }
        }

        private void timerOpenEyeForPassWord_Tick(object sender, EventArgs e)
        {
            if (countDown > 0)
            {
                countDown--;
            }
            else
            {
                countDown = 3;
                timerOpenEyeForPassWord.Stop();
                closeEye(picEyePassword);
            }
        }
    }
}

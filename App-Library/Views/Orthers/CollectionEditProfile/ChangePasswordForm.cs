using App_Library.Services;
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

namespace App_Library.Views.Orthers.CollectionEditProfile
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        private bool CheckOldPass()
        {
            if (string.IsNullOrWhiteSpace(txtOldPass.Text))
            {
                errorProviderOldPass.SetError(txtOldPass, "Mật khẩu không được để trống");
                return false;
            }
            else if (txtOldPass.Text.Equals(Session.CurentUser.PasswordHash))
            {
                errorProviderOldPass.SetError(txtOldPass, "Mật khẩu không được để trống");
                return false;
            }
            else
            {
                errorProviderOldPass.SetError(txtOldPass, string.Empty);
                return true;
            }
        }
        private bool CheckNewPass()
        {
            var passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            // Kiểm tra rổng
            if (string.IsNullOrWhiteSpace(txtNewPass.Text) || txtNewPass.Text == "Password")
            {
                errorProviderNewPass.SetError(txtNewPass, "Please enter password");
                return false;
            }
            else if (txtNewPass.Text.Length < 5)
            {
                errorProviderNewPass.SetError(txtNewPass, "Password must be at least 5 characters long");
                return false;
            }
            else if (txtNewPass.Text.Length > 20)
            {
                errorProviderNewPass.SetError(txtNewPass, "Password must be less than 20 characters long");
                return false;
            }
            // Kiểm tra định dạng
            if (!Regex.IsMatch(txtNewPass.Text, passwordPattern))
            {
                errorProviderNewPass.SetError(txtNewPass, "Password must contain uppercase, lowercase, numbers and special characters");
                return false;
            }
            else
            {
                errorProviderNewPass.SetError(txtNewPass, string.Empty);
                return true;
            }
        }
        private bool CheckConfirmPass()
        {
            // Kiểm tra rổng
            if (string.IsNullOrWhiteSpace(txtConfirmPass.Text) || txtConfirmPass.Text == "Confirm Password")
            {
                errorProviderConfirmPass.SetError(txtConfirmPass, "Please confirm password");
                return false;
            }
            // Kiểm tra định dạng
            if (!txtConfirmPass.Text.Equals(txtConfirmPass.Text))
            {
                errorProviderConfirmPass.SetError(txtConfirmPass, "Password confirm incorrect");
                return false;
            }
            else
            {
                errorProviderConfirmPass.SetError(txtConfirmPass, string.Empty);
                return true;
            }
        }
    }
}

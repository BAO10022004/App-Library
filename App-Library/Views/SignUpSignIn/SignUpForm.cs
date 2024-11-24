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
using App_Library.Models;
using App_Library.Services;
using App_Library.Views.SignIn;
using Org.BouncyCastle.Asn1.Ocsp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace App_Library.Views
{
    public partial class SignUpForm : Views.ToolerForm.FormHelper
    {
        private SplashForm _splashForm;
        private readonly AuthService _authService;
        bool isEyeForPassClose = true;
        bool isEyeForConfirmClose = true;
        int second = 2;
        public SignUpForm(SplashForm splashForm)
        {
            InitializeComponent();
            _splashForm = splashForm;
            _authService = new AuthService();
        }
        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void lbLogin2_Click(object sender, EventArgs e)
        {
            _splashForm.OpentLogin();
        }

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            if (checkEmail() && checkUsername() && checkPassword() && checkConfirmPassword())
            {
                var result = await _authService.SignUpAsync(txbUsername.Text, txbEmail.Text, txbPassword.Text);
                if (result.Equals("Success"))
                {
                    MessageBox.Show("Registration successful");
                    _splashForm.OpentLogin();
                }
                else if (result.Equals("Username already exists"))
                {
                    errorProviderUsername.SetError(txbUsername, result);
                }
                else if (result.Equals("Email already exists"))
                {
                    errorProviderEmail.SetError(txbEmail, result);
                }
            }
        }
        private async void btnSignInGG_Click(object sender, EventArgs e)
        {
            var googleLoginForm = new GoogleLoginForm();
            bool checkLoginSuccess = await googleLoginForm.GoogleSignInAndSaveUserAsync();
            if (checkLoginSuccess)
            {
                MessageBox.Show("Success");
                _splashForm.OpenMainForm();
            }
        }
        private bool checkEmail()
        {
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            // Kiểm tra rổng
            if (string.IsNullOrWhiteSpace(txbEmail.Text) || txbEmail.Text == "Email")
            {
                errorProviderEmail.SetError(txbEmail, "Please enter email");
                return false;
            }
            // Kiểm tra định dạng
            if (!Regex.IsMatch(txbEmail.Text, emailPattern))
            {
                errorProviderEmail.SetError(txbEmail, "Email format incorrect");
                return false;
            }
            else
            {
                errorProviderEmail.SetError(txbEmail, string.Empty);
                return true;
            }
        }
        private bool checkUsername()
        {
            var namePattern = @"^[a-zA-Z0-9\s]+$";
            // Kiểm tra rổng
            if (string.IsNullOrWhiteSpace(txbUsername.Text) || txbUsername.Text == "Username")
            {
                errorProviderUsername.SetError(txbUsername, "Please enter username");
                return false;
            }
            else if (txbUsername.Text.Length < 3)
            {
                errorProviderUsername.SetError(txbUsername, "Username must be at least 3 characters long");
                return false;
            }
            else if (txbUsername.Text.Length > 20)
            {
                errorProviderUsername.SetError(txbUsername, "Username must be less than 20 characters long");
                return false;
            }
            // Kiểm tra định dạng
            if (!Regex.IsMatch(txbUsername.Text, namePattern))
            {
                errorProviderUsername.SetError(txbUsername, "Username must contain only letters, numbers and spaces, no special characters");
                return false;
            }
            else
            {
                errorProviderUsername.SetError(txbUsername, string.Empty);
                return true;
            }
        }
        private bool checkPassword()
        {
            var passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            // Kiểm tra rổng
            if (string.IsNullOrWhiteSpace(txbPassword.Text) || txbPassword.Text == "Password")
            {
                errorProviderPassword.SetError(txbPassword, "Please enter password");
                return false;
            }
            else if (txbPassword.Text.Length < 5)
            {
                errorProviderPassword.SetError(txbPassword, "Password must be at least 5 characters long");
                return false;
            }
            else if (txbPassword.Text.Length > 20)
            {
                errorProviderPassword.SetError(txbPassword, "Password must be less than 20 characters long");
                return false;
            }
            // Kiểm tra định dạng
            if (!Regex.IsMatch(txbPassword.Text, passwordPattern))
            {
                errorProviderPassword.SetError(txbPassword, "Password must contain uppercase, lowercase, numbers and special characters");
                return false;
            }
            else
            {
                errorProviderPassword.SetError(txbPassword, string.Empty);
                return true;
            }
        }
        private bool checkConfirmPassword()
        {
            // Kiểm tra rổng
            if (string.IsNullOrWhiteSpace(txbConfirmPassword.Text) || txbConfirmPassword.Text == "Confirm Password")
            {
                errorProviderConfirmPassword.SetError(txbConfirmPassword, "Please confirm password");
                return false;
            }
            // Kiểm tra định dạng
            if (!txbConfirmPassword.Text.Equals(txbPassword.Text))
            {
                errorProviderConfirmPassword.SetError(txbConfirmPassword, "Password confirm incorrect");
                return false;
            }
            else
            {
                errorProviderConfirmPassword.SetError(txbConfirmPassword, string.Empty);
                return true;
            }
        }

        private void txbEmail_Click(object sender, EventArgs e)
        {
            if (txbEmail.Text == "Email")
            {
                txbEmail.Text = string.Empty;
                txbEmail.ForeColor = Color.Black;
            }
        }

        private void txbEmail_Leave(object sender, EventArgs e)
        {
            if (txbEmail.Text == string.Empty)
            {
                txbEmail.Text = "Email";
                txbEmail.ForeColor = Color.DarkGray;
            }
        }
        private void txbUsername_Click(object sender, EventArgs e)
        {
            if (txbUsername.Text == "Username")
            {
                txbUsername.Text = string.Empty;
                txbUsername.ForeColor = Color.Black;
            }
        }

        private void txbUsername_Leave(object sender, EventArgs e)
        {
            if (txbUsername.Text == string.Empty)
            {
                txbUsername.Text = "Username";
                txbUsername.ForeColor = Color.DarkGray;
            }
        }

        private void txbPassword_Click(object sender, EventArgs e)
        {
            if (txbPassword.Text == "Password")
            {
                txbPassword.Text = string.Empty;
                closeEye(picEyeOfPass);
                txbPassword.ForeColor = Color.Black;
            }
        }

        private void txbPassword_Leave(object sender, EventArgs e)
        {
            if (txbPassword.Text == string.Empty)
            {
                txbPassword.Text = "Password";
                txbPassword.PasswordChar = '\0';
                isEyeForPassClose = true;
                this.picEyeOfPass.Image = null;
                txbPassword.ForeColor = Color.DarkGray;
            }
            if (txbPassword.Text.Equals("Password"))
            {
                txbPassword.PasswordChar = '•';
            }
            if (picEyeOfPass.Image == null)
            {
                txbPassword.PasswordChar = '\0';
            }
        }

        private void txbConfirmPassword_Click(object sender, EventArgs e)
        {
            if (txbConfirmPassword.Text == "Confirm Password")
            {
                txbConfirmPassword.Text = string.Empty;
                closeEye(picEyeOfConfirm);
                txbConfirmPassword.ForeColor = Color.Black;
            }
        }

        private void txbConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txbConfirmPassword.Text == string.Empty)
            {
                txbConfirmPassword.Text = "Confirm Password";
                txbConfirmPassword.PasswordChar = '\0';
                isEyeForConfirmClose = true;
                this.picEyeOfConfirm.Image = null;
                txbPassword.ForeColor = Color.DarkGray;
            }
            if (txbConfirmPassword.Text.Equals("Confirm Password"))
            {
                txbConfirmPassword.PasswordChar = '•';
            }
            if (picEyeOfConfirm.Image == null)
            {
                txbConfirmPassword.PasswordChar = '\0';
            }
        }

        private void txbConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void picEyeOfPass_Click(object sender, EventArgs e)
        {
            openEyeFor(picEyeOfPass);
        }
        void closeEye(PictureBox pic)
        {
            try
            {
                pic.Image = global::App_Library.Properties.Resources.view;
                if (pic.Name.Contains("C"))
                {
                    // Confirm
                    isEyeForConfirmClose = true;
                    txbConfirmPassword.PasswordChar = '•';
                    picEyeOfConfirm.Click += new EventHandler(this.picEyeOfConfirm_Click);
                }
                else
                {
                    isEyeForPassClose = true;
                    txbPassword.PasswordChar = '•';
                    picEyeOfPass.Click += new EventHandler(this.picEyeOfPass_Click);
                }

            }
            catch (Exception ex)
            {
            }

        }
        void openEyeFor( PictureBox pic )
        {
            try
            {
                pic.Image = global::App_Library.Properties.Resources.close_eye; 
                if(pic.Name.Contains("Confirm"))
                {
                    // Confirm
                    isEyeForConfirmClose = false;
                    txbConfirmPassword.PasswordChar = '\0';
                    timerOpenEyeForConfirm.Start();
                    picEyeOfConfirm.Click -= new EventHandler(this.picEyeOfConfirm_Click);
                }
                else
                {
                    isEyeForPassClose = false;
                    txbPassword.PasswordChar = '\0';
                    timerOpenEyeForPassWord.Start();
                    picEyeOfPass.Click -= new EventHandler(this.picEyeOfPass_Click);
                }
                
            }
            catch (Exception ex)
            {
            }

        }
        private void picEyeOfConfirm_Click(object sender, EventArgs e)
        {
            openEyeFor(picEyeOfConfirm);
        }

        private void timerOpenEyeForPassWord_Tick(object sender, EventArgs e)
        {
            if (second > 0)
            {
                second--;
            }
            else
            {
                second = 2;
                timerOpenEyeForPassWord.Stop();
                closeEye(picEyeOfPass);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (second > 0)
            {
                second--;
            }
            else
            {
                second = 2;
                timerOpenEyeForConfirm.Stop();
                closeEye(picEyeOfConfirm);
            }
        }
    }
}

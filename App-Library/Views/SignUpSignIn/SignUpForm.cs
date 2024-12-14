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
using Guna.UI2.WinForms;
using MongoDB.Driver.Linq;
using Org.BouncyCastle.Asn1.Ocsp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace App_Library.Views
{
    public partial class SignUpForm : Views.ToolerForm.FormHelper
    {
        private SplashForm _splashForm;
        private readonly AuthService _authService;
        private  int xPicGG;
        bool isEyeForPassClose = true;
        bool isEyeForConfirmClose = true;
        int second = 2;
        public SignUpForm(SplashForm splashForm)
        {
            InitializeComponent();
            _splashForm = splashForm;
            _authService = new AuthService();
            xPicGG = picGG.Location.X;
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
            List<TextBox> listCotrol = new List<TextBox>();
            listCotrol.Add(txbEmail);
            listCotrol.Add(txbUsername);
            listCotrol.Add(txbPassword);
            listCotrol.Add(txbConfirmPassword);
            Dictionary<Control, bool> checkValid = new Dictionary<Control, bool>();
            Dictionary<Control, Guna2Button> messegeError = new Dictionary<Control, Guna2Button>();
            foreach (TextBox item in listCotrol)
            {
                checkValid[item] = true;
                switch (item.Name)
                {
                    case "txbEmail":
                        {
                            messegeError.Add(item, MessegeEmail);
                            break;
                        }
                    case "txbUsername":
                        {
                            messegeError.Add(item, MessegeUsername);
                            break;
                        }
                    case "txbPassword":
                        {
                            messegeError.Add(item, MessegePassword);
                            break;
                        }
                    case "txbConfirmPassword":
                        {
                            messegeError.Add(item, MessegeConfirm);
                            break;
                        }
                }
                messegeError[item].Text = "";
            }
            bool check = true;
            MessegeEmail.Visible = !checkEmail(checkValid[txbEmail], messegeError[txbEmail]);
            MessegeUsername.Visible = !checkUsername(checkValid[txbUsername], messegeError[txbUsername]);
            MessegePassword.Visible = !checkPassword(checkValid[txbPassword], messegeError[txbPassword]);
            MessegeConfirm.Visible = !checkConfirmPassword(checkValid[txbConfirmPassword], messegeError[txbConfirmPassword]);
            
            listCotrol.ForEach(x => check = (check && !checkValid[x]) ? false : true);
            MessageBox.Show(check +"");
            if (check)
            {
                
                var result = await _authService.SignUpAsync(txbUsername.Text, txbEmail.Text, txbPassword.Text);
                if (result.Equals("Success"))
                {

                    _splashForm.OpentLogin();
                }
                else if (result.Equals("Username already exists"))
                {
                    messegeError[txbUsername].Text = result;
                }
                else if (result.Equals("Email already exists"))
                {
                    messegeError[txbEmail].Text = result;
                }
            }
            else
            {
                listCotrol.ForEach(x =>
                {
                    if (!checkValid[x])
                    {
                        Guna2Panel pn = FindControlContainer(this.Controls, x) as Guna2Panel;
                        pn.BorderColor = Color.Red;

                    }
                });

            }
        }
        private async void btnSignInGG_Click(object sender, EventArgs e)
        {
            var googleLoginForm = new GoogleLoginForm();
            bool checkLoginSuccess = await googleLoginForm.GoogleSignInAndSaveUserAsync(_splashForm);
            if (checkLoginSuccess)
            {
                Program.checkLoginGG = true;
                _splashForm.OpenMainForm();
            }
        }
       
        private bool checkEmail(bool checkValid, Guna2Button messege)
        {
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            // Kiểm tra rổng
            if (string.IsNullOrWhiteSpace(txbEmail.Text) || txbEmail.Text == "Email")
            {
                messege.Text = "Please enter email";

                checkValid = false;
                return checkValid;
            }
            // Kiểm tra định dạng
            if (!Regex.IsMatch(txbEmail.Text, emailPattern))
            {

                messege.Text = "Email format incorrect";
                checkValid = false;
                return checkValid;
            }
            else
            {

                messege.Text = "";
                checkValid = true;
                return checkValid;
            }
        }
        private bool checkUsername(bool checkValid, Guna2Button messege)
        {
            var namePattern = @"^[a-zA-Z0-9\s]+$";
            // Kiểm tra rổng
            if (string.IsNullOrWhiteSpace(txbUsername.Text) || txbUsername.Text == "Username")
            {

                messege.Text = "Please enter username";
                checkValid = false;
                return checkValid;
            }
            else if (txbUsername.Text.Length < 3)
            {

                messege.Text = "Username must be at least 3 characters long";
                checkValid = false;
                return checkValid;
            }
            else if (txbUsername.Text.Length > 20)
            {

                messege.Text = "Username must be less than 20 characters long";
                checkValid = false;
                return checkValid;
            }
            // Kiểm tra định dạng
            if (!Regex.IsMatch(txbUsername.Text, namePattern))
            {

                messege.Text = "Username must contain only letters, numbers and spaces, no special characters";
                checkValid = false;
                return checkValid;
            }
            else
            {

                messege.Text = "";
                checkValid = true;
                return checkValid;
            }
        }
        private bool checkPassword(bool checkValid, Guna2Button messege)
        {
            var passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            // Kiểm tra rổng
            if (string.IsNullOrWhiteSpace(txbPassword.Text) || txbPassword.Text == "Password")
            {
                messege.Text = "Please enter password";
                checkValid = false;
                return checkValid;
            }
            else if (txbPassword.Text.Length < 5)
            {
                messege.Text = "Password must be at least 5 characters long";
                checkValid = false;
                return checkValid;
            }
            else if (txbPassword.Text.Length > 20)
            {
                messege.Text = "Password must be less than 20 characters long";
                checkValid = false;
                return checkValid;
            }
            // Kiểm tra định dạng
            if (!Regex.IsMatch(txbPassword.Text, passwordPattern))
            {
                messege.Text = "Password must contain uppercase, lowercase, numbers and special characters";
                checkValid = false;
                return checkValid;
            }
            else
            {
                messege.Text = "";
                checkValid = true;
                return checkValid;
            }
        }
        private bool checkConfirmPassword(bool checkValid, Guna2Button messege)
        {
            // Kiểm tra rổng
            if (string.IsNullOrWhiteSpace(txbConfirmPassword.Text) || txbConfirmPassword.Text == "Confirm Password")
            {
                messege.Text = "Please confirm password";
                checkValid = false;
                return checkValid;
            }
            // Kiểm tra định dạng
            if (!txbConfirmPassword.Text.Equals(txbPassword.Text))
            {
                messege.Text = "Password confirm incorrect";
                checkValid = false;
                return checkValid;
            }
            else
            {
                messege.Text = "";
                checkValid = true;
                return checkValid;
            }
        }

        private void txbEmail_Click(object sender, EventArgs e)
        {
            if (txbEmail.Text == "Email")
            {
                txbEmail.Text = string.Empty;
                txbEmail.ForeColor = Color.Aqua;
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
                txbUsername.ForeColor = Color.Aqua;
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
                txbPassword.ForeColor = Color.Aqua;
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
                txbConfirmPassword.ForeColor = Color.Aqua;
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
                pic.Image = global::App_Library.Properties.Resources.eye_slash;
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
        void openEyeFor(PictureBox pic)
        {
            try
            {
                pic.Image = global::App_Library.Properties.Resources.eye;
                if (pic.Name.Contains("Confirm"))
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
        private void lbGG_MouseHover(object sender, EventArgs e)
        {
            lbGG.Text = "";
            timerHoverGg.Start();
        }

        private void timerHoverGg_Tick(object sender, EventArgs e)
        {
            if (picGG.Location.X < lbGG.Width / 2)
            {
                picGG.Location = new Point(picGG.Location.X + 5, lbGG.Location.Y);
            }
            else
            {
                timerHoverGg.Stop();
            }
        }
        private void lbGG_MouseLeave(object sender, EventArgs e)
        {
            timerHoverGg.Stop();
            timerLeaveGG.Start();
        }
        private void timerLeaveGG_Tick(object sender, EventArgs e)
        {
            if (picGG.Location.X > xPicGG)
            {
                picGG.Location = new Point(picGG.Location.X - 5, lbGG.Location.Y);
            }
            else
            {
                lbGG.Text = "Continue with Google";
                timerLeaveGG.Stop();
            }
        }

        private void pnMainContentLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txbEmail_MouseHover(object sender, EventArgs e)
        {
            Guna2Panel pn = sender as Guna2Panel; pn.BorderColor = Color.Aqua;
        }

        private void gnPanelEmail_MouseLeave(object sender, EventArgs e)
        {
            Guna2Panel pn = sender as Guna2Panel;
            foreach(Control txb in pn.Controls)
            {
                if(txb is TextBox)
                if(txb.Text == "" || txb .Text.Equals("Email") || txb.Text.Equals("Username") || txb.Text.Equals("Password") || txb.Text.Equals("Confirm Password"))
                {
                        pn.BorderColor = Color.DarkGray;
                    }
            }
           
        }

        private void txbEmail_MouseHover_1(object sender, EventArgs e)
        {
            Guna2Panel pn = new Guna2Panel();
            TextBox lb = sender as TextBox;
            foreach (Control control in pnMainContentLogin.Controls)
            {
                if(control is Guna2Panel)
                {
                    if (control.Name.Contains(lb.Name.Substring(3)))
                    {
                        pn = control as Guna2Panel;
                    }
                }
            }


            pn.BorderColor = Color.Aqua;
        }
       
    }
}

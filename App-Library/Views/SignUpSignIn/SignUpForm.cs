using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
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
        private int xPicGG;
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
            List<Guna2TextBox> listCotrol = new List<Guna2TextBox>();
            listCotrol.Add(txtEmail);
            listCotrol.Add(txtUsername);
            listCotrol.Add(txtPassword);
            listCotrol.Add(txtConfirm);
            Dictionary<Control, bool> checkValid = new Dictionary<Control, bool>();
            Dictionary<Control, Guna2Button> messegeError = new Dictionary<Control, Guna2Button>();
            foreach (Guna2TextBox item in listCotrol)
            {
                checkValid[item] = true;
                switch (item.Name)
                {
                    case "txtEmail":
                        {
                            messegeError.Add(item, MessegeEmail);
                            break;
                        }
                    case "txtUsername":
                        {
                            messegeError.Add(item, MessegeUsername);
                            break;
                        }
                    case "txtPassword":
                        {
                            messegeError.Add(item, MessegePassword);
                            break;
                        }
                    case "txtConfirm":
                        {
                            messegeError.Add(item, MessegeConfirm);
                            break;
                        }
                }
                messegeError[item].Text = "";
            }

            checkValid[txtEmail] = checkEmail(messegeError[txtEmail]);
            checkValid[txtUsername] = checkUsername(messegeError[txtUsername]);
            checkValid[txtPassword] = checkPassword(messegeError[txtPassword]);
            checkValid[txtConfirm] = checkConfirmPassword(messegeError[txtConfirm]);

            MessegeEmail.Visible = !checkValid[txtEmail];
            MessegeUsername.Visible = !checkValid[txtUsername];
            MessegePassword.Visible = !checkValid[txtPassword];
            MessegeConfirm.Visible = !checkValid[txtConfirm];

            bool check = true;
            listCotrol.ForEach(x => check = (check && checkValid[x]));
            if (check)
            {
                var result = await _authService.SignUpAsync(txtUsername.Text, txtEmail.Text, txtPassword.Text);
                if (result.Equals("Success"))
                {
                    _splashForm.OpentLogin();
                }
                else if (result.Equals("Username already exists"))
                {
                    messegeError[txtUsername].Text = result;
                }
                else if (result.Equals("Email already exists"))
                {
                    messegeError[txtEmail].Text = result;
                }
            }
            else
            {
                listCotrol.ForEach(x =>
                {
                    if (!checkValid[x])
                    {
                        x.BorderColor = Color.Red;
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

        private bool checkEmail(Guna2Button messege)
        {
            // Kiểm tra rổng
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || txtEmail.Text == "Email")
            {
                messege.Text = "Please enter email";
                return false;
            }
            // Kiểm tra định dạng
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                messege.Text = "Email format incorrect";
                return false;
            }
            else
            {
                messege.Text = "";
                return true;
            }
        }
        private bool checkUsername(Guna2Button messege)
        {
            // Kiểm tra rổng
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || txtUsername.Text == "Username")
            {
                messege.Text = "Please enter username";
                return false;
            }
            else if (txtUsername.Text.Length < 3)
            {
                messege.Text = "Username must be at least 3 characters long";
                return false;
            }
            else if (txtUsername.Text.Length > 20)
            {
                messege.Text = "Username must be less than 20 characters long";
                return false;
            }
            // Kiểm tra định dạng
            var namePattern = @"^[a-zA-Z0-9\s]+$";
            if (!Regex.IsMatch(txtUsername.Text, namePattern))
            {
                messege.Text = "Username must contain only letters, numbers and spaces, no special characters";
                return false;
            }
            else
            {
                messege.Text = "";
                return true;
            }
        }
        private bool checkPassword(Guna2Button messege)
        {
            // Kiểm tra rổng
            if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text == "Password")
            {
                messege.Text = "Please enter password";
                return false;
            }
            else if (txtPassword.Text.Length < 5)
            {
                messege.Text = "Password must be at least 5 characters long";
                return false;
            }
            else if (txtPassword.Text.Length > 20)
            {
                messege.Text = "Password must be less than 20 characters long";
                return false;
            }
            // Kiểm tra định dạng
            var passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            if (!Regex.IsMatch(txtPassword.Text, passwordPattern))
            {
                messege.Text = "Password must contain uppercase, lowercase, numbers and special characters";
                return false;
            }
            else
            {
                messege.Text = "";
                return true;
            }
        }
        private bool checkConfirmPassword(Guna2Button messege)
        {
            // Kiểm tra rổng
            if (string.IsNullOrWhiteSpace(txtConfirm.Text) || txtConfirm.Text == "Confirm Password")
            {
                messege.Text = "Please confirm password";
                return false;
            }
            if (!txtConfirm.Text.Equals(txtPassword.Text))
            {
                messege.Text = "Password confirm incorrect";
                return false;
            }
            else
            {
                messege.Text = "";
                return true;
            }
        }
        // Sự kiện bấm vào mắt ở Password
        private void picEyeOfPass_Click(object sender, EventArgs e)
        {
            openEyeFor(picEyeOfPass);
        }
        // Sự kiện bấm vào mắt ở ConfirmPassword
        private void picEyeOfConfirm_Click(object sender, EventArgs e)
        {
            openEyeFor(picEyeOfConfirm);
        }
        // Thực hiện đóng mắt
        void closeEye(PictureBox pic)
        {
            try
            {
                pic.Image = global::App_Library.Properties.Resources.eye_slash;
                if (pic.Name.Contains("Confirm"))
                {
                    if (!(txtConfirm.Text == "Confirm Password"))
                    {
                        txtConfirm.PasswordChar = '*';
                    }
                    picEyeOfConfirm.Click += new EventHandler(this.picEyeOfConfirm_Click);
                }
                else
                {
                    if (!(txtPassword.Text == "Password"))
                    {
                        txtPassword.PasswordChar = '*';
                    }
                    picEyeOfPass.Click += new EventHandler(this.picEyeOfPass_Click);
                }
            }
            catch (Exception ex)
            {
            }
        }
        // Thực hiện mở mắt
        void openEyeFor(PictureBox pic)
        {
            try
            {
                pic.Image = global::App_Library.Properties.Resources.eye;
                if (pic.Name.Contains("Confirm"))
                {
                    txtConfirm.PasswordChar = '\0';
                    timerOpenEyeForConfirm.Start();
                    picEyeOfConfirm.Click -= new EventHandler(this.picEyeOfConfirm_Click);
                }
                else
                {
                    txtPassword.PasswordChar = '\0';
                    timerOpenEyeForPassWord.Start();
                    picEyeOfPass.Click -= new EventHandler(this.picEyeOfPass_Click);
                }
            }
            catch (Exception ex)
            {
            }
        }
        // Hiệu ứng mắt ở Password
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
        // Hiệu ứng mắt ở ConfirmPassword
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

        private void txbEmail_MouseHover(object sender, EventArgs e)
        {
            Guna2Panel pn = sender as Guna2Panel; pn.BorderColor = Color.Aqua;
        }

        private void gnPanelEmail_MouseLeave(object sender, EventArgs e)
        {
            Guna2Panel pn = sender as Guna2Panel;
            foreach (Control txb in pn.Controls)
            {
                if (txb is TextBox)
                {
                    if (txb.Text == "" || txb.Text.Equals("Email") || txb.Text.Equals("Username") || txb.Text.Equals("Password") || txb.Text.Equals("Confirm Password"))
                    {
                        pn.BorderColor = Color.DarkGray;
                    }
                }
            }
        }

        private void txtEmail_MouseLeave(object sender, EventArgs e)
        {
            txtEmail.BorderColor = Color.DarkGray;
        }

        private void txtEmail_MouseHover(object sender, EventArgs e)
        {
            txtEmail.BorderColor = Color.Blue;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == string.Empty)
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.DarkGray;
            }
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = string.Empty;
                txtEmail.ForeColor = Color.Blue;
                txtEmail.BorderColor = Color.Blue;
            }
        }
        private void txtUserName_MouseLeave(object sender, EventArgs e)
        {
            txtUsername.BorderColor = Color.DarkGray;
        }

        private void txtUsername_MouseHover(object sender, EventArgs e)
        {
            txtUsername.BorderColor = Color.Blue;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == string.Empty)
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.DarkGray;
            }
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = string.Empty;
                txtUsername.ForeColor = Color.Blue;
                txtUsername.BorderColor = Color.Blue;
            }
        }
        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.BorderColor = Color.DarkGray;
        }

        private void txtPassword_MouseHover(object sender, EventArgs e)
        {
            txtPassword.BorderColor = Color.Blue;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                txtPassword.Text = "Password";
                txtPassword.PasswordChar = '\0';
                txtPassword.ForeColor = Color.DarkGray;
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = string.Empty;
                txtPassword.ForeColor = Color.Blue;
                txtPassword.BorderColor = Color.Blue;
                txtPassword.PasswordChar = '*';
            }
        }
        private void txtConfirm_MouseLeave(object sender, EventArgs e)
        {
            txtConfirm.BorderColor = Color.DarkGray;
        }

        private void txtConfirm_MouseHover(object sender, EventArgs e)
        {
            txtConfirm.BorderColor = Color.Blue;
        }

        private void txtConfirm_Leave(object sender, EventArgs e)
        {
            if (txtConfirm.Text == string.Empty)
            {
                txtConfirm.Text = "Confirm";
                txtConfirm.PasswordChar = '\0';
                txtConfirm.ForeColor = Color.DarkGray;
            }
        }

        private void txtConfirm_Click(object sender, EventArgs e)
        {
            if (txtConfirm.Text == "Confirm")
            {
                txtConfirm.Text = string.Empty;
                txtConfirm.ForeColor = Color.Blue;
                txtConfirm.BorderColor = Color.Blue;
                txtConfirm.PasswordChar = '*';
            }
        }
    }
}

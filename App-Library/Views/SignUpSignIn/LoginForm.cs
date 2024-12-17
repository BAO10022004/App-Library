using App_Library.Models;
using App_Library.Services;
using App_Library.Views.Orthers.CollectionEditProfile;
using App_Library.Views.SignIn;
using App_Library.Views.ToolerForm;
using DnsClient.Protocol;
using Guna.UI2.WinForms;
using MongoDB.Driver;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
namespace App_Library.Views
{
    public partial class LoginForm : Views.ToolerForm.FormHelper
    {
        private SplashForm _splashForm;
        private readonly AuthService _authService;
        int second = 2;
        int xPicGG;

        public LoginForm(SplashForm splashForm)
        {
            InitializeComponent();
            _splashForm = splashForm;
            _authService = new AuthService();
            xPicGG = picGG.Location.X;
        }

        //public SplashForm getParent()
        //{
        //    return _splashForm;
        //}
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            List<TextBox> listCotrol = new List<TextBox>();
            listCotrol.Add(txbUserName);
            listCotrol.Add(txbPassword);
            Dictionary<Control, bool> checkValid = new Dictionary<Control, bool>();
            Dictionary<Control, Guna2Button> messegeError = new Dictionary<Control, Guna2Button>();
            foreach (TextBox item in listCotrol)
            {
                checkValid[item] = false;
                switch (item.Name)
                {
                    case "txbUserName":
                        {
                            messegeError.Add(item, MessegeUsername);
                            break;
                        }
                    case "txbPassword":
                        {
                            messegeError.Add(item, MessegePassword);
                            break;
                        }
                }
                messegeError[item].Text = "";
            }
            checkValid[txbUserName] = checkUsername(messegeError[txbUserName]);
            checkValid[txbPassword] = checkPassword(messegeError[txbPassword]);

            MessegeUsername.Visible = !checkValid[txbUserName];
            MessegePassword.Visible = !checkValid[txbPassword];

            bool check = true;
            listCotrol.ForEach(x => check = (check && checkValid[x]));
            if (check)
            {
                bool checkLoginSuccess = await _authService.LoginAsync(txbUserName.Text, txbPassword.Text, this);
                if (checkLoginSuccess)
                {
                    Program.checkLoginGG = false;
                    _splashForm.OpenMainForm();
                }
            }
            //else
            //{
            //    listCotrol.ForEach(x =>
            //    {
            //        if (!checkValid[x])
            //        {
            //            Guna2Panel pn = FindControlContainer(this.Controls, x) as Guna2Panel;
            //            pn.BorderColor = Color.Red;
            //        }
            //    });
            //}
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

        private bool checkUsername(Guna2Button messege)
        {
            // Kiểm tra rổng
            if (string.IsNullOrWhiteSpace(txbUserName.Text) || txbUserName.Text == "Username")
            {
                messege.Text = "Please enter username";
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
            if (string.IsNullOrWhiteSpace(txbPassword.Text) || txbPassword.Text == "Password")
            {
                messege.Text = "Please enter password";
                return false;
            }
            else
            {
                messege.Text = "";
                return true;
            }
        }

        private void lbCreateAccount_Click(object sender, EventArgs e)
        {
            _splashForm.OpentSignup();
        }

        private void txbUserName_Click(object sender, EventArgs e)
        {
            if (txbUserName.Text == "Username")
            {
                txbUserName.Text = string.Empty;
                txbUserName.ForeColor = Color.Aqua;
            }
        }

        private void txbUserName_Leave(object sender, EventArgs e)
        {
            if (txbUserName.Text == string.Empty)
            {
                txbUserName.Text = "Username";
                txbUserName.ForeColor = Color.DarkGray;
                gnPanelLogIn.BorderColor = Color.DarkGray;
            }
        }

        private void txbPassword_Click(object sender, EventArgs e)
        {
            if (txbPassword.Text == "Password")
            {
                txbPassword.Text = string.Empty;
                txbPassword.PasswordChar = '*';
                txbPassword.ForeColor = Color.Aqua;
            }
        }

        private void txbPassword_Leave(object sender, EventArgs e)
        {
            if (txbPassword.Text == string.Empty)
            {
                txbPassword.Text = "Password";
                txbPassword.PasswordChar = '\0';
                txbPassword.ForeColor = Color.DarkGray;
            }
        }
        void closeEye()
        {
            try
            {
                this.picEye.Image = global::App_Library.Properties.Resources.eye;
                if (!(txbPassword.Text == "Password"))
                {
                    txbPassword.PasswordChar = '*';
                }
                picEye.Click += new EventHandler(this.picEye_Click);
            }
            catch (Exception e)
            {
            }
        }

        private void picEye_Click(object sender, EventArgs e)
        {
            try
            {
                this.picEye.Image = global::App_Library.Properties.Resources.eye_slash;
                txbPassword.PasswordChar = '\0';
                timerEyeOpen.Start();
                picEye.Click -= new EventHandler(this.picEye_Click);
            }
            catch (Exception ex)
            {
            }
        }

        private void timerEyeOpen_Tick(object sender, EventArgs e)
        {
            if (second > 0)
            {
                second--;
            }
            else
            {
                second = 2;
                timerEyeOpen.Stop();
                closeEye();
            }
        }

        private void lbGG_MouseHover(object sender, EventArgs e)
        {
            lbGG.Text = "";
            timerHoverGg.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (picGG.Location.X < lbGG.Width / 2)
            {
                picGG.Location = new Point(picGG.Location.X + 5, lbGG.Location.Y);
            }
            else
            {
                lbGG.Text = "";
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

        private void txbUserName_MouseHover(object sender, EventArgs e)
        {
            gnPanelLogIn.BorderColor = Color.Aqua;
        }

        private void gnPanelLogIn_MouseLeave(object sender, EventArgs e)
        {
            if (txbUserName.Text.Equals("User Name") || txbUserName.Text.Equals(""))
            {
                gnPanelLogIn.BorderColor = Color.DarkGray;
            }
        }

        private void txbPassword_MouseHover(object sender, EventArgs e)
        {
            gnPanelPassword.BorderColor = Color.Aqua;
        }

        private void txbPassword_MouseLeave(object sender, EventArgs e)
        {
            if (txbPassword.Text.Equals("Password") || txbPassword.Text.Equals(""))
            {
                gnPanelPassword.BorderColor = Color.DarkGray;
            }
        }
        // Bấm quên password
        private void lbForgotPassword_Click(object sender, EventArgs e)
        {
            (new ChangePasswordForm(null)).ShowDialog();
        }

        private void lbCreateAccount_MouseHover(object sender, EventArgs e)
        {
            Label lb = sender as Label;
            lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
        }

        private void lbCreateAccount_MouseLeave(object sender, EventArgs e)
        {
            Label lb = sender as Label;
            lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
        }

        private void lbForgotPassword_MouseHover(object sender, EventArgs e)
        {
            Label lb = sender as Label;
            lb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void lbForgotPassword_MouseLeave(object sender, EventArgs e)
        {
            Label lb = sender as Label;
            lb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
    }
}

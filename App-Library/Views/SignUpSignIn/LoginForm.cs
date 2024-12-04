using App_Library.Models;
using App_Library.Services;
using App_Library.Views.SignIn;
using App_Library.Views.ToolerForm;
using DnsClient.Protocol;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
// $2a$10$eITLrNBDrQ5zvpaAToD2GO20B5hYEzKY2gtvvpirHIeJiXUECnAf2
namespace App_Library.Views
{
    public partial class LoginForm : Views.ToolerForm.FormHelper
    {
        private SplashForm _splashForm;
        private readonly AuthService _authService;
        internal MainForm mainform;
        bool isEyeClose = true;
        int second =2;
        public LoginForm(SplashForm splashForm)
        {
            InitializeComponent();
            _splashForm = splashForm;
            _authService = new AuthService();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }
        public SplashForm  getParent()
        {
            return _splashForm;
        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            bool checkLoginSuccess = await _authService.LoginAsync(txbUserName.Text, txbPassword.Text);
            if (checkLoginSuccess)
            {
                (new AlertSuccess(this)).ShowDialog();
            }
            else
            {
                (new AlertFail()).ShowDialog();
            }
        }
        private async void btnSignInGG_Click(object sender, EventArgs e)
        {
            var googleLoginForm = new GoogleLoginForm();
            bool checkLoginSuccess = await googleLoginForm.GoogleSignInAndSaveUserAsync();
            if (checkLoginSuccess)
            {
                (new AlertSuccess(this)).ShowDialog();
            }else
            {
                (new AlertFail()).ShowDialog();
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
                txbUserName.ForeColor = Color.Black;
            }
        }

        private void txbUserName_Leave(object sender, EventArgs e)
        {
            if (txbUserName.Text == string.Empty)
            {
                txbUserName.Text = "Username";
                txbUserName.ForeColor = Color.DarkGray;
            }
            if (txbUserName.Text.Equals("User Name") || txbUserName.Text.Equals(""))
            {
                gnPanelLogIn.BorderColor = Color.DarkGray;
            }
        }

        private void txbPassword_Click(object sender, EventArgs e)
        {
            if (txbPassword.Text == "Password")
            {
                txbPassword.Text = string.Empty;
                closeEye();
                txbPassword.ForeColor = Color.Black;
            }
        }

        private void txbPassword_Leave(object sender, EventArgs e)
        {
                      
            if (txbPassword.Text == string.Empty)
            {
                txbPassword.Text = "Password";
                txbPassword.PasswordChar = '\0';
                isEyeClose = true;
                this.picEye.Image = null;
                txbPassword.ForeColor = Color.DarkGray;
            }
            if(txbPassword.Text.Equals("Password"))
            {
                txbPassword.PasswordChar= '•';
            }
            if(picEye.Image == null)
            {
                txbPassword.PasswordChar = '\0';
            }
           
        }
        void closeEye()
        {
            try
            {
                isEyeClose = true;
                this.picEye.Image = global::App_Library.Properties.Resources.view;
                txbPassword.PasswordChar = '•';

                picEye.Click += new EventHandler(this.picEye_Click);
            }
            catch (Exception e)
            {

            }
            
        }
        void openEye()
        {
            try
            {
                isEyeClose = false;
                this.picEye.Image = global::App_Library.Properties.Resources.close_eye;
                txbPassword.PasswordChar = '\0';
                timerEyeOpen.Start();
                picEye.Click -= new EventHandler(this.picEye_Click);
            }
            catch (Exception ex)
            {
            }
            
        }
        private void txbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void picEye_Click(object sender, EventArgs e)
        {     
            openEye();
        }

        private void txbPassword_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           
        }

        private void pnMainContentLogin_Click(object sender, EventArgs e)
        {

        }

        private void txbPassword_KeyDown_1(object sender, KeyEventArgs e)
        {
            
        }

        private void timerEyeOpen_Tick(object sender, EventArgs e)
        {
            if (second > 0)
            {
                second--;
            }
            else
            {
                second =2;
                timerEyeOpen.Stop();
                closeEye();
            }
        }

        private void txbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void lbGG_MouseHover(object sender, EventArgs e)
        {
            btnSignInGG.FillColor = Color.Blue;
            lbGG.ForeColor = Color.White;
            lbGG.BackColor = Color.Blue;
        }

        private void lbGG_MouseLeave(object sender, EventArgs e)
        {
            btnSignInGG.FillColor = Color.White;
            lbGG.ForeColor = Color.Black;
            lbGG.BackColor = Color.White;
        }

        private void gnPanelLogIn_MouseHover(object sender, EventArgs e)
        {
            gnPanelLogIn.BorderColor = Color.Blue;
            //if(txbUserName.Text.Equals("User Name") || txbUserName.Text.Equals(""))
            //{

            //}
        }

        private void txbUserName_MouseHover(object sender, EventArgs e)
        {
            gnPanelLogIn.BorderColor = Color.Blue;
        }

        private void gnPanelLogIn_MouseLeave(object sender, EventArgs e)
        {
            if (txbUserName.Text.Equals("User Name") || txbUserName.Text.Equals(""))
            {
                gnPanelLogIn.BorderColor = Color.DarkGray;
            }
        }

        private void gnPanelPassword_MouseHover(object sender, EventArgs e)
        {
            gnPanelPassword.BorderColor = Color.Blue;
        }

        private void txbPassword_MouseHover(object sender, EventArgs e)
        {
            gnPanelPassword.BorderColor = Color.Blue;
        }

        private void gnPanelPassword_MouseLeave(object sender, EventArgs e)
        {
            if (txbPassword.Text.Equals("Password") || txbPassword.Text.Equals(""))
            {
                gnPanelPassword.BorderColor = Color.DarkGray;
            }
        }

        private void txbPassword_MouseLeave(object sender, EventArgs e)
        {
            if (txbPassword.Text.Equals("Password") || txbPassword.Text.Equals(""))
            {
                gnPanelPassword.BorderColor = Color.DarkGray;
            }
        }

        private async void lbForgotPassword_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            sendMail((await userService.GetCurrentUserAsync()).PasswordHash, (await userService.GetCurrentUserAsync()).Email);
            MessageBox.Show("Password sended to your mail");
        }
    }
}

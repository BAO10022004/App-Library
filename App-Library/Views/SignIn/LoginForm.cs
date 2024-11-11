using App_Library.Models;
using App_Library.Services;
using App_Library.Views.SignIn;
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
        public LoginForm(SplashForm splashForm)
        {
            InitializeComponent();
            _splashForm = splashForm;
            _authService = new AuthService();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            bool checkLoginSuccess = await _authService.LoginAsync(txbUserName.Text, txbPassword.Text);
            if (checkLoginSuccess)
            {
                MessageBox.Show("Success");
                _splashForm.OpenMainForm();
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
        }

        private void txbPassword_Click(object sender, EventArgs e)
        {
            if (txbPassword.Text == "Password")
            {
                txbPassword.Text = string.Empty;
                txbPassword.PasswordChar = '*';
                txbPassword.ForeColor = Color.Black;
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


    }
}

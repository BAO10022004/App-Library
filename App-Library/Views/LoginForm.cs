using App_Library.Services;
using App_Library.Services.Interfaces;
using DnsClient.Protocol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library.Views
{
    public partial class LoginForm : Form
    {
        private readonly MongoDbContext _context;
        private readonly IAuthService _authService;
        public LoginForm(MongoDbContext context)
        {
            _context = context;
            _authService = new AuthService(_context);
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void timerClickButonLogin_Tick(object sender, EventArgs e)
        {

        }
        private async void btnLogin_Click_1(object sender, EventArgs e)
        {
            await _authService.LoginAsync(txbEmail.Text, txbPassword.Text);
            // Chuyển hướng hoặc hiển thị màn hình chính của ứng dụng
            this.Hide();
            MainForm mainForm = new MainForm(_context);
            mainForm.Show();
        }
    }
}

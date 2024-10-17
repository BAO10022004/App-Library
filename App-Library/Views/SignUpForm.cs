using App_Library.Services.Interfaces;
using App_Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_Library.Models;
using Org.BouncyCastle.Asn1.Ocsp;

namespace App_Library.Views
{
    public partial class SignUpForm : Form
    {
        private readonly MongoDbContext _context;
        private readonly IAuthService _authService;
        public SignUpForm(MongoDbContext context)
        {
            _context = context;
            _authService = new AuthService(context);
            InitializeComponent();
        }
        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }
        private void pnMainContentLogin_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var signUp = new SignUpRequest
            {
                Email = txbEmail.Text,
                Username = txbName.Text,
                Password = txbPassword.Text
            };
            _authService.SignUpAsyn(signUp);
        }
    }
}

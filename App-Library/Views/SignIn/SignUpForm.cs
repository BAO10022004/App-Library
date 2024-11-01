using App_Library.APIService;
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
        private readonly AuthService _authService;
        public SignUpForm()
        {
            _authService = new AuthService();
            InitializeComponent();
        }
        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var checkSignUpSuccess = await _authService.SignUpAsync(txbName.Text, txbEmail.Text, txbPassword.Text);
            if (checkSignUpSuccess)
            {
                MessageBox.Show("Signup successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

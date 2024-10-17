using App_Library.Services;
using App_Library.Services.Interfaces;
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
    public partial class SplashForm : Form
    {
        LoginForm loginForm;
        SignUpForm signUpForm;
        private readonly MongoDbContext _context;
        private readonly IAuthService _authService;
        public SplashForm(MongoDbContext context)
        {
            _context = context;
            _authService = new AuthService(_context);
            InitializeComponent();
        }
        Form ActForm;
        public void activeFormChild(Form form, object obj)
        {
            if (ActForm != null)
            {
                ActForm.Close();
            }
            ActForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.pnLogInContent.Controls.Add(form);
            this.pnLogInContent.Tag = form;
            form.BringToFront();
            form.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void timerClickButonLogin_Tick(object sender, EventArgs e)
        {
            if (lbWellcome.Location.Y > 10)
            {
                lbWellcome.Location = new Point(lbWellcome.Location.X, lbWellcome.Location.Y - 210 / 37);
                pnFrameOption.Location = new Point(pnFrameOption.Location.X, pnFrameOption.Location.Y - (2 * 250 / 37));

                btnSignUp.Location = new Point(btnSignUp.Location.X, btnSignUp.Location.Y - 100 / 37);
            }
            else
            {
                btnSignUp.Location = new Point(120, 14);
                pnFrameOption.Controls.Remove(button1);
                pnLogInContent.Location = new Point(0, 119);
                lbWellcome.Location = new Point(lbWellcome.Location.X + 60, lbWellcome.Location.Y);
                timerClickButonLogin.Stop();
                lbWellcome.Text = "SIGN - IN ";
                loginForm = new LoginForm(_context);
                activeFormChild(loginForm, sender);
                return;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Y = lbWellcome.Location.Y;
            if (loginForm == null)
            {
                timerClickButonLogin.Start();
            }
            else
            {
                timerClickButonLogin2.Start();
            }

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left) // Chỉ di chuyển khi chuột trái được nhấn
            {
                this.Location = new Point(this.Location.X + e.X, this.Location.Y + e.Y);
            }
        }

        private void pnSubLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pnFrameOption_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnLogInContent_Paint(object sender, PaintEventArgs e)
        {

        }
        int Y;
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Y = lbWellcome.Location.Y;
            if (loginForm == null)
            {

            }
            else
            {
                timerSignUp.Start();
            }

        }

        private void lbWellcome_Click(object sender, EventArgs e)
        {

        }

        private void timerSignUp_Tick(object sender, EventArgs e)
        {
            if (lbWellcome.Location.Y < 50)
            {
                lbWellcome.Location = new Point(lbWellcome.Location.X, lbWellcome.Location.Y + 210 / 37);
                btnSignUp.Location = new Point(btnSignUp.Location.X, btnSignUp.Location.Y - 100 / 37);
            }
            else
            {
                lbWellcome.Location = new Point(lbWellcome.Location.X, Y);
                lbWellcome.Text = "SIGN - UP ";
                pnFrameOption.Controls.Remove(btnSignUp);
                button1.Location = new Point(120, 14);
                pnFrameOption.Controls.Add(button1);
                signUpForm = new SignUpForm();
                signUpForm.ShowDialog();
                activeFormChild(signUpForm, sender);
                timerSignUp.Stop();
                return;

            }
        }

        private void timerClickButonLogin2_Tick(object sender, EventArgs e)
        {
            if (lbWellcome.Location.Y < 50)
            {
                lbWellcome.Location = new Point(lbWellcome.Location.X, lbWellcome.Location.Y + 210 / 37);
                button1.Location = new Point(btnSignUp.Location.X, btnSignUp.Location.Y - 100 / 37);
            }
            else
            {
                lbWellcome.Location = new Point(lbWellcome.Location.X, Y);
                lbWellcome.Text = "SIGN - IN ";
                pnFrameOption.Controls.Remove(button1);
                btnSignUp.Location = new Point(120, 14);
                pnFrameOption.Controls.Add(btnSignUp);
                loginForm = new LoginForm(_context);
                activeFormChild(loginForm, sender);
                timerClickButonLogin2.Stop();
                return;

            }
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
        }
    }
}

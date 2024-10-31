//using App_Library.Services;
//using App_Library.Services.Interfaces;
//using App_Library.APIService;
using App_Library.Views.ToolerForm;
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
    public partial class SplashForm : Views.ToolerForm.FormHelper
    {
        internal LoginForm loginForm;
        internal SignUpForm signUpForm;
        Point pointLbWelcome;

        //internal readonly MongoDbContext _context;
        //internal readonly AuthService _authService;
        //Check Login dang duoc mo chua????
        bool checkOpenLogin = false;
        //Check sign-up dang duoc mo chua????
        bool checkOpenSignUp = false;
        //Check page nao dang duoc hien
        bool checkPageLogin = false;
        public SplashForm()
        {
            //_context = context;
            //_context = context;
            //_authService = new AuthService();

            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            pointLbWelcome = new Point((this.Size.Width - lbWellcome.Size.Width) / 2, 0);
        }

        // Nút thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left) // Chỉ di chuyển khi chuột trái được nhấn
            {
                this.Location = new Point(this.Location.X + e.X, this.Location.Y + e.Y);
            }
        }

        int Y;
        Button btnSaveButtonRemove;
        // Bấm Sign Up
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (loginForm == null && signUpForm == null)
            {
                loginForm = new LoginForm();
                signUpForm = new SignUpForm();
                timerSignUp.Start();
                checkOpenLogin = true;
                checkPageLogin = false;
            }
            else
            {
                signUpForm = new SignUpForm();
                timer2SignUp.Start();
                checkOpenSignUp = true;
                checkPageLogin = false;
            }
        }

        // Bấm Sign In
        private void button1_Click(object sender, EventArgs e)
        {
            Y = lbWellcome.Location.Y;

            if (loginForm == null && signUpForm == null)
            {
                loginForm = new LoginForm();
                signUpForm = new SignUpForm();
                timerClickButonLogin.Start();
                checkOpenLogin = true;
                checkPageLogin = true;
            }
            else
            {
                if (!checkPageLogin && checkOpenLogin == true)
                {
                    loginForm = new LoginForm();
                    timerClickButonLogin2.Start();
                    checkOpenLogin = true;
                    checkPageLogin = true;
                }
            }
        }

        // Timer chạy khi bấm Sign Up lần đầu
        private void timerSignUp_Tick(object sender, EventArgs e)
        {
            if (lbWellcome.Location.Y > 10)
            {
                lbWellcome.Location = new Point(lbWellcome.Location.X, lbWellcome.Location.Y - 410 / 37);
                pnFrameOption.Location = new Point(pnFrameOption.Location.X, pnFrameOption.Location.Y - (2 * 550 / 37));
                btnSignUp.Location = new Point(btnSignUp.Location.X, btnSignUp.Location.Y - 100 / 37);
            }
            else
            {
                timerSignUp.Stop();
                pnLogInContent.Location = new Point(0, 119);
                lbWellcome.Location = pointLbWelcome;
                lbWellcome.Text = "SIGN - UP ";
                pnFrameOption.Controls.Remove(btnSignUp);
                button1.Location = new Point(120, 14);
                pnFrameOption.Controls.Add(button1);
                this.activeFormChild(this.pnLogInContent, signUpForm, sender);
                return;
            }
        }

        // Timer chạy khi bấm Sign Up lần 2
        private void timerSignUp2_Tick(object sender, EventArgs e)
        {
            if (lbWellcome.Location.Y < 50)
            {
                lbWellcome.Location = new Point(lbWellcome.Location.X, lbWellcome.Location.Y + 210 / 37);
                btnSignUp.Location = new Point(btnSignUp.Location.X, btnSignUp.Location.Y - 100 / 37);
            }
            else
            {
                timer2SignUp.Stop();
                btnSignUp.Location = new Point(120, 14);
                pnFrameOption.Controls.Remove(btnSignUp);
                pnFrameOption.Controls.Add(button1);
                pnLogInContent.Location = new Point(0, 119);
                lbWellcome.Location = pointLbWelcome;

                lbWellcome.Text = "SIGN - UP";
                this.activeFormChild(this.pnLogInContent, signUpForm, sender);
                return;
            }
        }

        // Timer chạy khi bấm Sign In lần đầu
        private void timerClickButonLogin_Tick(object sender, EventArgs e)
        {
            if (lbWellcome.Location.Y > 10)
            {
                lbWellcome.Location = new Point(lbWellcome.Location.X, lbWellcome.Location.Y - 410 / 37);
                pnFrameOption.Location = new Point(pnFrameOption.Location.X, pnFrameOption.Location.Y - (2 * 550 / 37));
                btnSignUp.Location = new Point(btnSignUp.Location.X, btnSignUp.Location.Y - 100 / 37);
            }
            else
            {
                timerClickButonLogin.Stop();
                btnSignUp.Location = new Point(120, 14);
                btnSaveButtonRemove = new Button();
                pnFrameOption.Controls.Remove(button1);
                pnLogInContent.Location = new Point(0, 119);
                lbWellcome.Location = pointLbWelcome;
                lbWellcome.Text = "SIGN - IN ";
                this.activeFormChild(this.pnLogInContent, loginForm, sender);
                return;
            }
        }

        // Timer chạy khi bấm Sign In lần 2
        private void timerClickButonLogin2_Tick(object sender, EventArgs e)
        {
            if (lbWellcome.Location.Y < 50)
            {
                lbWellcome.Location = new Point(lbWellcome.Location.X, lbWellcome.Location.Y + 210 / 37);
                btnSignUp.Location = new Point(btnSignUp.Location.X, btnSignUp.Location.Y - 100 / 37);
            }
            else
            {
                timerClickButonLogin2.Stop();
                btnSignUp.Location = new Point(120, 14);
                pnFrameOption.Controls.Remove(button1);
                pnFrameOption.Controls.Add(btnSignUp);
                pnLogInContent.Location = new Point(0, 119);
                lbWellcome.Location = pointLbWelcome;
                lbWellcome.Text = "SIGN - IN";
                this.activeFormChild(this.pnLogInContent, loginForm, sender);
                return;
            }
        }
    }
}

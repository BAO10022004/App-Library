using App_Library.Views.Main.CollectionShop;
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
        Point pointLbWelcome;

        public SplashForm()
        {
            InitializeComponent();
        }
        private void SplashForm_Load(object sender, EventArgs e)
        {
            //pointLbWelcome = new Point((this.Size.Width - lbWellcome.Size.Width) / 2, 0);
        }
        // Bấm nút thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Di chuyển cửa sổ
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left) // Chỉ di chuyển khi chuột trái được nhấn
            {
                this.Location = new Point(this.Location.X + e.X, this.Location.Y + e.Y);
            }
        }
        // Bấm nút đăng nhập
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            timerClickButonLogin.Start();
        }
        // Bấm nút đăng ký
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            timerClickButtonSignUp.Start();
        }
        private void movePanelConten()
        {
            if (lbWellcome.Location.Y > 30)
            {
                lbWellcome.Location = new Point(lbWellcome.Location.X, lbWellcome.Location.Y - ((215 - 30) / 50));
            }
            if (pnFrameOption.Location.Y > 130)
            {
                pnFrameOption.Location = new Point(pnFrameOption.Location.X, pnFrameOption.Location.Y - ((490 - 130) / 50));
            }
            if (pnLoginSignupContent.Location.Y > 0)
            {
                pnLoginSignupContent.Location = new Point(pnLoginSignupContent.Location.X, pnLoginSignupContent.Location.Y - ((260 - 0) / 50));
            }
        }
        private void timerSignUp_Tick(object sender, EventArgs e)
        {
            if (lbWellcome.Location.Y > 30 || pnFrameOption.Location.Y > 130 || pnLoginSignupContent.Location.Y > 0)
            {
                movePanelConten();
            }
            else
            {
                timerClickButtonSignUp.Stop();
                lbWellcome.Text = "SIGN - UP";
                this.activeFormChild(this.pnLoginSignupContent, new SignUpForm(this), sender);
                return;
            }
        }
        private void timerClickButonLogin_Tick(object sender, EventArgs e)
        {
            if (lbWellcome.Location.Y > 30 || pnFrameOption.Location.Y > 130 || pnLoginSignupContent.Location.Y > 0)
            {
                movePanelConten();
            }
            else
            {
                timerClickButonLogin.Stop();
                lbWellcome.Text = "SIGN - IN";
                this.activeFormChild(this.pnLoginSignupContent, new LoginForm(this), sender);
                return;
            }
        }
        private void timerOpenMainForm_Tick(object sender, EventArgs e)
        {
            if (Location.X > 0)
            {
                int y = Location.Y - 5;
                Location = new Point((550 / 62 * y), y);
            }
            else
            {
                timerOpenMainForm.Stop();
                WindowState = FormWindowState.Maximized;
                PnSubLogin.Controls.Clear();
                Location = new Point(0, 0);
                BtnExit.Location = new Point(1540 - 35, 1);
                this.activeFormChild(this.PnSubLogin, new MainForm(), sender);
            }
            if (Size.Height < 1080 && Size.Width < 1920)
            {
                Size = new Size(Size.Width + 150, Size.Height + 30);
            }
        }
        // Mở Form LogIn
        public void OpentLogin()
        {
            lbWellcome.Text = "SIGN - IN";
            this.activeFormChild(this.pnLoginSignupContent, new LoginForm(this));
        }
        // Mở Form SignUp
        public void OpentSignup()
        {
            lbWellcome.Text = "SIGN - UP";
            this.activeFormChild(this.pnLoginSignupContent, new SignUpForm(this));
        }
        // Mở Form chính
        public void OpenMainForm()
        {
            timerOpenMainForm.Start();
        }
    }
}

using App_Library.Views.Main.CollectionShop;
using App_Library.Views.ToolerForm;
using Guna.UI2.WinForms;
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
        Theme theme;
        public SplashForm()
        {
            InitializeComponent();
            theme = new Theme();
            theme.BackRound.Add(this,this.pnFrameOption.BackColor);
            pnFrameOption.BackColor = theme.BackRound[this];
            lbWellcome.ForeColor = theme.BackRound[this];
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            Guna2AnimateWindow gunaAnimateWindow = new Guna2AnimateWindow();

            // Áp dụng hiệu ứng "Blend" (fade-in) khi mở cửa sổ
            gunaAnimateWindow.SetAnimateWindow(this, Guna2AnimateWindow.AnimateWindowType.AW_CENTER, 500);
        }
        // Bấm nút thoát
        //private void btnExit_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}
        // Di chuyển cửa sổ
        //private void panel1_MouseMove(object sender, MouseEventArgs e)
        //{

        //}
        // Bấm nút đăng nhập
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            playMusic("click.wav");
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
                lbWellcome.Location = new Point(lbWellcome.Location.X, lbWellcome.Location.Y - ((160 - 30) / 50));
            }
            if (pnFrameOption.Location.Y > 125)
            {
                pnFrameOption.Location = new Point(pnFrameOption.Location.X, pnFrameOption.Location.Y - ((385 - 125) / 50));
            }
            if (pnLoginSignupContent.Location.Y > 0)
            {
                pnLoginSignupContent.Location = new Point(pnLoginSignupContent.Location.X, pnLoginSignupContent.Location.Y - ((200 - 0) / 50));
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
                pnFrameOption.Controls.Remove(pnContainButtonSignIn);
                pnFrameOption.Controls.Remove(pnContainButtonSignUp);
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
                pnFrameOption.Controls.Remove(pnContainButtonSignIn);
                pnFrameOption.Controls.Remove(pnContainButtonSignUp);
                timerClickButonLogin.Stop();
                lbWellcome.Text = "SIGN - IN";
                this.activeFormChild(this.pnLoginSignupContent, new LoginForm(this), sender);
                return;
            }
        }

        Form actForm;
        public void LogOut()
        {
            this.activeFormChild(this.pnLoginSignupContent, new SplashForm(), null, ref actForm);
        }

        private void timerOpenMainForm_Tick(object sender, EventArgs e)
        {
            //if (Location.X > 0)
            //{
            //    int y = Location.Y - 5;
            //    Location = new Point((550 / 62 * y), y);
            //    //if (Size.Height < 900 && Size.Width < 1400)
            //    //{
            //    //    Size = new Size(Size.Width + 50, Size.Height);
            //    //}
            //}
            //else
            //{
            Program.sp.pnHeader.BackColor = Color.DarkGray;
            timerOpenMainForm.Stop();
            Size = new Size(1280, 720);
            PnSubLogin.Controls.Clear();
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            Location = new Point(screenWidth / 2 - 1280 / 2, screenHeight / 2 - 720 / 2);
            this.activeFormChild(this.PnSubLogin, new MainForm(this), sender);
            //Console.WriteLine($"1 {PnSubLogin.Size.Width}, {PnSubLogin.Size.Height}");
            //Console.WriteLine($"0 {Size.Width}, {Size.Height}");
            //}

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Guna2AnimateWindow gunaAnimateWindow = new Guna2AnimateWindow();
            gunaAnimateWindow.SetAnimateWindow(this, Guna2AnimateWindow.AnimateWindowType.AW_CENTER, 500);

            // Đóng cửa sổ sau khi hiệu ứng fade-out hoàn tất
            Timer timer = new Timer();
            timer.Interval = 500; // Đặt thời gian trùng với thời gian của hiệu ứng fade-out
            timer.Tick += (s, x) =>
            {
                this.Close();
                timer.Stop();
            };
            timer.Start();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.btnMaximize.Image = global::App_Library.Properties.Resources.scale__1_;
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.btnMaximize.Image = global::App_Library.Properties.Resources.minimize;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

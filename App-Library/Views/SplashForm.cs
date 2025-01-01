using App_Library.Views.Main.CollectionShop;
using App_Library.Views.ToolerForm;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
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
            
            timerClickButonLogin.Start();
        }
        // Bấm nút đăng ký
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            timerClickButtonSignUp.Start();
        }

        private void timerSignUp_Tick(object sender, EventArgs e)
        {
            double speedFactor = 0.1; // Hệ số tốc độ ban đầu (nhỏ hơn = nhanh hơn lúc đầu).

            bool isAnimating = false;

            if (lbWellcome.Location.Y > 30)
            {
                int delta = Math.Max((int)((lbWellcome.Location.Y - 30) * speedFactor), 1);
                lbWellcome.Location = new Point(lbWellcome.Location.X, lbWellcome.Location.Y - delta);
                speedFactor += 0.02; // Giảm tốc theo thời gian.
                isAnimating = true;
            }

            if (pnFrameOption.Location.Y > 125)
            {
                int delta = Math.Max((int)((pnFrameOption.Location.Y - 125) * speedFactor), 1);
                pnFrameOption.Location = new Point(pnFrameOption.Location.X, pnFrameOption.Location.Y - delta);
                speedFactor += 0.02; // Giảm tốc theo thời gian.
                isAnimating = true;
            }

            if (pnLoginSignupContent.Location.Y > 0)
            {
                int delta = Math.Max((int)(pnLoginSignupContent.Location.Y * speedFactor), 1);
                pnLoginSignupContent.Location = new Point(pnLoginSignupContent.Location.X, pnLoginSignupContent.Location.Y - delta);
                speedFactor += 0.02; // Giảm tốc theo thời gian.
                isAnimating = true;
            }

            if (!isAnimating)
            {
                // Khi tất cả các animation hoàn tất
                pnFrameOption.Controls.Remove(pnContainButtonSignIn);
                pnFrameOption.Controls.Remove(pnContainButtonSignUp);
                timerClickButtonSignUp.Stop();
                lbWellcome.Text = "SIGN - UP";
                this.activeFormChild(this.pnLoginSignupContent, new SignUpForm(this), sender);
            }
        }


        private void timerClickButonLogin_Tick(object sender, EventArgs e)
        {
            double speedFactor = 0.1; // Hệ số tốc độ ban đầu (nhỏ hơn = nhanh hơn lúc đầu).

            bool isAnimating = false;

            if (lbWellcome.Location.Y > 30)
            {
                int delta = Math.Max((int)((lbWellcome.Location.Y - 30) * speedFactor), 1);
                lbWellcome.Location = new Point(lbWellcome.Location.X, lbWellcome.Location.Y - delta);
                speedFactor += 0.02; // Giảm tốc theo thời gian.
                isAnimating = true;
            }

            if (pnFrameOption.Location.Y > 125)
            {
                int delta = Math.Max((int)((pnFrameOption.Location.Y - 125) * speedFactor), 1);
                pnFrameOption.Location = new Point(pnFrameOption.Location.X, pnFrameOption.Location.Y - delta);
                speedFactor += 0.02; // Giảm tốc theo thời gian.
                isAnimating = true;
            }

            if (pnLoginSignupContent.Location.Y > 0)
            {
                int delta = Math.Max((int)(pnLoginSignupContent.Location.Y * speedFactor), 1);
                pnLoginSignupContent.Location = new Point(pnLoginSignupContent.Location.X, pnLoginSignupContent.Location.Y - delta);
                speedFactor += 0.02; // Giảm tốc theo thời gian.
                isAnimating = true;
            }

            if (!isAnimating)
            {
                // Khi tất cả các animation hoàn tất
                pnFrameOption.Controls.Remove(pnContainButtonSignIn);
                pnFrameOption.Controls.Remove(pnContainButtonSignUp);
                timerClickButonLogin.Stop();
                lbWellcome.Text = "SIGN - IN";
                this.activeFormChild(this.pnLoginSignupContent, new LoginForm(this), sender);
            }
        }



        Form actForm;
        public void LogOut()
        {
            this.activeFormChild(this.pnLoginSignupContent, new SplashForm(), null, ref actForm);
        }

        private void timerOpenMainForm_Tick(object sender, EventArgs e)
        {

            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            Size sizeTarget = new Size(1280, 720);
            Point locationTarget = new Point(screenWidth / 2 - 1280 / 2, screenHeight / 2 - 720 / 2);
            this.BackColor = Color.WhiteSmoke;

            // Lấy kích thước và vị trí hiện tại của Form
            int currentWidth = this.Width;
            int currentHeight = this.Height;
            int currentX = this.Location.X;
            int currentY = this.Location.Y;

            // Tính toán gia tốc cho kích thước và vị trí
            int deltaWidth = Math.Max(1, (sizeTarget.Width - currentWidth) / 5);  // Tăng tốc độ thay đổi
            int deltaHeight = Math.Max(1, (sizeTarget.Height - currentHeight) / 5);  // Tăng tốc độ thay đổi
            int deltaX = Math.Max(1, (currentX - locationTarget.X) / 5);  // Tăng tốc độ thay đổi
            int deltaY = Math.Max(1, (currentY - locationTarget.Y) / 5);  // Tăng tốc độ thay đổi

            // Cập nhật kích thước và vị trí đồng thời
            if (currentWidth < sizeTarget.Width || currentHeight < sizeTarget.Height || currentX > locationTarget.X || currentY > locationTarget.Y)
            {
                this.Size = new Size(
                    Math.Min(currentWidth + deltaWidth, sizeTarget.Width),
                    Math.Min(currentHeight + deltaHeight, sizeTarget.Height)
                );

                this.Location = new Point(
                    Math.Max(locationTarget.X, currentX - deltaX),
                    Math.Max(locationTarget.Y, currentY - deltaY)
                );
            }
            else
            {
                Program.sp.pnHeader.BackColor = Color.WhiteSmoke;
                timerOpenMainForm.Stop();
                this.Size = sizeTarget;  // Đặt kích thước cuối cùng
                this.Location = locationTarget;  // Đặt vị trí cuối cùng
                this.activeFormChild(this.PnSubLogin, new MainForm(this), sender);
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
            PnSubLogin.Controls.Clear();
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

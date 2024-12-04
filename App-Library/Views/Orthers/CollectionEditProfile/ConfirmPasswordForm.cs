using App_Library.Models;
using App_Library.Services;
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

namespace App_Library.Views.Orthers.CollectionEditProfile.ChangePasswordCollection
{
    public partial class ConfirmPasswordForm : FormHelper
    {
        User user;
        ChangePasswordForm parent;
        string stringOtp = GenerateRandomString(4);
        AuthService authService;
        public ConfirmPasswordForm(Models.User user, ChangePasswordForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.user = user;
            authService = new AuthService();
        }

        private void ConfirmPasswordForm_Load(object sender, EventArgs e)
        {
            txtUserName.Text = user.Username;
        }

        private void btnNext_MouseHover(object sender, EventArgs e)
        {
            btnNext.Text = "Next";
            timerHHoverNext.Start();
        }

        private void timerHHoverNext_Tick(object sender, EventArgs e)
        {
            if (btnNext.Width < 170)
            {
                btnNext.Width += 10;
                btnNext.Location = new Point(btnNext.Location.X - 10, btnNext.Location.Y);
            }
            else
            {
                btnNext.Width = 170;
                btnNext.Location = new Point(413, 513);
                timerHHoverNext.Stop();
            }
        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            timerHHoverNext.Stop();
            btnNext.Text = "";
            timerLeave.Start();
        }

        private void timerLeave_Tick(object sender, EventArgs e)
        {
            if (btnNext.Width > 80)
            {
                btnNext.Width -= 10;
                btnNext.Location = new Point(btnNext.Location.X + 10, btnNext.Location.Y);
            }
            else
            {
                btnNext.Width = 80;
                btnNext.Location = new Point(503, 513);
                timerLeave.Stop();
            }
        }

        private void btnSendOtp_Click(object sender, EventArgs e)
        {
            stringOtp = GenerateRandomString(4);

            sendMailOtp(stringOtp, user.Email);
            MessageBox.Show("OTP sended your email !!");
            timerOtps.Start();
            btnSendOtp.Click -= new EventHandler(btnSendOtp_Click);
        }

        public static string GenerateRandomString(int length)
        {
            // Các ký tự có thể xuất hiện trong chuỗi ngẫu nhiên
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();

            char[] stringChars = new char[length];

            for (int i = 0; i < length; i++)
            {
                // Chọn ngẫu nhiên một ký tự từ danh sách chars
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new string(stringChars); // Trả về chuỗi kết quả
        }
        int count = 0;
        private void timerOtp_Tick(object sender, EventArgs e)
        {
            if (count < 60)
            {
                count++;
                btnSendOtp.Text = 60 - count + "s";
            }
            else
            {
                count = 0;
                btnSendOtp.Text = "Send";
                stringOtp = GenerateRandomString(4);
                timerOtps.Stop();
                btnSendOtp.Click += new EventHandler(btnSendOtp_Click);
            }
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (!(await authService.CheckPassword(user.Username, txtPassword.Text)))
            {
                txtPassword.BorderColor = Color.Red;
                check = false;
            }
            if (!(txtCodeOtp.Text.Equals(stringOtp)))
            {
                txtCodeOtp.BorderColor = Color.Red;
                check = false;

            }
            if (check)
            {
                MessageBox.Show("Success");
                parent.nextPage(new NewPasswordForm(user, parent));
            }
            else
            {
                MessageBox.Show(" Not Success");
            }
        }

    }
}

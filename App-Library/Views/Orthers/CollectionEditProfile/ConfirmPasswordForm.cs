using App_Library.Models;
using App_Library.Services;
using App_Library.Views.ToolerForm;
using MongoDB.Driver.Core.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace App_Library.Views.Orthers.CollectionEditProfile.ChangePasswordCollection
{
    public partial class ConfirmPasswordForm : FormHelper
    {
        User user;
        bool isEyeClose = true;
        ChangePasswordForm parent;
        string stringOtp = GenerateRandomString(4);
        AuthService authService;
        int countDown = 3;
        bool forgotPass = false;
        public ConfirmPasswordForm(Models.User user, ChangePasswordForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.user = user;
            authService = new AuthService();
            this.forgotPass = user == null ?true : this.forgotPass = false;

            if (forgotPass)
            {
                lbPassword.Text = "EMAIL";
                picEye.Visible = false;
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtUserName.Text = user.Username;
            }


        }

        private void ConfirmPasswordForm_Load(object sender, EventArgs e)
        {

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
                btnNext.Location = new Point(413, 458);
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
                btnNext.Location = new Point(503, 458);
                timerLeave.Stop();
            }
        }

        private async void btnSendOtp_Click(object sender, EventArgs e)
        {
            if (!forgotPass)
            {
                sendOTP(user.Email);
            }
            else
            {
                if (txtPassword.Text == "")
                {
                    (new AlertFail("Fail !!" + "\n" + "Mail is epmty")).ShowDialog();
                }
                else
                {
                    var db = await (new AuthService()).GetUserByEmail(txtPassword.Text);
                    if (db == null)
                    {
                        (new AlertFail("Fail !!" + "\n" + "Account not exist")).ShowDialog();
                    }
                    else
                    {
                        sendOTP(db.Email);
                    }
                }
            }
        }
        void sendOTP(string mail)
        {
            stringOtp = GenerateRandomString(4);

            bool result = sendMailOtp(stringOtp, mail);
            if (result)
            {
                (new AlertSuccess("Send otp to your mail success !!!")).ShowDialog();
                timerOtps.Start();
                btnSendOtp.Click -= new EventHandler(btnSendOtp_Click);
            }
            else
            {
                (new AlertFail("Send otp to your mail fail !!!")).ShowDialog();
            }
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (forgotPass)
            {
                handleForgotPassword();
            }
            else
            {
                handleChangePassword();
            }


        }
        async void handleForgotPassword()
        {
            var db = await (new AuthService()).GetUserByEmail(txtPassword.Text);
            if (!(txtCodeOtp.Text.Equals(stringOtp)))
            {
                txtCodeOtp.BorderColor = Color.Red;
            }
            else
            {
                (new AlertSuccess("Success")).ShowDialog();
                parent.nextPage(new NewPasswordForm(db, parent));
            }
        }
        async void handleChangePassword()
        {
            if (pnPassword.Visible == false)
            {
                bool check = true;

                if (!(txtCodeOtp.Text.Equals(stringOtp)))
                {
                    txtCodeOtp.BorderColor = Color.Red;
                    check = false;
                }
                if (check)
                {
                    (new AlertSuccess("Success")).ShowDialog();
                    parent.nextPage(new NewPasswordForm(user, parent));
                }
                else
                {
                    (new AlertFail("Fail" + "\n" + "Code OTP incorrect")).ShowDialog();
                }
            }
            else
            {
                if (!(await authService.CheckPassword(user.Username, txtPassword.Text)))
                {
                    txtPassword.BorderColor = Color.Red;
                    (new AlertFail("Fail" + "\n" + "Password incorrect")).ShowDialog();
                }
                else
                if (!(txtCodeOtp.Text.Equals(stringOtp)))
                {
                    txtCodeOtp.BorderColor = Color.Red;
                    (new AlertFail("Fail" + "\n" + "Code OTP incorrect")).ShowDialog();

                }
                else
                {
                    (new AlertSuccess("Success")).ShowDialog();
                    parent.nextPage(new NewPasswordForm(user, parent));
                }
            }
        }
        void closeEye()
        {
            try
            {
                isEyeClose = true;
                this.picEye.Image = global::App_Library.Properties.Resources.eye;
                txtPassword.PasswordChar = '•';

                picEye.Click += new EventHandler(this.picEye_Click);
            }
            catch (Exception e)
            {

            }

        }

        void openEye()
        {
            try
            {
                isEyeClose = false;
                this.picEye.Image = global::App_Library.Properties.Resources.eye_slash;
                txtPassword.PasswordChar = '\0';
                timerEyeOpen.Start();
                picEye.Click -= new EventHandler(this.picEye_Click);
            }
            catch (Exception ex)
            {
            }

        }

        private void picEye_Click(object sender, EventArgs e)
        {
            openEye();
        }

        private void timerEyeOpen_Tick(object sender, EventArgs e)
        {
            if (countDown > 0)
            {
                countDown--;
            }
            else
            {
                countDown = 3;
                closeEye();
            }
        }

        private async void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            if (forgotPass)
            {
                if (txtPassword.Text == "")
                {
                    return;
                }
                else
                {
                    try
                    {
                        var db = await (new AuthService()).GetUserByEmail(txtPassword.Text);
                        if (db != null)
                        {
                            txtUserName.Text = db.Username;
                            parent.updateFrame(db);
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
        }
    }
}

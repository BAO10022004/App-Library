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
        public SplashForm()
        {
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
                pnFrameOption.Location = new Point(pnFrameOption.Location.X, pnFrameOption.Location.Y - (2* 250 / 37));
                btnSignUp.Location = new Point(btnSignUp.Location.X, btnSignUp.Location.Y - 100 / 37);
            }
            else
            {
                pnFrameOption.Controls.Remove(button1);
                    pnLogInContent.Location = new Point(0, 119);
                 lbWellcome.Location = new Point(lbWellcome.Location.X + 60, lbWellcome.Location.Y);
                timerClickButonLogin.Stop();
                lbWellcome.Text = "SIGN - IN ";
                 activeFormChild(new LoginForm(), sender);
                return;
                
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            timerClickButonLogin.Start();
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {

        }

        private void lbWellcome_Click(object sender, EventArgs e)
        {

        }
    }
}

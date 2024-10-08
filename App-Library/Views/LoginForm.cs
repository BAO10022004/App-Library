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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


      
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            
                        if (e.Button == MouseButtons.Left) // Chỉ di chuyển khi chuột trái được nhấn
            {
                this.Location = new Point(this.Location.X + e.X , this.Location.Y + e.Y );
            }
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {

            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
        }

        private void btnLogin_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void btnLogin_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnMainContentLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnFrameOption_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerClickButonLogin_Tick(object sender, EventArgs e)
        {
            
            
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timerClickButonLogin.Start();
        }

        private void pnSubLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbForgotPassword_Click(object sender, EventArgs e)
        {

        }

        private void lbCreateAccount_Click(object sender, EventArgs e)
        {

        }

        private void MyFormLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnContentFormLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbWellcome_Click(object sender, EventArgs e)
        {

        }

        private void pnContainTxbPassword_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pnContainTxbUserName_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

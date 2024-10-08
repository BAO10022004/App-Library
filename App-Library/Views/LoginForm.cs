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


        int xAsb;
        int yAsb;
        
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(this.Location.X == 300 && this.Location.Y == 300)
            {
                xAsb = e.X - this.Location.X;
            }
                        if (e.Button == MouseButtons.Left) // Chỉ di chuyển khi chuột trái được nhấn
            {
                this.Location = new Point(this.Location.X + e.X + 2*xAsb, this.Location.Y + e.Y );
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library.Views.ToolerForm
{
    public partial class LoadingForm : Form
    {
        public LoadingForm(Form form = null)
        {
            InitializeComponent();
            this.Location = Program.sp.Location;
            if (form != null)
            {
                this.Size =new Size( form.Width,form.Height +40);
            }
            else
            {
                this.Size = Program.sp.Size;
            }
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
           
        }

        private void timerStart_Tick(object sender, EventArgs e)
        {
            Random random = new Random();

            // Generate random RGB values between 0 and 255
            int r = random.Next(0, 256); // Red component
            int g = random.Next(0, 256); // Green component
            int b = random.Next(0, 256); // Blue component

            // Create a random color using the RGB values
            Color randomColor = Color.FromArgb(r, g, b);
        }
    }
}

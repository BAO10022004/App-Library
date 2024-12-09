﻿using System;
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
        public LoadingForm()
        {
            InitializeComponent();
            this.Location = Program.sp.Location;
            process.Start();
            this.Size = Program.sp.Size;
            process.Location = new Point(this.Width/2- process.Width/2, this.Height/2 -process.Height/2);
           
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

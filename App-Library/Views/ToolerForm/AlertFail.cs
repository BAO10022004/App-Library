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
    public partial class AlertFail : Form
    {
        public AlertFail(String messege)
        {
            InitializeComponent();
            lbMessge.Text = messege;
            this.Location = Program.sp.Location;
        }

        private void pnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

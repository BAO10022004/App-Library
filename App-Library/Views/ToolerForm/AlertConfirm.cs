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
    public partial class AlertConfirm : Form
    {
        public bool ConfirmResult { get; private set; }
        public AlertConfirm()
        {
            InitializeComponent();
            this.Location = Program.sp.Location;
            
        }

        private void btnOk_MouseHover(object sender, EventArgs e)
        {
            btnOk.AnimatedGIF = true;
        }

        private void btnOk_MouseLeave(object sender, EventArgs e)
        {
            btnOk.AnimatedGIF = false;
        }

        private void btnCancel_MouseHover(object sender, EventArgs e)
        {
            btnCancel.AnimatedGIF = true;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.AnimatedGIF = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ConfirmResult = false;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ConfirmResult = true;
            this.Close();
        }

        private void AlertConfirm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}

using App_Library.APIService;
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
    public partial class HomeForm : Form
    {
        private readonly AuthService _authService;
        public HomeForm()
        {
            this.Size = (new MainForm()).Size;
            InitializeComponent();

        }
    }
}

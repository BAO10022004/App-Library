using App_Library.Services;
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
        BookSoldService bookSoldService;
        private readonly AuthService _authService;
        public HomeForm()
        {
            this.Size = (new MainForm()).Size;
            InitializeComponent();
            bookSoldService = new BookSoldService();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void HomeForm_Load(object sender, EventArgs e)
        {
            lbNumberBoughtBook.Text =(await bookSoldService.GetBoughtBooksAsync()).Count.ToString();
        }

        private void HomeForm_Resize(object sender, EventArgs e)
        {
            lbNameForm.Location = new Point((pnNameForm.Width - lbNameForm.Width) / 2, (pnNameForm.Height - lbNameForm.Height) / 2);
            pnGroup1.Width = this.Width / 2-10;
            pnGroup.Width = this.Width / 2-10;
            btnBoughtBook.Location =new Point( (pnGroup1.Width - btnBoughtBook.Width) / 2, btnBoughtBook.Location.Y);
            btnProcessing.Location = new Point((pnGroup2.Width - btnProcessing.Width) / 2, btnProcessing.Location.Y);


        }
    }
}

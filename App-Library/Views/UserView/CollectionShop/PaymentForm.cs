using App_Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library.Views.UserView.CollectionShop
{
    public partial class PaymentForm : Form
    {
        public bool ConfirmResult { get; private set; }
        public PaymentForm(Book book)
        {
            InitializeComponent();
            lbNameBook.Text += book.Title;
            lbNameAuthor.Text += book.Author;
            label5lbGence.Text += book.Genre;
            lbPrice.Text ="$" + book.Price;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ConfirmResult = false;
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ConfirmResult = true;
            this.Close();
        }
    }
}

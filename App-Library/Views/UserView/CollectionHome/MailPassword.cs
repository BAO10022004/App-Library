using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library.Views.UserView.CollectionHome
{
    public partial class MailPassword : Form
    {
        String _password;
        HistoryForm _form;
        public MailPassword(String password, HistoryForm partent )
        {
            InitializeComponent();
            this._password = password;
            this._form = partent;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            this.Hide();
            _form.sendMail(sender, e);
            this.Close();
        }
    }
}

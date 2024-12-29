using App_Library.Models;
using App_Library.Services;
using App_Library.Views.Orthers.CollectionEditProfile;
using App_Library.Views.ToolerForm;
using App_Library.Views.UserView;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library.Views.Orthers.CollectionProfile
{
    public partial class NewProfileForm : FormHelper
    {
        User user;
        public MainForm mainForm;
        private BookSoldService _bookSoldService;
        List<BookSold> _books;
        public NewProfileForm(MainForm parent, List<BookSold> models)
        {
            InitializeComponent();
            _bookSoldService = new BookSoldService();
            this.mainForm = parent;
            this._books = models;
        }
        public NewProfileForm(NewProfileForm copyPage)
        {
            InitializeComponent();
            _bookSoldService = new BookSoldService();
            this.mainForm = copyPage.mainForm;
            this._books = copyPage._books;
        }
        private async void NewProfileForm_Load(object sender, EventArgs e)
        {
            user =await (new UserService()).GetCurrentUserAsync();
            lbEmail.Text = user.Email;
            lbUsername.Text = user.Username;
            try
            {
                picAvatar.Load(user.PhotoURL);
            }
            catch (Exception ex)
            {
            }
            lbPending.Text = _books.Where(n=>n.Status == "Pending").Count().ToString();
            lbStock.Text = _books.Where(n => n.Status == "Approved").Count().ToString();
        }

        Form actFormEdit;
        //Form actFormChange;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            activeFormChild(mainForm.pnContent, new EditprofileForm(this), null, ref actFormEdit);
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (Program.checkLoginGG)
            {
                (new AlertFail("Acount login with Google cann't change password")).ShowDialog();
            }
            else
            {
                (new ChangePasswordForm(user)).ShowDialog();
            }
        }
    }
}

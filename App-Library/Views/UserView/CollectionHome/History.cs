using App_Library.Models;
using App_Library.Services;
using App_Library.Views.ToolerForm;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace App_Library.Views.UserView.CollectionHome
{
    public partial class History : FormHelper
    {
        Form actForm;
        MainForm mainForm;
        SideBarUserForm sideBarUserForm;
        public History(MainForm parent, SideBarUserForm sideBarUserForm)
        {
            InitializeComponent();
            this.mainForm = parent;
            this.sideBarUserForm = sideBarUserForm;
        }

        private async void History_Load(object sender, EventArgs e)
        {
            LoadingForm loadingForm = new LoadingForm();
            loadingForm.Show();
            var dbBookBold =await GetBooksInProgressByOnGiaBao(await (new UserService()).GetCurrentUserAsync());
            if (dbBookBold.Count > 0)
            {
                loadingForm.Close();
                pnMain.Controls.Clear();
              
               
                activeFormChild(pnMain, new HistoryForm(dbBookBold), null, ref actForm);
            }
        }
        public async Task<List<BookSold>> GetBooksInProgressByOnGiaBao(User _user)
        {
            string usernameCurrent = _user.Username;
            string passwordCurrent = _user.PasswordHash;
            string id = _user.Id;
            AuthService db = new AuthService();
            bool result = await db.Login("admin", "123456", null);
            if (!result)
            {
                await db.Login(usernameCurrent, passwordCurrent, null);
                return null;
            }
            else
            {
                var user = (await (new UserService()).GetUsersAsync()).ToList().FirstOrDefault(u => u.Username == usernameCurrent);

                if (user == null)
                {
                    return null;
                }
                
                List<BookSold> list = await (new BookSoldService()).GetBooksSoldAsync();
                var filteredBooks = (from b in list
                                     where b.UserId == id &&
                                           (b.Status == "Pending" || b.Status == "Approved")
                                     select b).ToList();
                await db.Login(usernameCurrent, passwordCurrent, null);
                return filteredBooks;
            }
        }
        private void btnNextShop_MouseHover(object sender, EventArgs e)
        {
            btnNextShop.TextAlign = HorizontalAlignment.Right;
        }

        private void btnNextShop_MouseLeave(object sender, EventArgs e)
        {
            btnNextShop.TextAlign = HorizontalAlignment.Left;
        }

        private void btnNextShop_Click(object sender, EventArgs e)
        {
            sideBarUserForm.lbHome_Click(sideBarUserForm.btnHome,e);
        }
    }
}

using App_Library.Models;
using App_Library.Services;
using App_Library.Views.AdminView;
using App_Library.Views.AdminView.CollectionStatistics;
using App_Library.Views.Main.CollectionShop;
using App_Library.Views.Orthers.CollectionHelp;
using App_Library.Views.Orthers.CollectionProfile;
using App_Library.Views.Orthers.CollectionSetting;
using App_Library.Views.ToolerForm;
using App_Library.Views.UserView;
using App_Library.Views.UserView.CollectionHome;
using Guna.UI2.WinForms;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Documents;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App_Library.Views
{
    public partial class MainForm : FormHelper
    {
        private readonly UserService _userService;
        private readonly BookService _bookService;
        //private readonly StarsRatingService _starsRating;
        //private bool isDragging = false;
        //private Point dragStartPoint;
        //private Control draggedControl;
        internal StockForm homeForm;
        private NewShopMain shopForm;
        SideBarUserForm sidebar;
        // compunent shop 
        //List<Panel> listBookAd;
        List<Book> books;
        Task<List<BookSold>> bookSold;
        //Dictionary<Control, Form> formDictionary;
        //Form currentForm;

        Dictionary<System.Windows.Controls.Control, bool> isClick;
        //SplashForm Parent;
        public MainForm(SplashForm _Parent)
        {
            InitializeComponent();
            _userService = new UserService();
            _bookService = new BookService();
            //_starsRating = new StarsRatingService();
            books = new List<Book>();
            //listBookAd = new List<Panel>();
            isClick = new Dictionary<System.Windows.Controls.Control, bool>();
            //Console.WriteLine($"2 {pnContent.Size.Width}, {pnContent.Size.Height}");
            //this.Parent = _Parent;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            dataBind();
            // Hiển thị thông tin người dùng hiện tại
            var currentUser = await _userService.GetCurrentUserAsync();
            Session.CurentUser = currentUser;
            lbName.Text = currentUser.Username;
            try
            {
                picAvatar.Load(currentUser.PhotoURL); // Đường dẫn hoặc URL của ảnh
            }
            catch (Exception)
            {
                // Nếu có lỗi khi tải ảnh, có thể đặt ảnh mặc định hoặc để trống
                this.picAvatar.Image = global::App_Library.Properties.Resources.account;
            }

            shopForm = new NewShopMain(this);

            // Hiển thị sidebar
            if (currentUser.IsAdmin)
            {
                lbRole.Text = "Admin";
                activeFormChild(pnSideBar, new SideBarAdminForm(this));
                activeFormChildForMainForm(new StatisticsForm(), e);
            }
            else
            {
                lbRole.Text = "User";
                sidebar = new SideBarUserForm(this);
                activeFormChild(pnSideBar, new SideBarUserForm(this));
                activeFormChildForMainForm(shopForm, e);
            }

            books = await _bookService.GetBooksAsync();
            
            //MessageBox.Show((await bookSold).Count.ToString());
        }
       
        public async Task< List<BookSold>> getListSold()
        {
            
            return await bookSold;
        }

        Form formShopMain;
        Form ActForm;
        public void activeFormChildForMainForm(Form formDes, object obj)
        {
            if (ActForm != null && !ActForm.IsDisposed)
            {
                ActForm.Close();
            }
            ActForm = formDes;
            formDes.TopLevel = false;
            formDes.FormBorderStyle = FormBorderStyle.None;
            formDes.Dock = DockStyle.Fill;
            pnContent.Controls.Add(formDes);
            pnContent.Tag = formDes;
            formDes.BringToFront();
            formDes.Show();
        }

        Form actForm;
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Size = new Size(460, 700);
            Program.sp.Hide();
            Program.sp = new SplashForm();
            Program.sp.ShowDialog();
        }
        public async void dataBind()
        {
            bookSold = GetBooksInProgressByOnGiaBao(await(new UserService()).GetCurrentUserAsync());
        }
        private void btnLogOut_MouseHover(object sender, EventArgs e)
        {
            pnContainLogOut.BorderColor = Color.Blue;
            picLogOut.Visible = true;
        }

        private void pnContainLogOut_MouseLeave(object sender, EventArgs e)
        {
            pnContainLogOut.BorderColor = Color.Black;
            picLogOut.Visible = false;
        }
        public async void nextPageToHistory(object e)
        {
            activeFormChildForMainForm(new History(sidebar,await bookSold), e);
        }

        private void profileToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        { }

        public async Task<List<BookSold>> GetBooksInProgressByOnGiaBao(User _user)
        {
            string usernameCurrent = _user.Username;
            string passwordCurrent = _user.PasswordHash;
            string id = _user.Id;
            if (!Program.checkLoginGG)
            {
                passwordCurrent = Program.password;
                usernameCurrent = Program.username;
            }
            AuthService db = new AuthService();
            bool result = await db.Login("testappuser", "$2a$11$1OI6fJlj5s/4jQYeGEmFqucoLhIUaJlcKjl./EvToy7Fjq.jWpzUG", null);
            if (!result)
            {
                result = await db.Login(usernameCurrent, passwordCurrent, null);
                if (!result)
                {
                    return null;
                }
            }
            var user = (await (new UserService()).GetUsersAsync()).Find(u => u.Username == usernameCurrent);
           
            if (user == null)
            {
                await db.Login(usernameCurrent, passwordCurrent, null);
                return null;
            }
            List<BookSold> list = await (new BookSoldService()).GetBooksSoldAsync();
            var filteredBooks = list.Where(b => b.UserId == id && (b.Status == "Pending" || b.Status == "Approved")).ToList();

            await db.Login(usernameCurrent, passwordCurrent, null);
            return filteredBooks;
        }
    }
}

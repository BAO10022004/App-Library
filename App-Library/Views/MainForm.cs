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
        private readonly StarsRatingService _starsRating;
        private bool isDragging = false;
        private Point dragStartPoint;
        private Control draggedControl;
        internal StockForm homeForm;
        private NewShopMain shopForm;
        SideBarUserForm sidebar;
        // compunent shop 
        List<Panel> listBookAd;
        List<Book> books;
        Task<List<BookSold>> bookSold;
        Dictionary<Control, Form> formDictionary;
        Form currentForm;
        Dictionary<Control, bool> isClick;
        SplashForm Parent;
        public MainForm(SplashForm _Parent )
        {
            InitializeComponent();
            _userService = new UserService();
            _bookService = new BookService();
            _starsRating = new StarsRatingService();
            books = new List<Book>();
            listBookAd = new List<Panel>();
            isClick = new Dictionary<Control, bool>();
            //Console.WriteLine($"2 {pnContent.Size.Width}, {pnContent.Size.Height}");
            this.Parent = _Parent;
        }
        public async void refresh()
        {
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
            // Hiển thị sidebar
            
        }
        private async void MainForm_Load(object sender, EventArgs e)
        {
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

            homeForm = new StockForm(this);
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
                activeFormChild(pnSideBar, sidebar);
                activeFormChildForMainForm(shopForm, e);
            }

            books = await _bookService.GetBooksAsync();
            bookSold = GetBooksInProgressByOnGiaBao(await (new UserService()).GetCurrentUserAsync());

        }
       
        public Task<List<BookSold>> getListSold()
        {
            return bookSold;
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

        private void btnLogOut_MouseHover(object sender, EventArgs e)
        {
            pnContainLogOut.BorderColor = Color.Blue;
            picLogOut.Visible = true;
        }

        private void pnContainLogOut_MouseLeave(object sender, EventArgs e)
        {
            pnContainLogOut.BorderColor = Color.Black;
            picLogOut.Visible=false;
        }
        public void nextPageToHistory (object e)
        {
            activeFormChildForMainForm(new History(this, sidebar), e);
        }
        public async Task<List<BookSold>> GetBooksInProgressByOnGiaBao(User _user)
        {
            string usernameCurrent = _user.Username;
            string passwordCurrent = _user.PasswordHash;
            string id = _user.Id;

            // Tạo đối tượng dịch vụ và login
            AuthService db = new AuthService();

            // Thực hiện đăng nhập một lần
            bool result = await db.Login("admin", "123456", null);
            if (!result)
            {
                // Nếu không đăng nhập admin thành công, cố gắng đăng nhập người dùng bình thường
                result = await db.Login(usernameCurrent, passwordCurrent, null);
                if (!result)
                {
                    return null; // Trả về null nếu đăng nhập thất bại
                }
            }

            // Lấy thông tin người dùng từ service mà không cần phải gọi ToList()
            var user = (await (new UserService()).GetUsersAsync()).Find(u => u.Username == usernameCurrent);
            if (user == null)
            {
                return null;
            }

            // Lấy sách đã bán và lọc theo điều kiện
            List<BookSold> list = await (new BookSoldService()).GetBooksSoldAsync();
            var filteredBooks = list.Where(b => b.UserId == id && (b.Status == "Pending" || b.Status == "Approved")).ToList();

            // Đăng nhập lại với người dùng hiện tại (nếu cần)
            await db.Login(usernameCurrent, passwordCurrent, null);

            return filteredBooks;
        }
    }
}

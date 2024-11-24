using App_Library.Models;
using App_Library.Services;
using App_Library.Views.AdminView;
using App_Library.Views.Main.CollectionShop;
using App_Library.Views.Orthers.CollectionHelp;
using App_Library.Views.Orthers.CollectionProfile;
using App_Library.Views.Orthers.CollectionSetting;
using App_Library.Views.ToolerForm;
using App_Library.Views.UserView;
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
        internal HomeForm homeForm;
        private NewShopMain shopForm;

        // compunent shop 
        List<Panel> listBookAd;
        List<Book> books;
        Dictionary<Control, Form> formDictionary;
        Form currentForm;
        Dictionary<Control, bool> isClick;
        public MainForm()
        {
            InitializeComponent();
            _userService = new UserService();
            _bookService = new BookService();
            _starsRating = new StarsRatingService();
            books = new List<Book>();
            listBookAd = new List<Panel>();
            isClick = new Dictionary<Control, bool>();
            Console.WriteLine($"2 {pnContent.Size.Width}, {pnContent.Size.Height}");
            
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            // Hiển thị thông tin người dùng hiện tại
            var currentUser = await _userService.GetCurrentUserAsync();
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
            if (currentUser.IsAdmin)
            {
                lbRole.Text = "Admin";
                activeFormChild(pnSideBar, new SideBarAdminForm(this));
            }
            else
            {
                lbRole.Text = "User";
                activeFormChild(pnSideBar, new SideBarUserForm(this));
            }

            homeForm = new HomeForm(this);
            shopForm = new NewShopMain();
            books = await _bookService.GetBooksAsync();

            foreach (Control item in pnFooter.Controls)
            {
                if (item is Panel)
                {
                    var controls = item.Controls;
                    foreach (Control control in controls)
                    {
                        control.MouseLeave += new System.EventHandler(MouseLeave);
                        control.MouseHover += new System.EventHandler(MouseHover);
                    }
                }
            }
            activeFormChildForMainForm(homeForm, e);
            currentForm = new HomeForm(this);
            foreach (var item in pnFooter.Controls)
            {
                Panel panel = item as Panel;
                foreach (Control control in panel.Controls)
                {
                    if (control is Label)
                    {
                        isClick[control] = false;
                    }
                }
            }
        }
        private void MouseHover(object sender, EventArgs e)
        {
            var _lbShop = (Control)sender;
            var panel = FindControlContainer(pnFooter.Controls, _lbShop);
            panel.BackColor = Color.DeepSkyBlue;
            _lbShop.BackColor = Color.DeepSkyBlue;
        }
        public void clickBackHome(object sender, EventArgs e)
        {
            homeForm = new HomeForm(this);
            activeFormChildForMainForm(homeForm, e);
        }
        private void MouseLeave(object sender, EventArgs e)
        {
            var _lbShop = (Control)sender;
            var panel = FindControlContainer(pnFooter.Controls, _lbShop);

            if (sender is Label)
            {
                if (!isClick[sender as Control])
                {
                    panel.BackColor = Color.White;
                    _lbShop.BackColor = Color.White;
                }
            }

        }

        void setIsClick(object sender)
        {
            Guna2Panel panel = new Guna2Panel();
            foreach (var item in pnFooter.Controls)
            {
                panel = item as Guna2Panel;
                foreach (Control control in panel.Controls)
                {
                    if (control is Label)
                    {
                        isClick[control] = false;
                    }
                }
            }
            isClick[sender as Control] = true;
            foreach (var item in pnFooter.Controls)
            {
                panel = item as Guna2Panel;
                foreach (Control control in panel.Controls)
                {
                    if (control is Label)
                    {
                        if (isClick[control])
                        {
                            panel.BackColor = Color.DeepSkyBlue;
                            control.BackColor = Color.DeepSkyBlue;
                        }
                        else
                        {
                            panel.BackColor = Color.White;
                            control.BackColor = (Color)Color.White;
                        }
                    }
                }
            }
        }

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

        public Form getCurrentForm() => currentForm;

        private void lbSetting_Click(object sender, EventArgs e)
        {
            setIsClick(sender as Control);
            activeFormChildForMainForm(new SettingForm(), e);
        }

        private void lbHelp_Click(object sender, EventArgs e)
        {
            setIsClick(sender as Control);
            activeFormChildForMainForm(new HelpForm(), e);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            activeFormChildForMainForm(new ProfileForm(), e);
        }
    }
}

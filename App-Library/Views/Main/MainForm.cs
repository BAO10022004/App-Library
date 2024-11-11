using App_Library.Models;
using App_Library.Services;
using App_Library.Views.Main.CollectionShop;
using App_Library.Views.ToolerForm;
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
        private HomeForm homeForm;
        private NewShopMain shopForm;
        // compunent shop 
        List<Panel> listBookAd;
        List<Book> books;
        Dictionary<Control, Form> formDictionary;
        Form currentForm;
        Dictionary<Control, bool> isClick;
        public MainForm()
        {
            _userService = new UserService();
            _bookService = new BookService();
            _starsRating = new StarsRatingService();
            books = new List<Book>();
            listBookAd = new List<Panel>();
            isClick = new Dictionary<Control, bool>();
            InitializeComponent();

        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            var currentUser = await _userService.GetCurrentUserAsync();
            lbName.Text = currentUser.Username;
            lbEmail.Text = currentUser.Email;

            homeForm = new HomeForm();
            shopForm = new NewShopMain();
            books = await _bookService.GetBooksAsync();

            foreach (Control item in pnListsButton.Controls)
            {
                if (item is Panel)
                {
                    var controls = item.Controls;
                    foreach (Control control in controls)
                    {
                        control.MouseLeave += new System.EventHandler(this.lbShop_MouseLeave);
                        control.MouseHover += new System.EventHandler(this.lbShop_MouseHover);
                    }
                }
            }
            activeFormChild(pnContent, homeForm, e);
            currentForm = homeForm;
            foreach (var item in pnListsButton.Controls)
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
        private void lbShop_MouseHover(object sender, EventArgs e)
        {
            var _lbShop = (Control)sender;
            var panel = FindControlContainer(pnListsButton.Controls, _lbShop);
            panel.BackColor = Color.DeepSkyBlue;
            _lbShop.BackColor = Color.DeepSkyBlue;
        }

        private void lbShop_MouseLeave(object sender, EventArgs e)
        {
            var _lbShop = (Control)sender;
            var panel = FindControlContainer(pnListsButton.Controls, _lbShop);

            if (sender is Label)
            {
                if (!isClick[sender as Control])
                {
                    panel.BackColor = Color.White;
                    _lbShop.BackColor = Color.White;
                }
            }

        }

        private Point mouseDownLocation;
        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            mouseDownLocation = e.Location;
        }

        private void flowLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        private void txbSearch_Click(object sender, EventArgs e)
        {
            txbSearch.Enabled = true;
        }

        private void pnSearchMain_Click(object sender, EventArgs e)
        {
            txbSearch.Enabled = true;
        }
        void setIsClick(object sender)
        {
            Guna2Panel panel = new Guna2Panel();
            foreach (var item in pnListsButton.Controls)
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
            foreach (var item in pnListsButton.Controls)
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
        Point pointSave;
        private void lbHome_Click(object sender, EventArgs e)
        {
            setIsClick(sender as Control);
            pointSave = picHome.Location;
            lbHome.Text = "";
            timerPicHome.Start();
        }

        private void lbShop_Click(object sender, EventArgs e)
        {
            setIsClick(sender as Control);
            pointSave = picHome.Location;
            lbShop.Text = "";
            timerPicShop.Start();
        }
        int deltaX = 5;
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
        private void timerPicHome_Tick(object sender, EventArgs e)
        {
            if (picHome.Location.X < lbHome.Location.X)
            {
                picHome.Location = new Point(picHome.Location.X + deltaX, picHome.Location.Y);
            }
            else
            {
                timerPicHome.Stop();
                picHome.Location = pointSave;
                lbHome.Text = lbHome.Name.Substring(2);

                if (!(currentForm is HomeForm))
                {
                    homeForm = new HomeForm();
                    activeFormChildForMainForm(homeForm, e);
                    currentForm = homeForm;
                }
            }
        }

        private void timerPicShop_Tick(object sender, EventArgs e)
        {
            if (picShop.Location.X < lbShop.Location.X)
            {
                picShop.Location = new Point(picShop.Location.X + deltaX, picShop.Location.Y);
            }
            else
            {
                timerPicShop.Stop();
                picShop.Location = pointSave;
                lbShop.Text = lbShop.Name.Substring(2);

                if (!(currentForm is NewShopMain))
                {
                    activeFormChildForMainForm(new NewShopMain(), e);
                    currentForm = shopForm;
                }
            }
        }
        public Form getCurrentForm() => currentForm;
    }
}

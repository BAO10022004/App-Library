using App_Library.Views.Main.CollectionShop;
using App_Library.Views.ToolerForm;
using App_Library.Views.UserView.CollectionRequest;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;

namespace App_Library.Views.UserView
{
    public partial class SideBarUserForm : FormHelper
    {
        Dictionary<Control, bool> isClick;
        MainForm _mainForm;
        public SideBarUserForm(MainForm mainForm)
        {
            InitializeComponent();
            isClick = new Dictionary<Control, bool>();
            _mainForm = mainForm;
        }
        private void SideBarUserForm_Load(object sender, EventArgs e)
        {
            foreach (Control item in pnSideBar.Controls)
            {
                if (item is Panel)
                {
                    var controls = item.Controls;
                    foreach (Control control in controls)
                    {
                        control.MouseLeave += new System.EventHandler(this.MouseLeave);
                        control.MouseHover += new System.EventHandler(this.MouseHover);
                    }
                }
            }

            foreach (var item in pnSideBar.Controls)
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
            var panel = FindControlContainer(pnSideBar.Controls, _lbShop);
            panel.BackColor = Color.DeepSkyBlue;
            _lbShop.BackColor = Color.DeepSkyBlue;
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            var _lbShop = (Control)sender;
            var panel = FindControlContainer(pnSideBar.Controls, _lbShop);

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
            foreach (var item in pnSideBar.Controls)
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
            foreach (var item in pnSideBar.Controls)
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
            //pointSave = picHome.Location;
            //lbHome.Text = "";
            //timerPicHome.Start();
            _mainForm.activeFormChildForMainForm(new HomeForm(), e);
        }

        private void lbStore_Click(object sender, EventArgs e)
        {
            setIsClick(sender as Control);
            //pointSave = picHome.Location;
            //lbShop.Text = "";
            //timerPicShop.Start();
            _mainForm.activeFormChildForMainForm(new NewShopMain(), e);
        }

        private void lbRequest_Click(object sender, EventArgs e)
        {
            setIsClick(sender as Control);
            //pointSave = picHome.Location;
            //lbShop.Text = "";
            //timerPicShop.Start();
            _mainForm.activeFormChildForMainForm(new RequestForm(), e);
        }
        //private void timerPicHome_Tick(object sender, EventArgs e)
        //{
        //    if (picHome.Location.X < lbHome.Location.X)
        //    {
        //        picHome.Location = new Point(picHome.Location.X + deltaX, picHome.Location.Y);
        //    }
        //    else
        //    {
        //        timerPicHome.Stop();
        //        picHome.Location = pointSave;
        //        lbHome.Text = lbHome.Name.Substring(2);

        //        if (!(currentForm is HomeForm))
        //        {
        //            homeForm = new HomeForm();
        //            currentForm = homeForm;
        //            activeFormChildForMainForm(homeForm, e);

        //        }
        //    }
        //}

        //private void timerPicShop_Tick(object sender, EventArgs e)
        //{
        //    if (picShop.Location.X < lbShop.Location.X)
        //    {
        //        picShop.Location = new Point(picShop.Location.X + deltaX, picShop.Location.Y);
        //    }
        //    else
        //    {
        //        timerPicShop.Stop();
        //        picShop.Location = pointSave;
        //        lbShop.Text = lbShop.Name.Substring(2);

        //        if (!(currentForm is NewShopMain))
        //        {
        //            currentForm = new NewShopMain();
        //            activeFormChildForMainForm(new NewShopMain(), e);

        //        }
        //    }
        //}
    }
}

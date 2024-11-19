using App_Library.Views.AdminView.CollectionBooks;
using App_Library.Views.AdminView.CollectionComments;
using App_Library.Views.AdminView.CollectionHistory;
using App_Library.Views.AdminView.CollectionPending;
using App_Library.Views.AdminView.CollectionStatistics;
using App_Library.Views.AdminView.CollectionUpload;
using App_Library.Views.AdminView.CollectionUsers;
using App_Library.Views.ToolerForm;
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

namespace App_Library.Views.AdminView
{
    public partial class SideBarAdminForm : FormHelper
    {
        Dictionary<Control, bool> isClick;
        MainForm _mainForm;
        public SideBarAdminForm(MainForm mainForm)
        {
            InitializeComponent();
            isClick = new Dictionary<Control, bool>();
            _mainForm = mainForm;
        }
        private void SideBarAdminForm_Load(object sender, EventArgs e)
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
        private void lbStatistics_Click(object sender, EventArgs e)
        {
            setIsClick(sender as Control);
            _mainForm.activeFormChildForMainForm(new StatisticsForm(), e);
        }

        private void lbBooks_Click(object sender, EventArgs e)
        {
            setIsClick(sender as Control);
            _mainForm.activeFormChildForMainForm(new BooksForm(), e);
        }

        private void lbUsers_Click(object sender, EventArgs e)
        {
            setIsClick(sender as Control);
            _mainForm.activeFormChildForMainForm(new UsersForm(), e);
        }

        private void lbComments_Click(object sender, EventArgs e)
        {
            setIsClick(sender as Control);
            _mainForm.activeFormChildForMainForm(new CommentsForm(), e);
        }

        private void lbPending_Click(object sender, EventArgs e)
        {
            setIsClick(sender as Control);
            _mainForm.activeFormChildForMainForm(new PendingForm(), e);
        }

        private void lbHistory_Click(object sender, EventArgs e)
        {
            setIsClick(sender as Control);
            _mainForm.activeFormChildForMainForm(new HistoryForm(), e);
        }

        private void lbUpload_Click(object sender, EventArgs e)
        {
            setIsClick(sender as Control);
            _mainForm.activeFormChildForMainForm(new UploadForm(), e);
        }
    }
}

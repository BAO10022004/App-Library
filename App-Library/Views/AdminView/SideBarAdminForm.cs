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
                //item.MouseLeave += new System.EventHandler(this.MouseLeave);
                //item.MouseHover += new System.EventHandler(this.MouseHover);
                isClick[item] = false;
            }
            setIsClick(btnStatistics);
        }

        private void MouseHover(object sender, EventArgs e)
        {
            Guna2Button myButton = sender as Guna2Button;
            if (!(isClick[myButton]))
            {
                myButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                myButton.ImageSize = new Size(45, 45);
                myButton.FillColor = Color.LightCyan;
            }
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            Guna2Button myButton = sender as Guna2Button;
            if (!(isClick[myButton]))
            {
                myButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                myButton.ImageSize = new Size(35, 35);
                myButton.FillColor = Color.White;
            }

        }
        void setIsClick(object sender)
        {
            Guna2Button myButton = sender as Guna2Button;
            myButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            myButton.FillColor = Color.SkyBlue;
            isClick[myButton] = true;
            foreach (Guna2Button control in pnSideBar.Controls)
            {
                if (!control.Name.Equals(myButton.Name))
                {
                    control.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    control.FillColor = Color.White;
                    isClick[control] = false;
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

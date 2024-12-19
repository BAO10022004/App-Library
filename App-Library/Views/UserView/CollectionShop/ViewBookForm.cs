using App_Library.Models;
using App_Library.Views.Main.CollectionShop;
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

namespace App_Library.Views.UserView.CollectionShop
{

    public partial class ViewBookForm : FormHelper
    {
        bool SortnameAz;
        bool SortPrice;
        List<Book> data;
        List<Book> dataSource;
        NewShopMain controller;
        public ViewBookForm(NewShopMain controller, List<Book> models)
        {
            InitializeComponent();
            this.data = models;
            this.controller = controller;
            SortnameAz = true;
            SortPrice = true;
            dataSource = models;
        }

        private void btnSortName_Click(object sender, EventArgs e)
        {

            SortnameAz = !SortnameAz;
            if (SortnameAz)
            {
                this.btnSortName.Image = global::App_Library.Properties.Resources.sort_az__1_;
                refeshView(data.OrderBy(book => book.Title).ToList());
            }
            else
            {
                this.btnSortName.Image = global::App_Library.Properties.Resources.sort_az;
                refeshView(data.OrderByDescending(book => book.Title).ToList());
            }
            btnDeleteSort.Visible = true;
        }

        private void ViewBookForm_Load(object sender, EventArgs e)
        {
            refeshView(data);

        }
        public void refeshView(List<Book> models)
        {
            LoadingForm loadingForm = new LoadingForm();
            loadingForm.Show();
            pnContain.Controls.Clear();
            for (int i= 0; i< models.Count; i++)
            {
                pnContain.Controls.Add(controller.createPanel(models[i], i, null));
            }
            pnContain.AutoScroll = true;
            loadingForm.Hide();
            loadingForm.Close();
        }

        private void btnSortPrice_Click(object sender, EventArgs e)
        {
            SortPrice = !SortPrice;
            if (SortPrice)
            {
                this.btnSortPrice.Image = global::App_Library.Properties.Resources.money_growth;
                refeshView(data.OrderByDescending(book => book.Price).ToList());
            }
            else
            {
                this.btnSortPrice.Image = global::App_Library.Properties.Resources.cheap;
                refeshView(data.OrderBy(book => book.Price).ToList());
            }
            btnDeleteSortPrice.Visible = true;
            
        }

        private void btnDeleteSort_Click(object sender, EventArgs e)
        {
            refeshView(dataSource);
            btnDeleteSort.Visible = false;
            this.btnSortName.Image = global::App_Library.Properties.Resources.sort_az;
        }
        private void btnDeleteSortForPrice_Click(object sender, EventArgs e)
        {
            refeshView(dataSource);
            btnDeleteSortPrice.Visible = false;
            this.btnSortPrice.Image = global::App_Library.Properties.Resources.cheap;
        }
        Form formAct;
        private void btnBack_Click(object sender, EventArgs e)
        {
            activeFormChild(controller.parent.pnContent, new NewShopMain(controller.parent), null, ref formAct);
        }
    }
}

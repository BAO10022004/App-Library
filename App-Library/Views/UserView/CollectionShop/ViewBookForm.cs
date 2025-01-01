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
        bool SortnameAz = false;
        bool SortnameZa = false;
        bool SortPriceIncrease = false;
        bool SortPriceReduce = false;
        List<Book> data;
        List<Book> dataSource;
        NewShopMain controller;
        public ViewBookForm(NewShopMain controller, List<Book> models)
        {
            InitializeComponent();
            this.data = models;
            this.controller = controller;
            dataSource = models;
        }

        private void btnSortName_Click(object sender, EventArgs e)
        {
            btnDeleteSortPrice.Visible = false;
            if((!SortnameAz && !SortnameZa) || SortnameZa)
            {
                SortnameAz = true;
                SortnameZa = false;
                this.btnSortName.Image = global::App_Library.Properties.Resources.sort_az__1_;
                data = data.OrderByDescending(book => book.Title).ToList();
                refeshView(data);
            }
            else 
            {
                SortnameZa = true;
                SortnameAz = false;
                this.btnSortName.Image = global::App_Library.Properties.Resources.sort_az;
                data = data.OrderBy(book => book.Title).ToList();
                refeshView(data);
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
            btnDeleteSort.Visible = false;
            if ((!SortPriceIncrease && !SortPriceReduce) || SortPriceIncrease)
            {
                SortPriceReduce = true;
                SortPriceIncrease = false;
                this.btnSortPrice.Image = global::App_Library.Properties.Resources.money_growth;
                data = data.OrderBy(book => book.Price).ToList();
                refeshView(data);
            }
            else
            {
                SortPriceReduce = false;
                SortPriceIncrease = true;
                this.btnSortPrice.Image = global::App_Library.Properties.Resources.cheap;
                data = data.OrderByDescending(book => book.Price).ToList();
                refeshView(data);
            }
            btnDeleteSortPrice.Visible = true;
            
        }

        private void btnDeleteSort_Click(object sender, EventArgs e)
        {
            SortnameAz = false;
            SortnameZa = false;
            SortPriceIncrease = false;
            SortPriceReduce = false;
            refeshView(dataSource);
            btnDeleteSort.Visible = false;
            this.btnSortName.Image = global::App_Library.Properties.Resources.sort_az;
        }
        private void btnDeleteSortForPrice_Click(object sender, EventArgs e)
        {
            SortnameAz = false;
            SortnameZa = false;
            SortPriceIncrease = false;
            SortPriceReduce = false;
            refeshView(dataSource);
            btnDeleteSortPrice.Visible = false;
            this.btnSortPrice.Image = global::App_Library.Properties.Resources.cheap;
        }
        Form formAct;
        private void btnBack_Click(object sender, EventArgs e)
        {
            activeFormChild(controller.controller.pnContent, new NewShopMain(controller.controller), null, ref formAct);
        }
    }
}

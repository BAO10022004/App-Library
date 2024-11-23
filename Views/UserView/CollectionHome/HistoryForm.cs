using App_Library.Models;
using App_Library.Services;
using Guna.UI2.WinForms;
using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library.Views.UserView.CollectionHome
{
    public partial class HistoryForm : Form
    {
        List<BookSold> BookSolds;
        public  HistoryForm(List<BookSold> bookSolds)
        {
            
            InitializeComponent();
            this.BookSolds = bookSolds;

        }
        Label newLabel(string name, bool isStatus = false)
        {
            Label result = new Label();
            result.AutoSize = false;
            result.Dock = System.Windows.Forms.DockStyle.Fill;
            result.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            if (isStatus)
            {
                if (name.Equals("Approved"))
                    result.ForeColor = System.Drawing.Color.Green;
                else
                    result.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                result.ForeColor = System.Drawing.Color.DimGray;
            }

            
            result.Location = new System.Drawing.Point(0, 0);
            result.Name = name;
            result.Size = new System.Drawing.Size(140, 61);
            result.TabIndex = 0;
            result.Text = name;
            result.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            return result;
        }
        Guna2Button newButton(string name)
        {
            Guna2Button result = new Guna2Button();
            result.BorderRadius = 5;
            result.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            result.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            result.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            result.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            result.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            result.ForeColor = System.Drawing.Color.White;
            result.Location = new System.Drawing.Point(5,15);
            result.Name = name;
            result.Size = new System.Drawing.Size(111, 34);
            result.TabIndex = 0;
            result.Text = "Remind";
            result.Click += new EventHandler(this.sendMail);
            return result;
        }
        private async void HistoryForm_Load(object sender, EventArgs e)
        {
            BookService bookService = new BookService();
            tableLayoutPanel1.RowCount += BookSolds.Count;
            for (int i = 0; i < BookSolds.Count; i++)
            {
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.42282F));
                Book book = await bookService.GetBookBySlugAsync(BookSolds[i].Slug);
                this.tableLayoutPanel1.Controls.Add(newLabel(book.Title), 0, i);
                this.tableLayoutPanel1.Controls.Add(newLabel(book.Author), 1, i);
                this.tableLayoutPanel1.Controls.Add(newLabel(book.Price + "$"), 2, i);
                this.tableLayoutPanel1.Controls.Add(newLabel(BookSolds[i].Status, true), 3, i);
                this.tableLayoutPanel1.Controls.Add(newLabel(BookSolds[i].UpdatedAt.ToString()), 4, i);
                if(!BookSolds[i].Status.Equals("Approved"))
                {
                    this.tableLayoutPanel1.Controls.Add(newButton(book.Title), 5, i);
                }

            }
        }

        private void label1_Resize(object sender, EventArgs e)
        {

        }

        private void HistoryForm_Resize(object sender, EventArgs e)
        {
            pnBookName.Width =Convert.ToInt32(this.Width * 0.226);
            pnAuthor.Width = Convert.ToInt32(this.Width * 0.166);
            pnPrice.Width = Convert.ToInt32(this.Width * 0.14);
            pnStatus.Width = Convert.ToInt32(this.Width * 0.13);
            pnTime.Width = Convert.ToInt32(this.Width * 0.19);
        }
        private void sendMail(object sender, EventArgs e)
        {
           
        }
    }
}

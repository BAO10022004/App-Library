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
using Org.BouncyCastle.Crypto.Macs;
using App_Library.Views.ToolerForm;
using Firebase.Auth;

namespace App_Library.Views.UserView.CollectionHome
{
    public partial class HistoryForm : FormHelper
    {
        List<BookSold> BookSolds;
        String mailPassword;
        public  HistoryForm(List<BookSold> bookSolds)
        {
            BookSolds = new List<BookSold>();
            InitializeComponent();
            foreach(BookSold book in bookSolds)
            {
                if(book.Slug != null)
                {
                    this.BookSolds.Add(book);
                }
            }
           

        }
        Label newLabel(string name, bool isStatus = false)
        {
            Label result = new Label();
            result.AutoSize = false;
            result.Dock = System.Windows.Forms.DockStyle.Fill;
            result.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            result.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //result.Padding = new Padding(0,10, 0, 0);
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
            //result.Size = new System.Drawing.Size(111, 34);
            result.TabIndex = 0;
            result.Text = "Remind";
            result.Click += new EventHandler(this.sendMail);
            result.Size = new System.Drawing.Size(90, 30); // Thay đổi kích thước để phù hợp với hàng
            result.Anchor = AnchorStyles.Top; // Trung tâm trong ô

            return result;
        }
        private void HistoryForm_Load(object sender, EventArgs e)
        {
            
            for(int i=0; i< BookSolds.Count; i++)
            {
                pnListProcessing.Controls.Add(this.createPanel(BookSolds[i], i));
            }
        }
        Guna2Panel createPanel(BookSold bookSold, int index)
        {
            Form form = null;   
            Guna2Panel gn = new Guna2Panel();
            gn.Size = new System.Drawing.Size(1023, 64);
            gn.Name = bookSold.Title;
            gn.TabIndex = index;
            activeFormChild(gn,new  HistoryChild(this, bookSold), null, ref form);
            return gn;
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
        void actionSendMail()
        {
            {

            }
        }
        public async void sendMail(object sender, EventArgs e)
        {
            UserService user = new UserService();
            sendMail("My name is " + (await user.GetCurrentUserAsync()).Username + "\n" +
                           "My mail is " + (await user.GetCurrentUserAsync()).Email + "\n" +
                           "Plese you approved my book !!!!!!", "Giabaoonthcs123@gmail.com");
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
     
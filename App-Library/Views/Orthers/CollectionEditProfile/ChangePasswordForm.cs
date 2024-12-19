using App_Library.Models;
using App_Library.Views.ToolerForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library.Views.Orthers.CollectionEditProfile
{
    public partial class ChangePasswordForm : FormHelper
    {
        Form actForm;
        User user;
        public ChangePasswordForm(User user)
        {
            InitializeComponent();
            this.user = user;
            if (user == null)
                //nextPage(new ChangePasswordCollection.ConfirmPasswordForm(user, this));
            nextPage(new ChangePasswordCollection.ConfirmPasswordForm(user, this));
        }

        private async void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            if (user != null)
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var imageBytes = await client.GetByteArrayAsync(user.PhotoURL);
                        using (var ms = new System.IO.MemoryStream(imageBytes))
                        {
                            picAvatar.Image = System.Drawing.Image.FromStream(ms);
                        }
                    }
                }
                catch (Exception)
                {
                }
                lbUserName.Text = user.Username;
                lbEmail.Text = user.Email;
            }
        }

        public async void updateFrame(User userUpdate)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var imageBytes = await client.GetByteArrayAsync(userUpdate.PhotoURL);
                    using (var ms = new System.IO.MemoryStream(imageBytes))
                    {
                        picAvatar.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("LOI");
            }
            lbUserName.Text = userUpdate.Username;
            lbEmail.Text = userUpdate.Email;
        }

        public void nextPage(Form form)
        {
            activeFormChild(pnInformation, form, null, ref actForm);
        }
    }
}

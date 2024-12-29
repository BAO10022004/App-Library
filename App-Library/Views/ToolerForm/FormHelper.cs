using Amazon.Auth.AccessControlPolicy;
using App_Library.Models;
using App_Library.Services;
using App_Library.Views.UserView.CollectionHome;
using Firebase.Auth;
using FirebaseAdmin.Messaging;
using Guna.Charts.WinForms;
using Guna.UI2.WinForms;
using MongoDB.Libmongocrypt;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Numerics;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using WMPLib;
namespace App_Library.Views.ToolerForm
{
    public class FormHelper : Form
    {
        Form ActForm;
        public void activeFormChild(System.Windows.Forms.Control ctrlSource, Form formDes)
        {
            // Kiểm tra nếu ActForm khác null và đã tồn tại, đóng nó
            if (ActForm != null && !ActForm.IsDisposed)
            {
                ActForm.Close();
            }

            // Thiết lập form mới vào ActForm
            ActForm = formDes;
            formDes.TopLevel = false;
            formDes.FormBorderStyle = FormBorderStyle.None;
            formDes.Dock = DockStyle.Fill;
            // formDes.BackColor = Color.Blue;
            // Thêm form vào Control và hiển thị
            ctrlSource.Controls.Add(formDes);
            ctrlSource.Tag = formDes;
            formDes.BringToFront();
            formDes.Show();
        }
        public void activeFormChild(System.Windows.Forms.Control ctrlSource, Form formDes, object obj)
        {
            // Kiểm tra nếu ActForm khác null và đã tồn tại, đóng nó
            if (ActForm != null && !ActForm.IsDisposed)
            {
                ActForm.Close();
            }

            // Thiết lập form mới vào ActForm
            ActForm = formDes;
            formDes.TopLevel = false;
            formDes.FormBorderStyle = FormBorderStyle.None;
            formDes.Dock = DockStyle.Fill;
            //formDes.BackColor = Color.Blue;
            // Thêm form vào Control và hiển thị
            ctrlSource.Controls.Add(formDes);
            ctrlSource.Tag = formDes;
            formDes.BringToFront();
            formDes.Show();
        }
        // Lưu lại các Control trong Panel để có thể quay lại sau đó
        private Stack<System.Windows.Forms.Control> controlHistory = new Stack<System.Windows.Forms.Control>();

        public void activeFormChild(System.Windows.Forms.Control ctrlSource, Form formDes, object obj, ref Form actForm)
        {
            // Kiểm tra nếu actForm khác null và đã tồn tại, đóng nó
            if (actForm != null && !actForm.IsDisposed)
            {
                actForm.Close();
            }



            // Thiết lập form mới vào actForm
            actForm = formDes;
            formDes.TopLevel = false;
            formDes.FormBorderStyle = FormBorderStyle.None;
            formDes.Dock = DockStyle.Fill;

            // Thêm form vào Control và hiển thị
            ctrlSource.Controls.Add(formDes);
            ctrlSource.Tag = formDes;
            formDes.BringToFront();
            formDes.Show();
        }
        public void BackToPreviousControls(System.Windows.Forms.Control ctrlSource)
        {
            // Xóa tất cả các control hiện tại trong panel
            ctrlSource.Controls.Clear();

            // Thêm lại các control đã lưu trong controlHistory
            while (controlHistory.Count > 0)
            {
                System.Windows.Forms.Control control = controlHistory.Pop();
                ctrlSource.Controls.Add(control);
            }

            // Đảm bảo rằng panel sẽ tự động điều chỉnh kích thước và hiển thị lại các control
            ctrlSource.Refresh();
        }

        public System.Windows.Forms.Control FindControlContainer(System.Windows.Forms.Control.ControlCollection listControl, System.Windows.Forms.Control control)
        {
            System.Windows.Forms.Control result = new System.Windows.Forms.Control();
            foreach (System.Windows.Forms.Control panel in listControl)
            {
                if(control is System.Windows.Forms.Panel || control is Guna2Panel)
                {
                    var item = (System.Windows.Forms.Panel)panel;
                    foreach (var c in item.Controls)
                    {
                        var itemControl = (System.Windows.Forms.Control)c;
                        if (itemControl.Name.Equals(control.Name))
                        {
                            return panel;
                        }
                    }
                }
                
            }
            return result;
        }
        
        public async void loadImageAsync(PictureBox pic, String image)

        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var imageBytes = await client.GetByteArrayAsync(image);
                    using (var ms = new System.IO.MemoryStream(imageBytes))
                    {
                        pic.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
            }
            catch (Exception)
            {

            }
        }
      
        public  void sendMailRemind(string username,string bookTitle, HistoryChild parent)
        {

            try
            {

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("giabaoonutc2@gmail.com", "zaxhlxwulmedygre"),
                    EnableSsl = true
                };

                MailMessage mail = new MailMessage
                {
                    From = new MailAddress("giabaoonutc2@gmail.com"),
                    Subject = "REMIND APPROVE",
                    Body = "Please approve my order"+"\n"
                          +"My name is" +username + "\n"
                          +"Book is" + bookTitle + "\n",
                    IsBodyHtml = false
                };

                mail.To.Add("Giabaoonthcs123@gmail.com");

                smtpClient.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public  bool sendMailOtp(string body, string mailTo)
        {

            try
            {

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("giabaoonutc2@gmail.com", "zaxhlxwulmedygre"),
                    EnableSsl = true
                };

                MailMessage mail = new MailMessage
                {
                    From = new MailAddress("giabaoonutc2@gmail.com"),
                    Subject = "READ BOOK APP",
                    Body = body,
                    IsBodyHtml = false
                };

                mail.To.Add(mailTo);

                smtpClient.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void playMusic(string url)
        {

        }
    }

}

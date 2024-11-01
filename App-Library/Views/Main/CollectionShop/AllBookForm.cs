using App_Library.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library.Views.Main.CollectionShop
{
    public partial class AllBookForm : Form
    {
        ShopForm shopForm;
        List<Panel> listPanelBook;
        int count;
        int index = 0;
        int countGenerateFail = 0;
        int currentPage = 1;
        public AllBookForm()
        {
            InitializeComponent();
        }

        public AllBookForm(List<Panel> listPanelBook, ShopForm shopForm)
        {
            InitializeComponent();
            this.listPanelBook = listPanelBook;
            this.shopForm = shopForm;
            // Genegate Book

            if (listPanelBook.Count > 10)
            {
                count = 10;
            }
            else
            {
                count = listPanelBook.Count;
            }

            for (index = 0; index < count; index++)
            {
                if (index == listPanelBook.Count)
                {
                    break;
                }
                //Book book = ;
                Panel panel = listPanelBook[index];
                if (panel == null)
                {
                    count++;
                    countGenerateFail++;
                    continue;
                }
                LPGroupAllBook.Controls.Add(panel);
            }

        }
        public Guna2Panel CreateBookPanelForThis(Book book, int index, int rating = 4)
        {
            // Tạo panel mới với kích thước cố định
            Guna2Panel panel = new Guna2Panel();
            panel.Size = new Size(200, 350); // Kích thước giữ nguyên

            panel.BackColor = Color.FromArgb(240, 240, 255); // Màu nền tương tự hình

            // Thêm hình ảnh sách (tăng kích thước)
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(180, 270); // Tăng kích thước ảnh lớn hơn
            pictureBox.Location = new Point(10, 0); // Đặt ở góc trái của Panel
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Hiển thị ảnh đúng tỷ lệ mà không bị méo

            // Tải hình ảnh từ URL
            try
            {
                pictureBox.Load(book.Image); // Đường dẫn hoặc URL của ảnh
            }
            catch (Exception)
            {
                // Nếu có lỗi khi tải ảnh, có thể đặt ảnh mặc định hoặc để trống
                return null; // Ảnh trống kích thước 300x335
            }
            panel.Controls.Add(pictureBox);

            // Thêm nhãn số sao đánh giá
            Label ratingLabel = new Label();
            ratingLabel.Text = $"{rating} ★"; // Hiển thị số sao và biểu tượng ngôi sao
            ratingLabel.Location = new Point(75, 285); // Giảm kích thước thông tin
            ratingLabel.AutoSize = true;
            ratingLabel.Font = new Font("Arial", 9, FontStyle.Bold); // Giảm kích thước font chữ
            ratingLabel.Name = "rating" + index;
            panel.Controls.Add(ratingLabel);

            // Tạo nhãn tên sách (giảm kích thước hiển thị)
            Label titleLabel = new Label();
            titleLabel.Text = book.Title;
            titleLabel.Location = new Point(10, 305); // Giảm kích thước hiển thị của nhãn sách
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Arial", 10, FontStyle.Bold); // Giảm kích thước font chữ
            titleLabel.Name = "titleLabel" + index;
            panel.Controls.Add(titleLabel);

            // Tạo nhãn tên tác giả (giảm kích thước hiển thị)
            Label authorLabel = new Label();
            authorLabel.Text = book.Author;
            authorLabel.Location = new Point(10, 325);
            authorLabel.AutoSize = true;
            authorLabel.Font = new Font("Arial", 9); // Giảm kích thước font chữ
            authorLabel.Name = "authorLabel" + index;
            panel.Controls.Add(authorLabel);
            panel.Margin = new Padding(5);
            panel.Name = "itemHotDeal" + index;
            panel.TabIndex = index;

            //foreach (Control control in panel.Controls)
            //{
            //    control.MouseHover += new EventHandler(shopForm.LPHotDeal_MouseHover);
            //    control.MouseLeave += new EventHandler(this.LPHotDeal_MouseLeave);
            //    control.Click += new EventHandler(this.bookHotDeal_Click);
            //}
            //panel.BackColor = Color.White;
            //panel.MouseHover += new EventHandler(this.LPHotDeal_MouseHover);
            //panel.MouseLeave += new EventHandler(this.LPHotDeal_MouseLeave);
            //panel.Click += new EventHandler(this.bookHotDeal_Click);
            return panel;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }



        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }
        void UpdateNumberPage()
        {

            if (index - countGenerateFail <= listPanelBook.Count)
            {
                lbPage.Text = "1 Trên 1";
            }
            else
            {
                if (listPanelBook.Count % (index - countGenerateFail) == 0)
                {
                    lbPage.Text = currentPage + " Trên " + listPanelBook.Count / (index - countGenerateFail);
                }
                else
                {
                    lbPage.Text = currentPage + " Trên " + listPanelBook.Count / (index - countGenerateFail + 1);
                }
            }
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            currentPage++;
            gnpGruopAllBook.Controls.Clear();
            if (listPanelBook.Count > 10)
            {
                count += 10;
            }
            else
            {
                count += listPanelBook.Count;
            }

            for (; index < count; index++)
            {
                if (index == listPanelBook.Count)
                {
                    break;
                }
                Book book;
                Panel panel = listPanelBook[index];
                if (panel == null)
                {
                    count++;
                    countGenerateFail++;
                    continue;
                }
                LPGroupAllBook.Controls.Add(panel);
            }
            UpdateNumberPage();
        }
    }
}

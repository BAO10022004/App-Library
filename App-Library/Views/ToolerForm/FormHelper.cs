using App_Library.Models;
//using App_Library.Services;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace App_Library.Views.ToolerForm
{
    public class FormHelper : Form
    {
         Form ActForm;
        public  void activeFormChild(System.Windows.Forms.Control ctrlSource,Form formDes,object obj)
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
        public System.Windows.Forms.Control FindControlContainer(System.Windows.Forms.Control.ControlCollection listControl, System.Windows.Forms.Control control)
        {
            System.Windows.Forms.Control result = new System.Windows.Forms.Control();
            foreach (System.Windows.Forms.Control panel in listControl)
            {
                var item = (Panel)panel;
                foreach (var c in item.Controls)
                {
                    var itemControl  = (System.Windows.Forms.Control)c; 
                    if(itemControl.Name.Equals(control.Name))
                    {
                        return panel;
                    }
                }
            }
            return result;
        }
        public Image GetImageFromResources(string imageName)
        {
            ResourceManager rm = Properties.Resources.ResourceManager;
            object image = rm.GetObject(imageName);
            return image as Image;
        }
        public Panel CreateBookAdPanel(Book book, int index, int rank = 4)
        {
            // Tạo Panel với kích thước cố định 1259 x 335
            Panel panel = new Panel();
            panel.Size = new Size(1037, 294);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.BackColor = Color.FromArgb(245, 245, 245); // Màu nền nhẹ nhàng

            // Thêm PictureBox để hiển thị hình ảnh của cuốn sách
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(300, 335); // Kích thước cố định cho hình ảnh
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

            // Tạo phần chứa thông tin sách bên phải ảnh
            int infoStartX = 330; // Bắt đầu phần thông tin sau hình ảnh (300 + 30 khoảng trống)

            // Thêm tiêu đề sách với kích thước lớn hơn và màu sắc nổi bật
            Label titleLabel = new Label();
            titleLabel.Text = book.Title;
            titleLabel.Location = new Point(infoStartX, 20);
            titleLabel.AutoSize = false;
            titleLabel.Size = new Size(900, 50); // Đặt kích thước cố định để kiểm soát dòng chữ
            titleLabel.Font = new Font("Arial", 18, FontStyle.Bold); // Tăng kích thước font
            titleLabel.ForeColor = Color.FromArgb(34, 34, 34);
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            panel.Controls.Add(titleLabel);

            // Thêm tên tác giả với màu xám nhẹ
            Label authorLabel = new Label();
            authorLabel.Text = $"Author: {book.Author}";
            authorLabel.Location = new Point(infoStartX, 80);
            authorLabel.AutoSize = false;
            authorLabel.Size = new Size(900, 30);
            authorLabel.Font = new Font("Arial", 14, FontStyle.Italic); // Tăng kích thước font
            authorLabel.ForeColor = Color.FromArgb(100, 100, 100);
            authorLabel.TextAlign = ContentAlignment.MiddleLeft;
            panel.Controls.Add(authorLabel);

            // Thêm nhãn giá với màu sắc nổi bật và kích thước chữ lớn hơn
            Label priceLabel = new Label();
            priceLabel.Text = $"Price: ${book.Price}";
            priceLabel.Location = new Point(infoStartX, 120);
            priceLabel.AutoSize = false;
            priceLabel.Size = new Size(900, 35);
            priceLabel.Font = new Font("Arial", 16, FontStyle.Bold); // Tăng kích thước font
            priceLabel.ForeColor = Color.FromArgb(0, 153, 51); // Màu xanh lá nổi bật
            priceLabel.TextAlign = ContentAlignment.MiddleLeft;
            panel.Controls.Add(priceLabel);

            // Thêm nhãn xếp hạng (rank) với biểu tượng sao màu cam
            Label rankLabel = new Label();
            rankLabel.Text = $"Rank: {rank} ★";
            rankLabel.Location = new Point(infoStartX, 160);
            rankLabel.AutoSize = false;
            rankLabel.Size = new Size(900, 35);
            rankLabel.Font = new Font("Arial", 16, FontStyle.Bold); // Tăng kích thước font
            rankLabel.ForeColor = Color.FromArgb(255, 140, 0); // Màu cam cho xếp hạng
            rankLabel.TextAlign = ContentAlignment.MiddleLeft;
            panel.Controls.Add(rankLabel);

            // Thêm mô tả ngắn về sách (nếu có) để lấp đầy khoảng trống
            Label descriptionLabel = new Label();
            descriptionLabel.Text = book.Content.Length > 100 ? book.Content.Substring(0, 100) + "..." : book.Content;
            descriptionLabel.Location = new Point(infoStartX, 210);
            descriptionLabel.AutoSize = false;
            descriptionLabel.Size = new Size(900, 100); // Kích thước lớn hơn để hiển thị nội dung dài
            descriptionLabel.Font = new Font("Arial", 12, FontStyle.Regular);
            descriptionLabel.ForeColor = Color.FromArgb(34, 34, 34);
            descriptionLabel.TextAlign = ContentAlignment.TopLeft;
            descriptionLabel.MaximumSize = new Size(900, 100); // Giới hạn chiều cao mô tả
            panel.Controls.Add(descriptionLabel);
            panel.Cursor = System.Windows.Forms.Cursors.Hand;
            panel.BorderStyle = BorderStyle.None;
            panel.Name = book.Username;
            return panel;
        }
        public async Task<Panel> CreateBookPanelAsync(Book book, int index, int rating = 4)
        {
            // Tạo panel mới với kích thước cố định
            Guna2Panel panel = new Guna2Panel();
            panel.Size = new Size(200, 350); // Kích thước giữ nguyên

            panel.BackColor = Color.FromArgb(240, 240, 255); // Màu nền tương tự hình

            // Thêm hình ảnh sách (tăng kích thước)
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(180, 270); // Tăng kích thước ảnh lớn hơn
            pictureBox.Location = new Point(10, 10);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Name = "pictureBox" + index;
            // Load hình ảnh từ URL không đồng bộ
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var imageBytes = await client.GetByteArrayAsync(book.Image);
                    using (var ms = new System.IO.MemoryStream(imageBytes))
                    {
                        pictureBox.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception)
            {
                return null;
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

            
            return panel;
        }

    }

}

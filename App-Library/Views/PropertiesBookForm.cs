using App_Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace App_Library.Views
{
    public partial class PropertiesBookForm : Form
    {
        public PropertiesBookForm(Book book)
        {
            InitializeComponent();
            pnBuy.BackColor = Color.Transparent;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Hiển thị ảnh đúng tỷ lệ mà không bị méo

            // Tải hình ảnh từ URL
            try
            {
                pictureBox1.Load(book.Image); // Đường dẫn hoặc URL của ảnh
            }
            catch (Exception)
            {
                // Nếu có lỗi khi tải ảnh, có thể đặt ảnh mặc định hoặc để trống
                
            }
            lbPrice.Text += book.Price +"$";
            lbNameBook.Text += book.Title;
            lbPublishedYear.Text += "" +book.PublishedYear;
            lbAuthor.Text += "" + book.Author;
            lbCategory.Text += "" + book.Genre;
        }

        private void lbNameBook_Click(object sender, EventArgs e)
        {

        }

        private void lbCategory_Click(object sender, EventArgs e)
        {

        }

        private void lbAuthor_Click(object sender, EventArgs e)
        {

        }

        private void pnBuy_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

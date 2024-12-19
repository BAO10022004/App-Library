using App_Library.Models;
using App_Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library.Views.AdminView.CollectionHistory
{
    public partial class HistoryForm : Form
    {
        private BookSoldService _bookSoldService;
        private List<BookSold> _bookSolds;
        private int curentPage = 1;
        private int countLine = 0;
        private float totalPage = 0;
        public HistoryForm()
        {
            InitializeComponent();
            _bookSoldService = new BookSoldService();

            cbbSoDong.SelectedIndex = 0;
            cbbSapXep.SelectedIndex = 0;
            cbbCot.DataSource = typeof(BookSold).GetProperties().Select(prop => prop.Name).ToList();
            cbbCot.SelectedIndex = 0;

            if (curentPage == 1)
            {
                btnTrangTruoc.Enabled = false;
                btnTrangKe.Enabled = true;
            }

            LoadData();
        }

        private async void LoadData()
        {
            if (_bookSolds == null)
            {
                _bookSolds = await _bookSoldService.GetBooksSoldAsync();
            }

            var count = _bookSolds.Count;
            countLine = int.Parse(cbbSoDong.SelectedItem.ToString());
            totalPage = (float)count / countLine;
            totalPage = totalPage > (int)totalPage ? (int)totalPage + 1 : (int)totalPage;

            if (cbbCot.SelectedItem == null)
            {
                return;
            }

            var columnName = cbbCot.SelectedItem.ToString();
            var sortOrder = cbbSapXep.SelectedItem.ToString();
            if (sortOrder == "Tăng dần")
            {
                _bookSolds = _bookSolds.OrderBy(c => c.GetType().GetProperty(columnName)?.GetValue(c, null)).ToList();
            }
            else if (sortOrder == "Giảm dần")
            {
                _bookSolds = _bookSolds.OrderByDescending(c => c.GetType().GetProperty(columnName)?.GetValue(c, null)).ToList();
            }

            var lstBookSoldView = _bookSolds.Select(n => new { TimeStamp = n.CreatedAt, Bookname = n.Title, Price = n.Price, Username = n.Username, Email = n.Email, Status = n.Status }).Skip(countLine * (curentPage - 1)).Take(countLine).ToList();

            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns["Bookname"].DataPropertyName = "Bookname";
            dataGridView.Columns["Price"].DataPropertyName = "Price";
            dataGridView.Columns["Username"].DataPropertyName = "Username";
            dataGridView.Columns["Email"].DataPropertyName = "Email";
            dataGridView.Columns["Status"].DataPropertyName = "Status";
            dataGridView.Columns["TimeStamp"].DataPropertyName = "TimeStamp";
            dataGridView.DataSource = lstBookSoldView;

            if (countLine > count)
            {
                btnTrangTruoc.Enabled = false;
                btnTrangKe.Enabled = false;
                pnContent.Size = new Size(pnContent.Size.Width, 30 * (count + 1) + 40);
            }
            else
            {
                if (curentPage == 1)
                {
                    btnTrangKe.Enabled = true;
                }
                pnContent.Size = new Size(pnContent.Size.Width, 30 * (countLine + 1) + 40);
            }
            lblSoTrang.Text = $"{curentPage}/{totalPage}";
        }

        private void btnTrangTruoc_Click(object sender, EventArgs e)
        {
            if (curentPage > 1)
            {
                curentPage--;
                if (!btnTrangKe.Enabled)
                {
                    btnTrangKe.Enabled = true;
                }
            }
            if (curentPage == 1)
            {
                btnTrangTruoc.Enabled = false;
            }

            LoadData();
        }

        private void btnTrangKe_Click(object sender, EventArgs e)
        {
            if (curentPage < totalPage)
            {
                curentPage++;
                if (!btnTrangTruoc.Enabled)
                {
                    btnTrangTruoc.Enabled = true;
                }
            }
            if (curentPage == totalPage)
            {
                btnTrangKe.Enabled = false;
            }

            LoadData();
        }

        private void cbbSoDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            curentPage = 1;
            LoadData();
        }

        private void cbbSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cbbCot_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        private void dataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dataGridView.ClearSelection();
                dataGridView.Rows[e.RowIndex].Selected = true;
                contextMenuStrip.Show(dataGridView, dataGridView.PointToClient(Cursor.Position));
            }
        }

        private async void btnTimKiem_ClickAsync(object sender, EventArgs e)
        {
            _bookSolds = await _bookSoldService.GetPendingBooksSoldAsync();
            LoadData();
        }

        private async void txbTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                _bookSolds = await _bookSoldService.GetPendingBooksSoldAsync();
                LoadData();
            }
        }

        private void txbTimKiem_Click(object sender, EventArgs e)
        {
            if (txbTimKiem.Text == "Search")
            {
                txbTimKiem.Text = string.Empty;
                txbTimKiem.ForeColor = Color.Black;
            }
        }

        private void txbTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbTimKiem.Text) || txbTimKiem.Text == "Search")
            {
                txbTimKiem.Text = "Search";
                txbTimKiem.ForeColor = Color.DarkGray;
            }
        }
    }
}

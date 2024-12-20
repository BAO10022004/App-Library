﻿using App_Library.Models;
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

namespace App_Library.Views.AdminView.CollectionPending
{
    public partial class PendingForm : Form
    {
        private BookSoldService _bookSoldService;
        private List<BookSold> _bookSolds;
        private int curentPage = 1;
        private int countLine = 0;
        private float totalPage = 0;
        public PendingForm()
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
            if (_bookSolds == null || string.IsNullOrWhiteSpace(txbTimKiem.Text) && txbTimKiem.Text == "Search")
            {
                _bookSolds = await _bookSoldService.GetPendingBooksSoldAsync();
            }

            if (!string.IsNullOrWhiteSpace(txbTimKiem.Text) && txbTimKiem.Text != "Search")
            {
                var fillterSearch = _bookSolds.Where(n => n.Id.Contains(txbTimKiem.Text) || n.Username.Contains(txbTimKiem.Text) || n.Title.Contains(txbTimKiem.Text) || n.Email.Contains(txbTimKiem.Text)).ToList();
                if (fillterSearch == null)
                {
                    MessageBox.Show("Không tìm thấy kết quả");
                    return;
                }
                _bookSolds = fillterSearch;
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

            var lstBookSoldView = _bookSolds.Select(n => new { ID = n.Id, TimeStamp = n.CreatedAt, Bookname = n.Title, Price = n.Price, Username = n.Username, Email = n.Email }).Skip(countLine * (curentPage - 1)).Take(countLine).ToList();

            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns["ID"].DataPropertyName = "ID";
            dataGridView.Columns["TimeStamp"].DataPropertyName = "TimeStamp";
            dataGridView.Columns["Bookname"].DataPropertyName = "Bookname";
            dataGridView.Columns["Price"].DataPropertyName = "Price";
            dataGridView.Columns["Username"].DataPropertyName = "Username";
            dataGridView.Columns["Email"].DataPropertyName = "Email";
            dataGridView.Columns["Action"].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dataGridView.Columns["Action2"].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dataGridView.Columns["Action"].Width = 100;
            dataGridView.Columns["Action2"].Width = 100;
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

        private async void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView.Rows[e.RowIndex];
            var id = row.Cells["ID"].Value.ToString();
            // Duyệt
            if (e.ColumnIndex == dataGridView.Columns["Action"].Index && e.RowIndex >= 0)
            {
                var result = await _bookSoldService.ApproveBookSoldAsync(id);
                if (result)
                {
                    MessageBox.Show("Đã duyệt thành công");
                    _bookSolds = await _bookSoldService.GetPendingBooksSoldAsync();
                }
                else
                {
                    MessageBox.Show("Không thể duyệt");
                }
            }
            // Từ chối
            if (e.ColumnIndex == dataGridView.Columns["Action2"].Index && e.RowIndex >= 0)
            {
                var result = await _bookSoldService.RejectBookSoldAsync(id);
                if (result)
                {
                    MessageBox.Show("Đã từ chối thành công");
                    _bookSolds = await _bookSoldService.GetPendingBooksSoldAsync();
                }
                else
                {
                    MessageBox.Show("Không thể từ chối");
                }
            }
            LoadData();
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

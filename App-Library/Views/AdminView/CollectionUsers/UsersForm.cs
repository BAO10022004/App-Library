using App_Library.Models;
using App_Library.Services;
using App_Library.Views.AdminView.CollectionBooks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library.Views.AdminView.CollectionUsers
{
    public partial class UsersForm : Form
    {
        private UserService _userService;
        private List<User> _users;
        private int curentPage = 1;
        private int countLine = 0;
        private float totalPage = 0;
        public UsersForm()
        {
            InitializeComponent();
            _userService = new UserService();

            cbbSoDong.SelectedIndex = 0;
            cbbSapXep.SelectedIndex = 0;
            cbbCot.DataSource = typeof(User).GetProperties().Select(prop => prop.Name).ToList();
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
            if (_users == null)
            {
                _users = await _userService.GetUsersAsync();
            }

            var count = _users.Count;
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
                _users = _users.OrderBy(c => c.GetType().GetProperty(columnName)?.GetValue(c, null)).ToList();
            }
            else if (sortOrder == "Giảm dần")
            {
                _users = _users.OrderByDescending(c => c.GetType().GetProperty(columnName)?.GetValue(c, null)).ToList();
            }

            var lstUserView = _users.Select(n => new { ID = n.Id, Username = n.Username, Email = n.Email, Activate = n.IsActive, Admin = n.IsAdmin }).Skip(countLine * (curentPage - 1)).Take(countLine).ToList();

            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns["ID"].DataPropertyName = "ID";
            dataGridView.Columns["Username"].DataPropertyName = "Username";
            dataGridView.Columns["Email"].DataPropertyName = "Email";
            dataGridView.Columns["Activate"].DataPropertyName = "Activate";
            dataGridView.Columns["Admin"].DataPropertyName = "Admin";
            dataGridView.Columns["Action"].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dataGridView.Columns["Action2"].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dataGridView.Columns["Action"].Width = 100;
            dataGridView.Columns["Action2"].Width = 100;
            dataGridView.DataSource = lstUserView;

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
            // kích hoạt
            if (e.ColumnIndex == dataGridView.Columns["Action"].Index && e.RowIndex >= 0)
            {
                var result = await _userService.ActivateUserAsync(id);
                if (result)
                {
                    MessageBox.Show("Đã kích hoạt người dùng");
                    _users = await _userService.GetUsersAsync();
                }
                else
                {
                    MessageBox.Show("Không thể kích hoạt người dùng");
                }
            }
            // Ngừng hoạt động
            if (e.ColumnIndex == dataGridView.Columns["Action2"].Index && e.RowIndex >= 0)
            {
                var result = await _userService.SoftDeleteUserAsync(id);
                if (result)
                {
                    MessageBox.Show("Đã ngưng hoạt động người dùng");
                    _users = await _userService.GetUsersAsync();
                }
                else
                {
                    MessageBox.Show("Không thể ngưng hoạt động người dùng");
                }
            }
            LoadData();
        }


        //private void btnTimKiem_Click(object sender, EventArgs e)
        //{
        //    var result = _context.Customers.AsQueryable();
        //    result = result.Where(c => c.LastName.Contains(txbTimKiem.Text));
        //    var count = result.Count();
        //    countLine = int.Parse(cbbSoDong.SelectedItem.ToString());
        //    totalPage = (float)count / countLine;
        //    totalPage = totalPage > (int)totalPage ? (int)totalPage + 1 : (int)totalPage;
        //    dataGridView.DataSource = result.Skip(countLine * (curentPage - 1)).Take(countLine).ToList();

        //    lblSoTrang.Text = $"Trang: {curentPage}/{totalPage}";
        //}

    }
}

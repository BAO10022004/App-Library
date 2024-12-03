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

namespace App_Library.Views.AdminView.CollectionComments
{
    public partial class CommentsForm : Form
    {
        private CommentService _commentService;
        private List<Comment> _comments;
        private BindingList<Comment> _commentsBindingList;
        private int curentPage = 1;
        private int countLine = 0;
        private float totalPage = 0;
        public CommentsForm()
        {
            InitializeComponent();
            _commentService = new CommentService();

            cbbSoDong.SelectedIndex = 0;
            cbbSapXep.SelectedIndex = 0;
            cbbCot.DataSource = typeof(Comment).GetProperties().Select(prop => prop.Name).ToList();
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
            if (_comments == null)
            {
                _comments = (await _commentService.GetAllCommentAsync()).Comments;
            }

            var count = _comments.Count;
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
                _comments = _comments.OrderBy(c => c.GetType().GetProperty(columnName)?.GetValue(c, null)).ToList();
            }
            else if (sortOrder == "Giảm dần")
            {
                _comments = _comments.OrderByDescending(c => c.GetType().GetProperty(columnName)?.GetValue(c, null)).ToList();
            }

            //var lstCommentView = _comments.Select(n => new CommentView() { Id = n.Id, Content = n.Content, UserId = n.UserId, Like = n.NumberOfLikes, Time = n.UpdatedAt.ToString() }).Skip(countLine * (curentPage - 1)).Take(countLine).ToList();
            var lstCommentView = _comments.Skip(countLine * (curentPage - 1)).Take(countLine).ToList();
            _commentsBindingList = new BindingList<Comment>(lstCommentView);

            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns["CommentID"].DataPropertyName = "Id";
            dataGridView.Columns["Comments"].DataPropertyName = "Content";
            dataGridView.Columns["UserID"].DataPropertyName = "UserId";
            dataGridView.Columns["Like"].DataPropertyName = "NumberOfLikes";
            dataGridView.Columns["Time"].DataPropertyName = "Time";
            dataGridView.Columns["Action"].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
            dataGridView.Columns["Action"].Width = 100;
            dataGridView.DataSource = _commentsBindingList;

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
            var id = row.Cells["CommentID"].Value.ToString();
            // Xóa
            if (e.ColumnIndex == dataGridView.Columns["Action"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //var commentDelete = _comments.Where(n => n.Id == id).Select(n => new CommentView() { Id = n.Id, Content = n.Content, UserId = n.UserId, Like = n.NumberOfLikes, Time = n.UpdatedAt.ToString() }).Skip(countLine * (curentPage - 1)).FirstOrDefault();
                    var commentDelete = _comments.Where(n => n.Id == id).FirstOrDefault();
                    var checkDelete = await _commentService.DeleteCommentAsync(id);
                    if (checkDelete)
                    {
                        _commentsBindingList.Remove(commentDelete);
                        _comments = (await _commentService.GetAllCommentAsync()).Comments;
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                    LoadData();
                }
            }
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

    class CommentView
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public string UserId { get; set; }
        public int Like { get; set; }
        public string Time { get; set; }

    }
}

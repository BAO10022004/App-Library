using App_Library.Services;
using App_Library.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App_Library.Views
{
    public partial class MainForm : Form
    {
        private readonly MongoDbContext _context;
        private readonly IUserService _userService;
        public MainForm(MongoDbContext context)
        {
            _context = context;
            _userService = new UserService(_context);
            InitializeComponent();
            //this.Load += UserListForm_Load;
        }
        //private async void UserListForm_Load(object sender, EventArgs e)
        //{
        //    var users = await _userService.GetUsersAsync();
        //    MessageBox.Show($"Number of users fetched: {users.Count}");
        //    // Thiết lập ListView
        //    listView1.View = View.Details;  // Đặt chế độ hiển thị
        //    listView1.FullRowSelect = true;  // Cho phép chọn toàn bộ hàng
        //    listView1.GridLines = true;       // Hiển thị đường kẻ giữa các hàng
        //    listView1.Columns.Clear();         // Xóa các cột cũ nếu có
        //    listView1.Items.Clear();           // Xóa các item cũ nếu có

        //    // Thêm các cột vào ListView
        //    listView1.Columns.Add("Username", 150);  // Cột 1: Username
        //    listView1.Columns.Add("Email", 200);     // Cột 2: Email
        //    listView1.Columns.Add("Created At", 150);  // Cột 3: Created At

        //    // Thêm từng dòng dữ liệu người dùng vào ListView
        //    foreach (var user in users),
        //    {
        //        var listItem = new ListViewItem(user.Username);  // Cột 1: Username
        //        listItem.SubItems.Add(user.Email);               // Cột 2: Email
        //        listItem.SubItems.Add(user.CreatedAt.ToString());  // Cột 3: Created At
        //        listView1.Items.Add(listItem);  // Thêm vào ListView
        //    }

        //    // Điều chỉnh độ rộng của các cột tự động vừa với nội dung
        //    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

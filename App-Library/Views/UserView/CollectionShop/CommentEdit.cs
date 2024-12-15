using App_Library.Models;
using App_Library.Services;
using App_Library.Views.Main.CollectionShop;
using App_Library.Views.ToolerForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library.Views.UserView.CollectionShop
{
    public partial class CommentEdit : Form
    {
        Comment comment;
        CommentService dbComment;
        CommentForm commentForm;
        public CommentEdit(Comment _comment , CommentForm commentForm)
        {
            InitializeComponent();
            this.commentForm = commentForm;
            this.comment = _comment;
        }

        private async  void CommentEdit_Load(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            dbComment = new CommentService();
            User user = await userService.GetUserByUsernameAsync(comment.UserId);
            if (user != null)
            {

                try
                {
                    guna2CirclePictureBox1.Load(user.PhotoURL);
                }
                catch (Exception)
                {
                }
                txbComment.Text = comment.Content;          
            }
            
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (txbComment.Text.Length < 10 || txbComment.Text.Length > 100)
            {
                (new AlertFail("Content comment must form 10 to 100 text")).ShowDialog();
            }
            else
            {
                var result = await dbComment.EditCommentAsync(comment.Id, txbComment.Text);
                if (result == null)
                {
                    (new AlertFail("Edit comment fail")).ShowDialog();
                }
                else
                {
                    (new AlertSuccess("Edit comment success")).ShowDialog();
                    commentForm.refeshFrame();
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            commentForm.refeshFrame();
        }
    }
}

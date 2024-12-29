using App_Library.Models;
using App_Library.Services;
using App_Library.Views.ToolerForm;
using System;
using System.Windows.Forms;

namespace App_Library.Views.Main.CollectionShop
{
    public partial class CompunentComment : Form
    {
        User user;
        Comment Comment;
        CommentForm parent;
        bool userLiked = false;
        public CompunentComment(Comment comment, CommentForm parent)
        {
            InitializeComponent();
            this.Comment = comment;
            this.parent = parent;
            lbNumberLike.Text = Comment.NumberOfLikes.ToString();
        }

        private async void CompunentComment_LoadAsync(object sender, EventArgs e)
        {
           
            UserService userService = new UserService();
            user = await userService.GetUserByUsernameAsync(Comment.UserId);
            if(user != null)
            {

                try
                {
                    guna2CirclePictureBox1.Load(user.PhotoURL);
                }
                catch (Exception)
                {
                }
                lbNameComment.Text = user.Username;
                
                lbCreateAt.Text = Comment.CreatedAt.ToString();
                lbComment.Text = Comment.Content;
                if (lbComment.Text.Length > 100)
                {
                    lbComment.Text = Comment.Content.Substring(100);
                    fpnContent.Controls.Add(lnMoreSeen);
                }
                int abs = pnContainComment.Height - lbComment.Height + 20;
                this.Height -= abs;
                User currentUser =await( new UserService()).GetCurrentUserAsync();
                if(!Comment.UserId.Equals(currentUser.Id))
                {
                    btnDelete.Visible = false;
                    btnEdit.Visible = false;
                }
                if(Comment.Likes != null)
                {
                    foreach(string id in Comment.Likes)
                    {
                        if(id.Equals(currentUser.Id))
                        {
                            pictureBox3.Image = App_Library.Properties.Resources.like__2_;

                            userLiked = true;
                        }
                    }
                }
                //MessageBox.Show(Comment.Likes.ToString());
            }
        }

        private void lnMoreSeen_Click(object sender, EventArgs e)
        {
            int abs = pnContainComment.Height;
            lbComment.Text = Comment.Content;
            this.Height += (pnContainComment.Height - abs );
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = App_Library.Properties.Resources.like__2_;
        }

        private  void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            if(!userLiked)
                     pictureBox3.Image = App_Library.Properties.Resources.like;
        }

        private async void pictureBox3_Click(object sender, EventArgs e)
        {
            User currentUser = await (new UserService()).GetCurrentUserAsync();
            userLiked = true;
            CommentService commentService = new CommentService();
            await commentService.LikeCommentAsync(Comment.Id);
            var listComment = await (new CommentService()).GetBookCommentsAsync(Comment.BookId);
            foreach(Comment comment in listComment)
            {
                if(comment.Id == Comment.Id)
                {
                    Comment.NumberOfLikes = comment.NumberOfLikes;
                    Comment.Likes = comment.Likes;  
                }
            }
            if (Comment.Likes != null)
            {
                foreach (string id in Comment.Likes)
                {
                    if (id.Equals(currentUser.Id))
                    {
                        pictureBox3.Image = App_Library.Properties.Resources.like__2_;
                    }
                }
            }
            lbNumberLike.Text = Comment.NumberOfLikes.ToString();
        }
        private async void btnDelete_Click(object sender, EventArgs e)
        {
          bool result =  await  parent.deleteComment(Comment.Id);
            if (result)
            {
                (new AlertSuccess("Delete comment success")).ShowDialog();
            }
            else
            {
                (new AlertFail("Delete comment fail")).ShowDialog();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            parent.editCommentFor(Comment);
        }
    }
}

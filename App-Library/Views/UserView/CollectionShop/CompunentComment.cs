using App_Library.Models;
using App_Library.Services;
using System;
using System.Windows.Forms;

namespace App_Library.Views.Main.CollectionShop
{
    public partial class CompunentComment : Form
    {
        User user;
        Comment Comment;
        NewShopMain shop;
        public CompunentComment(Comment comment, NewShopMain shop)
        {
            InitializeComponent();
            this.Comment = comment;
            this.shop = shop;
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
                
                //fixed Size
                //if (lbComment.Height <= pnContainComment.Height)
                //    {
                //        this.Height -= (pnContainComment.Height - lbComment.Height);
                //    }
                //    else
                //    {
                //        this.Height += 20;
                //    }
                int abs = pnContainComment.Height - lbComment.Height + 20;
                this.Height -= abs;
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

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = App_Library.Properties.Resources.like;
        }

        private async void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.MouseLeave -=new EventHandler( pictureBox3_MouseHover);
            pictureBox3.Image = App_Library.Properties.Resources.like__2_;
            CommentService commentService = new CommentService();
            await commentService.LikeCommentAsync(Comment.Id);
            lbNumberLike.Text = Comment.NumberOfLikes.ToString();
        }
    }
}

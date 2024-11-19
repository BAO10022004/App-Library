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
        }

        private async void CompunentComment_LoadAsync(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            user = await userService.GetUserByIdAsync(Comment.UserId);
            try
            {
                picAvatar.Load(user.PhotoURL); 
            }
            catch (Exception)
            {
            }
            lbNameComment.Text = user.Username;
            lbCreateAt.Text = Comment.CreatedAt.ToString();
            lbComment.Text = Comment.Content;
            lbNumberLike.Text = Comment.NumberOfLikes.ToString();
            // fixed Size 
            if (lbComment.Height <= pnContainComment.Height)
            {
                this.Height -= (pnContainComment.Height - lbComment.Height);
            }
            else
            {
                this.Height += 20;
            }

        }

        private void lnMoreSeen_Click(object sender, EventArgs e)
        {
            this.Height += (-pnContainComment.Height + lbComment.Height);
            pnContainComment.Height = lbComment.Height;
        }
    }
}

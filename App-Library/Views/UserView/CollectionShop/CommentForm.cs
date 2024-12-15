using App_Library.Models;
using App_Library.Services;
using App_Library.Views.ToolerForm;
using App_Library.Views.UserView.CollectionShop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace App_Library.Views.Main.CollectionShop
{
    public partial class CommentForm : FormHelper
    {
        Book book;
        List<Comment> comments;
        NewShopMain shop;
        // Database
        CommentService dbComments = new CommentService();
        // Animation
        int x;
        bool isHover = false;
        public CommentForm( Book book , NewShopMain shop)
        {
            InitializeComponent();
            this.book = book;            
            this.shop = shop;
            x = pnHideOption.Location.X;
        }
        private  async void CommentForm_Load(object sender, EventArgs e)
        {
            this.comments =await dbComments.GetBookCommentsAsync(book.Id);
            lbNumberComments.Text = comments.Count.ToString();
            if (comments.Count == 0)
            {
                pnListComment.Visible = false;
            }
            else
            {
                foreach (Comment comment in comments)
                {

                   pnListComment.Controls.Add(createComment(comment, comments.IndexOf(comment)));
                }

            }
            int HEIGHT = 0;
            foreach (Control control in pnListComment.Controls)
            {
                HEIGHT += control.Height;
            }
            pnListComment.AutoScrollMinSize = new Size(0, HEIGHT);

        }
        Panel  createComment(Comment c, int index )
        {
            Form form = new Form();
            Form Comment = new CompunentComment(c, this);
            Panel panel = new Panel();
            panel.TabIndex = index;
            panel.Size = new Size(600, Comment.Height);
            activeFormChild(panel, Comment , null,ref form);
            return panel;
        }

        private void pnAddComment_Resize(object sender, EventArgs e)
        {
            pnAddComment.Width = shop.Width;
            pnCreateCommment.Location = new Point((pnAddComment.Width - pnCreateCommment.Width) / 2, (pnAddComment.Height - pnCreateCommment.Height) / 2);
            pnViewNumberComment.Location = new Point(pnCreateCommment.Location.X, pnViewNumberComment.Location.Y);
            pnListComment.Location = new Point(pnCreateCommment.Location.X, pnListComment.Location.Y);
        }

        private void txbComment_Click(object sender, EventArgs e)
        {
            if(txbComment.Text.Equals("Add Comment ..."))
            {
                txbComment.Text = "";
            }
        }

        private void txbComment_MouseLeave(object sender, EventArgs e)
        {
            if (txbComment.Text.Equals(""))
            {
                txbComment.Text = "Add Comment ...";
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txbComment.Text.Length < 10 || txbComment.Text.Length > 100)
            {
                (new AlertFail("Lenght comment must from 10 to 100 text")).ShowDialog();
            }
            else
            {
                (new AlertSuccess("Submit success")).ShowDialog();
                LoadingForm loadingForm = new LoadingForm();
                loadingForm.Show();
                Comment comment = new Comment();
                comment.NumberOfLikes = 0;
                comment.Content = txbComment.Text;
                comment.UpdatedAt = DateTime.Now;
                comment.CreatedAt = DateTime.Now;
                UserService userService = new UserService();
                comment.UserId = (await userService.GetCurrentUserAsync()).Id;
                comment.BookId = book.Id;
                comment.Likes = null;

                await dbComments.CreateCommentAsync(comment);
                comments = await dbComments.GetBookCommentsAsync(book.Id);
                refeshFrame();
                //shop.bookClick(book);
                loadingForm.Close();
            }
            
        }

        public async void refeshFrame()
        {
            comments = await (new CommentService()).GetBookCommentsAsync(book.Id);
            pnListComment.Controls.Clear();
            foreach (Comment item in comments)
            {
                pnListComment.Controls.Add(createComment(item, comments.IndexOf(item)));
            }
            lbNumberComments.Text = comments.Count.ToString();
            int HEIGHT = 0;
            foreach (Control control in pnListComment.Controls)
            {
                HEIGHT += control.Height;
            }
            pnListComment.AutoScrollMinSize = new Size(0, HEIGHT);
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            isHover = true;
            Label label = sender as Label;
            label.BackColor = Color.Gray;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            isHover = false;
            Label label = sender as Label;
            label.BackColor = Color.White;
            
        }
        
        private void timerOpenOptionSort_Tick(object sender, EventArgs e)
        {
            if(pnHideOption.Location.X <  x + pnHideOption.Width)
            {
                pnHideOption.Location = new Point(pnHideOption.Location.X + 5, pnHideOption.Location.Y);
            }
            else
            {
                timerOpenOptionSort.Stop();
            }
        }

        private void guna2Panel1_MouseHover(object sender, EventArgs e)
        {
            
            timerOpenOptionSort.Start();
        }

        private void guna2Panel1_MouseLeave(object sender, EventArgs e)
        {
            if(!isHover)
            {
                pnHideOption.Location = new Point(x, pnHideOption.Location.Y);
            }
            isHover = false;
        }

        private void pnOptionSort_MouseLeave(object sender, EventArgs e)
        {

            pnHideOption.Location = new Point(x, pnHideOption.Location.Y);
        }
        
        private async void label4_Click(object sender, EventArgs e)
        {
            comments = await dbComments.GetBookCommentsAsync(book.Id);
            List<Comment> commentLikeSort = comments.OrderByDescending(x => x.NumberOfLikes).ToList();

            pnListComment.Controls.Clear();
            foreach (Comment item in commentLikeSort)
            {
                pnListComment.Controls.Add(createComment(item, comments.IndexOf(item)));
            }
        }

        private async void label5_Click(object sender, EventArgs e)
        {
            comments = await dbComments.GetBookCommentsAsync(book.Id);
            List<Comment> commentDateSort = comments.OrderBy(x => x.UpdatedAt).ToList();

            pnListComment.Controls.Clear();
            foreach (Comment item in commentDateSort)
            {
                pnListComment.Controls.Add(createComment(item, comments.IndexOf(item)));
            }
        }
        public async Task<bool> deleteComment(string commentId)
        {
            bool result = await dbComments.DeleteCommentAsync(commentId);
            if (result) {
                refeshFrame();
                return true;
            }
            return false;
            
        }
        Panel createCommentEdit(Comment c, int index)
        {
            Form form = new Form();
            Form Comment = new CommentEdit(c, this);
            Panel panel = new Panel();
            panel.TabIndex = index;
            panel.Size = new Size(800, 100);
            activeFormChild(panel, Comment, null, ref form);
            return panel;
        }
        public async void editCommentFor(Comment comment)
        {
            comments = await(new CommentService()).GetBookCommentsAsync(book.Id);
            pnListComment.Controls.Clear();
            foreach (Comment item in comments)
            {
                if (comment.Id != item.Id)
                {
                    pnListComment.Controls.Add(createComment(item, comments.IndexOf(item)));
                }
                else
                {
                    pnListComment.Controls.Add(createCommentEdit(item, comments.IndexOf(item)));
                } 
            }
            lbNumberComments.Text = comments.Count.ToString();
            int HEIGHT = 0;
            foreach (Control control in pnListComment.Controls)
            {
                HEIGHT += control.Height;
            }
            pnListComment.AutoScrollMinSize = new Size(0, HEIGHT);
        }
    }
}

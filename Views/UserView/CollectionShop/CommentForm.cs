using App_Library.Models;
using App_Library.Services;
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

namespace App_Library.Views.Main.CollectionShop
{
    public partial class CommentForm : FormHelper
    {
        Book book;
        List<Comment> comments;
        NewShopMain shop;
        public CommentForm(List<Comment> comment, Book book , NewShopMain shop)
        {
            InitializeComponent();
            this.book = book;
            this.comments = comment;
        }
        private  void CommentForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(comments.Count.ToString());
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
            foreach (Control control in pnListComment.Controls) {
                HEIGHT += control.Height;
            }
            pnListComment.Height = HEIGHT;
            HEIGHT = 0;
            foreach (Control control in this.Controls)
            {
                HEIGHT += control.Height;
            }
            this.Height = HEIGHT;
        }
        Panel  createComment(Comment c, int index )
        {
            Form form = new Form();
            Panel panel = new Panel();
            panel.TabIndex = index;
            panel.Size = new Size(1197, 40);
            activeFormChild(panel,new  CompunentComment(c, shop), null,ref form);
            return panel;
        }
    }
}

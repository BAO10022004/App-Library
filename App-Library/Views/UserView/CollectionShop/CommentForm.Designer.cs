namespace App_Library.Views.Main.CollectionShop
{
    partial class CommentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnCreateCommment = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.txbComment = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnListComment = new System.Windows.Forms.FlowLayoutPanel();
            this.pnAddComment = new Guna.UI2.WinForms.Guna2Panel();
            this.pnHideOption = new Guna.UI2.WinForms.Guna2Panel();
            this.pnOptionSort = new Guna.UI2.WinForms.Guna2Panel();
            this.pnDate = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnFavorite = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnViewNumberComment = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNumberComments = new System.Windows.Forms.Label();
            this.geSort = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timerOpenOptionSort = new System.Windows.Forms.Timer(this.components);
            this.pnCreateCommment.SuspendLayout();
            this.btnSubmit.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.pnAddComment.SuspendLayout();
            this.pnOptionSort.SuspendLayout();
            this.pnDate.SuspendLayout();
            this.pnFavorite.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.pnViewNumberComment.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCreateCommment
            // 
            this.pnCreateCommment.BackColor = System.Drawing.Color.Transparent;
            this.pnCreateCommment.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.pnCreateCommment.BorderRadius = 20;
            this.pnCreateCommment.BorderThickness = 3;
            this.pnCreateCommment.Controls.Add(this.btnSubmit);
            this.pnCreateCommment.Controls.Add(this.guna2Panel4);
            this.pnCreateCommment.CustomBorderColor = System.Drawing.Color.White;
            this.pnCreateCommment.FillColor = System.Drawing.Color.White;
            this.pnCreateCommment.Location = new System.Drawing.Point(164, 11);
            this.pnCreateCommment.Margin = new System.Windows.Forms.Padding(2);
            this.pnCreateCommment.Name = "pnCreateCommment";
            this.pnCreateCommment.Size = new System.Drawing.Size(675, 220);
            this.pnCreateCommment.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BorderColor = System.Drawing.Color.Cyan;
            this.btnSubmit.BorderRadius = 20;
            this.btnSubmit.BorderThickness = 5;
            this.btnSubmit.Controls.Add(this.label3);
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSubmit.Location = new System.Drawing.Point(530, 155);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(129, 56);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(26, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "SUBMIT";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel4.BorderRadius = 20;
            this.guna2Panel4.BorderThickness = 2;
            this.guna2Panel4.Controls.Add(this.txbComment);
            this.guna2Panel4.Location = new System.Drawing.Point(16, 18);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(642, 132);
            this.guna2Panel4.TabIndex = 0;
            // 
            // txbComment
            // 
            this.txbComment.BorderRadius = 15;
            this.txbComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbComment.DefaultText = "Add Comment ...";
            this.txbComment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbComment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbComment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbComment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbComment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbComment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbComment.ForeColor = System.Drawing.Color.Black;
            this.txbComment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbComment.Location = new System.Drawing.Point(0, 0);
            this.txbComment.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txbComment.Multiline = true;
            this.txbComment.Name = "txbComment";
            this.txbComment.PasswordChar = '\0';
            this.txbComment.PlaceholderText = "";
            this.txbComment.SelectedText = "";
            this.txbComment.Size = new System.Drawing.Size(642, 132);
            this.txbComment.TabIndex = 0;
            this.txbComment.Click += new System.EventHandler(this.txbComment_Click);
            this.txbComment.MouseLeave += new System.EventHandler(this.txbComment_MouseLeave);
            // 
            // pnListComment
            // 
            this.pnListComment.AutoScroll = true;
            this.pnListComment.Location = new System.Drawing.Point(164, 380);
            this.pnListComment.Margin = new System.Windows.Forms.Padding(2);
            this.pnListComment.Name = "pnListComment";
            this.pnListComment.Size = new System.Drawing.Size(886, 255);
            this.pnListComment.TabIndex = 4;
            // 
            // pnAddComment
            // 
            this.pnAddComment.Controls.Add(this.pnHideOption);
            this.pnAddComment.Controls.Add(this.pnOptionSort);
            this.pnAddComment.Controls.Add(this.guna2Panel1);
            this.pnAddComment.Controls.Add(this.pnViewNumberComment);
            this.pnAddComment.Controls.Add(this.pnCreateCommment);
            this.pnAddComment.Location = new System.Drawing.Point(0, -1);
            this.pnAddComment.Margin = new System.Windows.Forms.Padding(2);
            this.pnAddComment.Name = "pnAddComment";
            this.pnAddComment.Size = new System.Drawing.Size(970, 377);
            this.pnAddComment.TabIndex = 5;
            this.pnAddComment.Paint += new System.Windows.Forms.PaintEventHandler(this.pnAddComment_Paint);
            this.pnAddComment.Resize += new System.EventHandler(this.pnAddComment_Resize);
            // 
            // pnHideOption
            // 
            this.pnHideOption.Location = new System.Drawing.Point(606, 246);
            this.pnHideOption.Name = "pnHideOption";
            this.pnHideOption.Size = new System.Drawing.Size(171, 109);
            this.pnHideOption.TabIndex = 7;
            // 
            // pnOptionSort
            // 
            this.pnOptionSort.BackColor = System.Drawing.Color.Honeydew;
            this.pnOptionSort.Controls.Add(this.pnDate);
            this.pnOptionSort.Controls.Add(this.pnFavorite);
            this.pnOptionSort.Location = new System.Drawing.Point(606, 236);
            this.pnOptionSort.Name = "pnOptionSort";
            this.pnOptionSort.Padding = new System.Windows.Forms.Padding(10);
            this.pnOptionSort.Size = new System.Drawing.Size(186, 127);
            this.pnOptionSort.TabIndex = 6;
            this.pnOptionSort.MouseLeave += new System.EventHandler(this.pnOptionSort_MouseLeave);
            // 
            // pnDate
            // 
            this.pnDate.BorderColor = System.Drawing.Color.Black;
            this.pnDate.Controls.Add(this.label5);
            this.pnDate.Location = new System.Drawing.Point(0, 65);
            this.pnDate.Name = "pnDate";
            this.pnDate.Padding = new System.Windows.Forms.Padding(3);
            this.pnDate.Size = new System.Drawing.Size(155, 49);
            this.pnDate.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 43);
            this.label5.TabIndex = 1;
            this.label5.Text = "Date";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            this.label5.MouseHover += new System.EventHandler(this.label4_MouseHover);
            // 
            // pnFavorite
            // 
            this.pnFavorite.BorderColor = System.Drawing.Color.Black;
            this.pnFavorite.Controls.Add(this.label4);
            this.pnFavorite.Location = new System.Drawing.Point(0, 10);
            this.pnFavorite.Name = "pnFavorite";
            this.pnFavorite.Padding = new System.Windows.Forms.Padding(3);
            this.pnFavorite.Size = new System.Drawing.Size(155, 55);
            this.pnFavorite.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 49);
            this.label4.TabIndex = 0;
            this.label4.Text = "Favorite";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            this.label4.MouseHover += new System.EventHandler(this.label4_MouseHover);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.panel2);
            this.guna2Panel1.Location = new System.Drawing.Point(447, 250);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(156, 78);
            this.guna2Panel1.TabIndex = 5;
            this.guna2Panel1.MouseLeave += new System.EventHandler(this.guna2Panel1_MouseLeave);
            this.guna2Panel1.MouseHover += new System.EventHandler(this.guna2Panel1_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sort";
            this.label1.MouseHover += new System.EventHandler(this.guna2Panel1_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.guna2PictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(66, 64);
            this.panel2.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.Image = global::App_Library.Properties.Resources.arrange;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(64, 62);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.MouseHover += new System.EventHandler(this.guna2Panel1_MouseHover);
            // 
            // pnViewNumberComment
            // 
            this.pnViewNumberComment.Controls.Add(this.label2);
            this.pnViewNumberComment.Controls.Add(this.panel1);
            this.pnViewNumberComment.Location = new System.Drawing.Point(164, 250);
            this.pnViewNumberComment.Name = "pnViewNumberComment";
            this.pnViewNumberComment.Size = new System.Drawing.Size(263, 78);
            this.pnViewNumberComment.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comments";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbNumberComments);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(66, 64);
            this.panel1.TabIndex = 0;
            // 
            // lbNumberComments
            // 
            this.lbNumberComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNumberComments.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberComments.Location = new System.Drawing.Point(0, 0);
            this.lbNumberComments.Name = "lbNumberComments";
            this.lbNumberComments.Size = new System.Drawing.Size(64, 62);
            this.lbNumberComments.TabIndex = 0;
            this.lbNumberComments.Text = "0";
            this.lbNumberComments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // geSort
            // 
            this.geSort.BorderRadius = 20;
            this.geSort.TargetControl = this.pnOptionSort;
            // 
            // timerOpenOptionSort
            // 
            this.timerOpenOptionSort.Interval = 1;
            this.timerOpenOptionSort.Tick += new System.EventHandler(this.timerOpenOptionSort_Tick);
            // 
            // CommentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(970, 635);
            this.Controls.Add(this.pnAddComment);
            this.Controls.Add(this.pnListComment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CommentForm";
            this.Text = "CommentForm";
            this.Load += new System.EventHandler(this.CommentForm_Load);
            this.pnCreateCommment.ResumeLayout(false);
            this.btnSubmit.ResumeLayout(false);
            this.btnSubmit.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.pnAddComment.ResumeLayout(false);
            this.pnOptionSort.ResumeLayout(false);
            this.pnDate.ResumeLayout(false);
            this.pnFavorite.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.pnViewNumberComment.ResumeLayout(false);
            this.pnViewNumberComment.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnCreateCommment;
        private Guna.UI2.WinForms.Guna2Panel btnSubmit;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2TextBox txbComment;
        private System.Windows.Forms.FlowLayoutPanel pnListComment;
        private Guna.UI2.WinForms.Guna2Panel pnAddComment;
        private Guna.UI2.WinForms.Guna2Panel pnViewNumberComment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNumberComments;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel pnOptionSort;
        private Guna.UI2.WinForms.Guna2Panel pnDate;
        private Guna.UI2.WinForms.Guna2Panel pnFavorite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Elipse geSort;
        private Guna.UI2.WinForms.Guna2Panel pnHideOption;
        private System.Windows.Forms.Timer timerOpenOptionSort;
    }
}
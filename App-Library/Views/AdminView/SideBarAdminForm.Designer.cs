namespace App_Library.Views.AdminView
{
    partial class SideBarAdminForm
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
            this.pnSideBar = new System.Windows.Forms.Panel();
            this.btnStatistics = new Guna.UI2.WinForms.Guna2Button();
            this.btnBooks = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnComments = new Guna.UI2.WinForms.Guna2Button();
            this.btnPending = new Guna.UI2.WinForms.Guna2Button();
            this.btnHistory = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpload = new Guna.UI2.WinForms.Guna2Button();
            this.pnSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSideBar
            // 
            this.pnSideBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnSideBar.BackColor = System.Drawing.Color.White;
            this.pnSideBar.Controls.Add(this.btnStatistics);
            this.pnSideBar.Controls.Add(this.btnBooks);
            this.pnSideBar.Controls.Add(this.btnUsers);
            this.pnSideBar.Controls.Add(this.btnComments);
            this.pnSideBar.Controls.Add(this.btnPending);
            this.pnSideBar.Controls.Add(this.btnHistory);
            this.pnSideBar.Controls.Add(this.btnUpload);
            this.pnSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnSideBar.Name = "pnSideBar";
            this.pnSideBar.Size = new System.Drawing.Size(250, 455);
            this.pnSideBar.TabIndex = 1;
            // 
            // btnStatistics
            // 
            this.btnStatistics.Animated = true;
            this.btnStatistics.AnimatedGIF = true;
            this.btnStatistics.BorderRadius = 5;
            this.btnStatistics.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStatistics.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStatistics.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStatistics.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStatistics.FillColor = System.Drawing.Color.White;
            this.btnStatistics.FocusedColor = System.Drawing.Color.LightCyan;
            this.btnStatistics.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.btnStatistics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnStatistics.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnStatistics.HoverState.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F);
            this.btnStatistics.Image = global::App_Library.Properties.Resources.pie_chart;
            this.btnStatistics.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStatistics.ImageSize = new System.Drawing.Size(35, 35);
            this.btnStatistics.Location = new System.Drawing.Point(3, 4);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(244, 51);
            this.btnStatistics.TabIndex = 23;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.Click += new System.EventHandler(this.lbStatistics_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.Animated = true;
            this.btnBooks.AnimatedGIF = true;
            this.btnBooks.BorderRadius = 5;
            this.btnBooks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBooks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBooks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBooks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBooks.FillColor = System.Drawing.Color.White;
            this.btnBooks.FocusedColor = System.Drawing.Color.LightCyan;
            this.btnBooks.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.btnBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBooks.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnBooks.HoverState.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F);
            this.btnBooks.Image = global::App_Library.Properties.Resources.book;
            this.btnBooks.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBooks.ImageSize = new System.Drawing.Size(35, 35);
            this.btnBooks.Location = new System.Drawing.Point(3, 61);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(244, 51);
            this.btnBooks.TabIndex = 22;
            this.btnBooks.Text = "Books";
            this.btnBooks.Click += new System.EventHandler(this.lbBooks_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Animated = true;
            this.btnUsers.AnimatedGIF = true;
            this.btnUsers.BorderRadius = 5;
            this.btnUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsers.FillColor = System.Drawing.Color.White;
            this.btnUsers.FocusedColor = System.Drawing.Color.LightCyan;
            this.btnUsers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.btnUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUsers.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnUsers.HoverState.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F);
            this.btnUsers.Image = global::App_Library.Properties.Resources.user__3_;
            this.btnUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsers.ImageSize = new System.Drawing.Size(35, 35);
            this.btnUsers.Location = new System.Drawing.Point(3, 116);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(244, 51);
            this.btnUsers.TabIndex = 21;
            this.btnUsers.Text = "Users";
            this.btnUsers.Click += new System.EventHandler(this.lbUsers_Click);
            // 
            // btnComments
            // 
            this.btnComments.Animated = true;
            this.btnComments.AnimatedGIF = true;
            this.btnComments.BorderRadius = 5;
            this.btnComments.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnComments.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnComments.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnComments.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnComments.FillColor = System.Drawing.Color.White;
            this.btnComments.FocusedColor = System.Drawing.Color.LightCyan;
            this.btnComments.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.btnComments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnComments.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnComments.HoverState.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F);
            this.btnComments.Image = global::App_Library.Properties.Resources.seo;
            this.btnComments.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnComments.ImageSize = new System.Drawing.Size(35, 35);
            this.btnComments.Location = new System.Drawing.Point(3, 171);
            this.btnComments.Name = "btnComments";
            this.btnComments.Size = new System.Drawing.Size(244, 51);
            this.btnComments.TabIndex = 20;
            this.btnComments.Text = "Comments";
            this.btnComments.Click += new System.EventHandler(this.lbComments_Click);
            // 
            // btnPending
            // 
            this.btnPending.Animated = true;
            this.btnPending.AnimatedGIF = true;
            this.btnPending.BorderRadius = 5;
            this.btnPending.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPending.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPending.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPending.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPending.FillColor = System.Drawing.Color.White;
            this.btnPending.FocusedColor = System.Drawing.Color.LightCyan;
            this.btnPending.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.btnPending.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPending.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnPending.HoverState.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F);
            this.btnPending.Image = global::App_Library.Properties.Resources.approve;
            this.btnPending.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPending.ImageSize = new System.Drawing.Size(35, 35);
            this.btnPending.Location = new System.Drawing.Point(3, 226);
            this.btnPending.Name = "btnPending";
            this.btnPending.Size = new System.Drawing.Size(244, 51);
            this.btnPending.TabIndex = 19;
            this.btnPending.Text = "Pending";
            this.btnPending.Click += new System.EventHandler(this.lbPending_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Animated = true;
            this.btnHistory.AnimatedGIF = true;
            this.btnHistory.BorderRadius = 5;
            this.btnHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHistory.FillColor = System.Drawing.Color.White;
            this.btnHistory.FocusedColor = System.Drawing.Color.LightCyan;
            this.btnHistory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.btnHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnHistory.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnHistory.HoverState.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F);
            this.btnHistory.Image = global::App_Library.Properties.Resources.time_management;
            this.btnHistory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHistory.ImageSize = new System.Drawing.Size(35, 35);
            this.btnHistory.Location = new System.Drawing.Point(3, 281);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(244, 51);
            this.btnHistory.TabIndex = 18;
            this.btnHistory.Text = "History";
            this.btnHistory.Click += new System.EventHandler(this.lbHistory_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Animated = true;
            this.btnUpload.AnimatedGIF = true;
            this.btnUpload.BorderRadius = 5;
            this.btnUpload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpload.FillColor = System.Drawing.Color.White;
            this.btnUpload.FocusedColor = System.Drawing.Color.LightCyan;
            this.btnUpload.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.btnUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpload.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnUpload.HoverState.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F);
            this.btnUpload.Image = global::App_Library.Properties.Resources.upload_file;
            this.btnUpload.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpload.ImageSize = new System.Drawing.Size(35, 35);
            this.btnUpload.Location = new System.Drawing.Point(3, 338);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(244, 51);
            this.btnUpload.TabIndex = 17;
            this.btnUpload.Text = "Upload";
            this.btnUpload.Click += new System.EventHandler(this.lbUpload_Click);
            // 
            // SideBarAdminForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(250, 455);
            this.Controls.Add(this.pnSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SideBarAdminForm";
            this.Text = "SideBarAdminForm";
            this.Load += new System.EventHandler(this.SideBarAdminForm_Load);
            this.pnSideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSideBar;
        private Guna.UI2.WinForms.Guna2Button btnUpload;
        private Guna.UI2.WinForms.Guna2Button btnHistory;
        private Guna.UI2.WinForms.Guna2Button btnStatistics;
        private Guna.UI2.WinForms.Guna2Button btnBooks;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
        private Guna.UI2.WinForms.Guna2Button btnComments;
        private Guna.UI2.WinForms.Guna2Button btnPending;
    }
}
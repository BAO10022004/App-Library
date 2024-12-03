namespace App_Library.Views.UserView
{
    partial class SideBarUserForm
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
            this.gnPanelHome = new Guna.UI2.WinForms.Guna2Panel();
            this.lbHome = new System.Windows.Forms.Label();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.gnPanelStore = new Guna.UI2.WinForms.Guna2Panel();
            this.picShop = new System.Windows.Forms.PictureBox();
            this.lbStore = new System.Windows.Forms.Label();
            this.pnSideBar.SuspendLayout();
            this.gnPanelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.gnPanelStore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShop)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSideBar
            // 
            this.pnSideBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnSideBar.BackColor = System.Drawing.Color.White;
            this.pnSideBar.Controls.Add(this.gnPanelHome);
            this.pnSideBar.Controls.Add(this.gnPanelStore);
            this.pnSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnSideBar.Name = "pnSideBar";
            this.pnSideBar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnSideBar.Size = new System.Drawing.Size(250, 455);
            this.pnSideBar.TabIndex = 0;
            // 
            // gnPanelHome
            // 
            this.gnPanelHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gnPanelHome.BackColor = System.Drawing.Color.White;
            this.gnPanelHome.Controls.Add(this.lbHome);
            this.gnPanelHome.Controls.Add(this.picHome);
            this.gnPanelHome.Location = new System.Drawing.Point(0, 5);
            this.gnPanelHome.Name = "gnPanelHome";
            this.gnPanelHome.Size = new System.Drawing.Size(250, 50);
            this.gnPanelHome.TabIndex = 13;
            // 
            // lbHome
            // 
            this.lbHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHome.Location = new System.Drawing.Point(50, 0);
            this.lbHome.Name = "lbHome";
            this.lbHome.Size = new System.Drawing.Size(200, 50);
            this.lbHome.TabIndex = 0;
            this.lbHome.Text = "HOME";
            this.lbHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbHome.Click += new System.EventHandler(this.lbHome_Click);
            // 
            // picHome
            // 
            this.picHome.BackColor = System.Drawing.Color.Transparent;
            this.picHome.Image = global::App_Library.Properties.Resources.HomeHover;
            this.picHome.Location = new System.Drawing.Point(9, 9);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(32, 32);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHome.TabIndex = 2;
            this.picHome.TabStop = false;
            // 
            // gnPanelStore
            // 
            this.gnPanelStore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gnPanelStore.BackColor = System.Drawing.Color.White;
            this.gnPanelStore.Controls.Add(this.picShop);
            this.gnPanelStore.Controls.Add(this.lbStore);
            this.gnPanelStore.Location = new System.Drawing.Point(0, 60);
            this.gnPanelStore.Name = "gnPanelStore";
            this.gnPanelStore.Size = new System.Drawing.Size(250, 50);
            this.gnPanelStore.TabIndex = 13;
            // 
            // picShop
            // 
            this.picShop.Image = global::App_Library.Properties.Resources.book_fair;
            this.picShop.Location = new System.Drawing.Point(9, 9);
            this.picShop.Name = "picShop";
            this.picShop.Size = new System.Drawing.Size(32, 32);
            this.picShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShop.TabIndex = 3;
            this.picShop.TabStop = false;
            // 
            // lbStore
            // 
            this.lbStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStore.Location = new System.Drawing.Point(50, 0);
            this.lbStore.Name = "lbStore";
            this.lbStore.Size = new System.Drawing.Size(200, 50);
            this.lbStore.TabIndex = 0;
            this.lbStore.Text = "STORE";
            this.lbStore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbStore.Click += new System.EventHandler(this.lbStore_Click);
            // 
            // SideBarUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(250, 455);
            this.Controls.Add(this.pnSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SideBarUserForm";
            this.Text = "SideBarUserForm";
            this.Load += new System.EventHandler(this.SideBarUserForm_Load);
            this.pnSideBar.ResumeLayout(false);
            this.gnPanelHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.gnPanelStore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picShop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSideBar;
        private System.Windows.Forms.Label lbHome;
        private System.Windows.Forms.Label lbStore;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.PictureBox picShop;
        private Guna.UI2.WinForms.Guna2Panel gnPanelHome;
        private Guna.UI2.WinForms.Guna2Panel gnPanelStore;
    }
}
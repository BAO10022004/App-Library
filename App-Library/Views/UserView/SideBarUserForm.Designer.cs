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
            this.btnHelp = new Guna.UI2.WinForms.Guna2Button();
            this.btnStore = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.pnSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSideBar
            // 
            this.pnSideBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnSideBar.BackColor = System.Drawing.Color.White;
            this.pnSideBar.Controls.Add(this.btnHelp);
            this.pnSideBar.Controls.Add(this.btnStore);
            this.pnSideBar.Controls.Add(this.btnHome);
            this.pnSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnSideBar.Name = "pnSideBar";
            this.pnSideBar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnSideBar.Size = new System.Drawing.Size(250, 455);
            this.pnSideBar.TabIndex = 0;
            // 
            // btnHelp
            // 
            this.btnHelp.BorderRadius = 5;
            this.btnHelp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHelp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHelp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHelp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHelp.FillColor = System.Drawing.Color.White;
            this.btnHelp.FocusedColor = System.Drawing.Color.LightCyan;
            this.btnHelp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnHelp.Image = global::App_Library.Properties.Resources.headset1;
            this.btnHelp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHelp.ImageSize = new System.Drawing.Size(35, 35);
            this.btnHelp.Location = new System.Drawing.Point(3, 127);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(244, 52);
            this.btnHelp.TabIndex = 17;
            this.btnHelp.Text = "Help";
            this.btnHelp.Click += new System.EventHandler(this.lbHelp_Click);
            // 
            // btnStore
            // 
            this.btnStore.BorderRadius = 5;
            this.btnStore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStore.FillColor = System.Drawing.Color.White;
            this.btnStore.FocusedColor = System.Drawing.Color.LightCyan;
            this.btnStore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.btnStore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnStore.Image = global::App_Library.Properties.Resources.carts1;
            this.btnStore.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStore.ImageSize = new System.Drawing.Size(35, 35);
            this.btnStore.Location = new System.Drawing.Point(3, 70);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(244, 51);
            this.btnStore.TabIndex = 16;
            this.btnStore.Text = "Store";
            this.btnStore.Click += new System.EventHandler(this.lbStore_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderRadius = 5;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnHome.FocusedColor = System.Drawing.Color.LightCyan;
            this.btnHome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnHome.Image = global::App_Library.Properties.Resources.HomeHover;
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.ImageSize = new System.Drawing.Size(45, 45);
            this.btnHome.Location = new System.Drawing.Point(3, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(244, 52);
            this.btnHome.TabIndex = 15;
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.lbHome_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSideBar;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnStore;
        private Guna.UI2.WinForms.Guna2Button btnHelp;
    }
}
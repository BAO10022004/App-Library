using System.Drawing;
using System.Windows.Forms;

namespace App_Library.Views
{
    partial class MainForm
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
            this.pnContent = new System.Windows.Forms.Panel();
            this.pnMain = new Guna.UI2.WinForms.Guna2Panel();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.pnSideBar = new System.Windows.Forms.Panel();
            this.pnUser = new System.Windows.Forms.Panel();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.picAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnFooter = new System.Windows.Forms.Panel();
            this.pnContainLogOut = new Guna.UI2.WinForms.Guna2Panel();
            this.picLogOut = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.pnMain.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.pnLeft.SuspendLayout();
            this.pnUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnFooter.SuspendLayout();
            this.pnContainLogOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogOut)).BeginInit();
            this.SuspendLayout();
            // 
            // pnContent
            // 
            this.pnContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(248, 0);
            this.pnContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(1032, 680);
            this.pnContent.TabIndex = 5;
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.pnContent);
            this.pnMain.Controls.Add(this.guna2Panel1);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1280, 680);
            this.pnMain.TabIndex = 0;
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Image = global::App_Library.Properties.Resources.account;
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.Controls.Add(this.pnLeft);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(248, 680);
            this.guna2Panel1.TabIndex = 0;
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.Transparent;
            this.pnLeft.Controls.Add(this.pnSideBar);
            this.pnLeft.Controls.Add(this.pnUser);
            this.pnLeft.Controls.Add(this.pnFooter);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Margin = new System.Windows.Forms.Padding(2);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(253, 680);
            this.pnLeft.TabIndex = 5;
            // 
            // pnSideBar
            // 
            this.pnSideBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSideBar.Location = new System.Drawing.Point(0, 110);
            this.pnSideBar.Margin = new System.Windows.Forms.Padding(2);
            this.pnSideBar.Name = "pnSideBar";
            this.pnSideBar.Size = new System.Drawing.Size(253, 436);
            this.pnSideBar.TabIndex = 5;
            // 
            // pnUser
            // 
            this.pnUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnUser.Controls.Add(this.lbRole);
            this.pnUser.Controls.Add(this.lbName);
            this.pnUser.Controls.Add(this.picAvatar);
            this.pnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnUser.Location = new System.Drawing.Point(0, 0);
            this.pnUser.Margin = new System.Windows.Forms.Padding(2);
            this.pnUser.Name = "pnUser";
            this.pnUser.Size = new System.Drawing.Size(253, 110);
            this.pnUser.TabIndex = 3;
            // 
            // lbRole
            // 
            this.lbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbRole.Location = new System.Drawing.Point(64, 56);
            this.lbRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(160, 24);
            this.lbRole.TabIndex = 4;
            this.lbRole.Text = "Role";
            this.lbRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbName.Location = new System.Drawing.Point(64, 32);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(160, 24);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picAvatar
            // 
            this.picAvatar.ImageRotate = 0F;
            this.picAvatar.Location = new System.Drawing.Point(4, 28);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picAvatar.Size = new System.Drawing.Size(56, 56);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 1;
            this.picAvatar.TabStop = false;
            // 
            // pnFooter
            // 
            this.pnFooter.AutoScroll = true;
            this.pnFooter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnFooter.Controls.Add(this.pnContainLogOut);
            this.pnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFooter.Location = new System.Drawing.Point(0, 546);
            this.pnFooter.Margin = new System.Windows.Forms.Padding(2);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(253, 134);
            this.pnFooter.TabIndex = 4;
            // 
            // pnContainLogOut
            // 
            this.pnContainLogOut.BackColor = System.Drawing.Color.White;
            this.pnContainLogOut.BorderColor = System.Drawing.Color.DarkGray;
            this.pnContainLogOut.BorderRadius = 15;
            this.pnContainLogOut.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.pnContainLogOut.BorderThickness = 3;
            this.pnContainLogOut.Controls.Add(this.picLogOut);
            this.pnContainLogOut.Controls.Add(this.btnLogOut);
            this.pnContainLogOut.Location = new System.Drawing.Point(3, 63);
            this.pnContainLogOut.Name = "pnContainLogOut";
            this.pnContainLogOut.Padding = new System.Windows.Forms.Padding(10);
            this.pnContainLogOut.Size = new System.Drawing.Size(248, 68);
            this.pnContainLogOut.TabIndex = 0;
            this.pnContainLogOut.MouseLeave += new System.EventHandler(this.pnContainLogOut_MouseLeave);
            // 
            // picLogOut
            // 
            this.picLogOut.Image = global::App_Library.Properties.Resources.icons8_log_out1;
            this.picLogOut.ImageRotate = 0F;
            this.picLogOut.Location = new System.Drawing.Point(17, 15);
            this.picLogOut.Name = "picLogOut";
            this.picLogOut.Size = new System.Drawing.Size(40, 40);
            this.picLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogOut.TabIndex = 0;
            this.picLogOut.TabStop = false;
            this.picLogOut.Visible = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BorderColor = System.Drawing.Color.White;
            this.btnLogOut.BorderRadius = 5;
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.FillColor = System.Drawing.Color.White;
            this.btnLogOut.FocusedColor = System.Drawing.Color.Blue;
            this.btnLogOut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLogOut.Image = global::App_Library.Properties.Resources.icons8_log_out2;
            this.btnLogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLogOut.Location = new System.Drawing.Point(9, 11);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(228, 48);
            this.btnLogOut.TabIndex = 18;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            this.btnLogOut.MouseHover += new System.EventHandler(this.btnLogOut_MouseHover);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1280, 680);
            this.Controls.Add(this.pnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnMain.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.pnLeft.ResumeLayout(false);
            this.pnUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnFooter.ResumeLayout(false);
            this.pnContainLogOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnMain;
        private ToolStripMenuItem profileToolStripMenuItem;
        public Panel pnContent;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Panel pnLeft;
        public Panel pnSideBar;
        private Panel pnUser;
        private Label lbRole;
        private Label lbName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picAvatar;
        private Panel pnFooter;
        private Guna.UI2.WinForms.Guna2Panel pnContainLogOut;
        private Guna.UI2.WinForms.Guna2PictureBox picLogOut;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
    }
}
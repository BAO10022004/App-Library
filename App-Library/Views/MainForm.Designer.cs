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
            this.components = new System.ComponentModel.Container();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.pnSideBar = new System.Windows.Forms.Panel();
            this.pnUser = new System.Windows.Forms.Panel();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.picAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnFooter = new System.Windows.Forms.Panel();
            this.gnPanelHelp = new Guna.UI2.WinForms.Guna2Panel();
            this.lbHelp = new System.Windows.Forms.Label();
            this.gnPanelSetting = new Guna.UI2.WinForms.Guna2Panel();
            this.lbSetting = new System.Windows.Forms.Label();
            this.timerPicHome = new System.Windows.Forms.Timer(this.components);
            this.timerPicShop = new System.Windows.Forms.Timer(this.components);
            this.pnContent = new System.Windows.Forms.Panel();
            this.pnLeft.SuspendLayout();
            this.pnUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.pnFooter.SuspendLayout();
            this.gnPanelHelp.SuspendLayout();
            this.gnPanelSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.Blue;
            this.pnLeft.Controls.Add(this.pnSideBar);
            this.pnLeft.Controls.Add(this.pnUser);
            this.pnLeft.Controls.Add(this.pnFooter);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Margin = new System.Windows.Forms.Padding(2);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(250, 680);
            this.pnLeft.TabIndex = 1;
            // 
            // pnSideBar
            // 
            this.pnSideBar.BackColor = System.Drawing.Color.Salmon;
            this.pnSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSideBar.Location = new System.Drawing.Point(0, 110);
            this.pnSideBar.Margin = new System.Windows.Forms.Padding(2);
            this.pnSideBar.Name = "pnSideBar";
            this.pnSideBar.Size = new System.Drawing.Size(250, 455);
            this.pnSideBar.TabIndex = 5;
            // 
            // pnUser
            // 
            this.pnUser.BackColor = System.Drawing.Color.White;
            this.pnUser.Controls.Add(this.lbRole);
            this.pnUser.Controls.Add(this.lbName);
            this.pnUser.Controls.Add(this.picAvatar);
            this.pnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnUser.Location = new System.Drawing.Point(0, 0);
            this.pnUser.Margin = new System.Windows.Forms.Padding(2);
            this.pnUser.Name = "pnUser";
            this.pnUser.Size = new System.Drawing.Size(250, 110);
            this.pnUser.TabIndex = 3;
            // 
            // lbRole
            // 
            this.lbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
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
            this.picAvatar.ContextMenuStrip = this.guna2ContextMenuStrip1;
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
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.guna2ContextMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.guna2ContextMenuStrip1.Margin = new System.Windows.Forms.Padding(10);
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.Aqua;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(185, 78);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Image = global::App_Library.Properties.Resources.account;
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = global::App_Library.Properties.Resources.logout;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // pnFooter
            // 
            this.pnFooter.AutoScroll = true;
            this.pnFooter.BackColor = System.Drawing.Color.White;
            this.pnFooter.Controls.Add(this.gnPanelHelp);
            this.pnFooter.Controls.Add(this.gnPanelSetting);
            this.pnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFooter.Location = new System.Drawing.Point(0, 565);
            this.pnFooter.Margin = new System.Windows.Forms.Padding(2);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(250, 115);
            this.pnFooter.TabIndex = 4;
            // 
            // gnPanelHelp
            // 
            this.gnPanelHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gnPanelHelp.BackColor = System.Drawing.Color.White;
            this.gnPanelHelp.Controls.Add(this.lbHelp);
            this.gnPanelHelp.Location = new System.Drawing.Point(0, 60);
            this.gnPanelHelp.Margin = new System.Windows.Forms.Padding(2);
            this.gnPanelHelp.Name = "gnPanelHelp";
            this.gnPanelHelp.Size = new System.Drawing.Size(250, 50);
            this.gnPanelHelp.TabIndex = 4;
            // 
            // lbHelp
            // 
            this.lbHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHelp.Location = new System.Drawing.Point(50, 0);
            this.lbHelp.Margin = new System.Windows.Forms.Padding(0);
            this.lbHelp.Name = "lbHelp";
            this.lbHelp.Size = new System.Drawing.Size(200, 50);
            this.lbHelp.TabIndex = 0;
            this.lbHelp.Text = "Help";
            this.lbHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbHelp.Click += new System.EventHandler(this.lbHelp_Click);
            // 
            // gnPanelSetting
            // 
            this.gnPanelSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gnPanelSetting.BackColor = System.Drawing.Color.White;
            this.gnPanelSetting.Controls.Add(this.lbSetting);
            this.gnPanelSetting.Location = new System.Drawing.Point(0, 5);
            this.gnPanelSetting.Margin = new System.Windows.Forms.Padding(2);
            this.gnPanelSetting.Name = "gnPanelSetting";
            this.gnPanelSetting.Size = new System.Drawing.Size(250, 50);
            this.gnPanelSetting.TabIndex = 3;
            // 
            // lbSetting
            // 
            this.lbSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSetting.Location = new System.Drawing.Point(50, 0);
            this.lbSetting.Margin = new System.Windows.Forms.Padding(0);
            this.lbSetting.Name = "lbSetting";
            this.lbSetting.Size = new System.Drawing.Size(200, 50);
            this.lbSetting.TabIndex = 0;
            this.lbSetting.Text = "Setting";
            this.lbSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbSetting.Click += new System.EventHandler(this.lbSetting_Click);
            // 
            // timerPicHome
            // 
            this.timerPicHome.Interval = 5;
            // 
            // timerPicShop
            // 
            this.timerPicShop.Interval = 5;
            // 
            // pnContent
            // 
            this.pnContent.BackColor = System.Drawing.Color.AliceBlue;
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(250, 0);
            this.pnContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(1030, 680);
            this.pnContent.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1280, 680);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.pnLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnLeft.ResumeLayout(false);
            this.pnUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.pnFooter.ResumeLayout(false);
            this.gnPanelHelp.ResumeLayout(false);
            this.gnPanelSetting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnUser;
        private System.Windows.Forms.Label lbName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picAvatar;
        private Timer timerPicHome;
        private Timer timerPicShop;
        private Panel pnContent;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private Panel pnFooter;
        private Guna.UI2.WinForms.Guna2Panel gnPanelHelp;
        private Label lbHelp;
        private Guna.UI2.WinForms.Guna2Panel gnPanelSetting;
        private Label lbSetting;
        private Label lbRole;
        private Panel pnSideBar;
    }
}
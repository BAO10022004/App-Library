﻿using System.Drawing;
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
            this.timerPicHome = new System.Windows.Forms.Timer(this.components);
            this.pnContent = new System.Windows.Forms.Panel();
            this.pnMain = new Guna.UI2.WinForms.Guna2Panel();
            this.pnFooter = new System.Windows.Forms.Panel();
            this.pnContainLogOut = new Guna.UI2.WinForms.Guna2Panel();
            this.picLogOut = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.pnSideBar = new System.Windows.Forms.Panel();
            this.pnUser = new System.Windows.Forms.Panel();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.picAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerPicShop = new System.Windows.Forms.Timer(this.components);
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnFooter.SuspendLayout();
            this.pnContainLogOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogOut)).BeginInit();
            this.pnLeft.SuspendLayout();
            this.pnUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerPicHome
            // 
            this.timerPicHome.Interval = 5;
            this.timerPicHome.Tick += new System.EventHandler(this.timerPicHome_Tick);
            // 
            // pnContent
            // 
            this.pnContent.BackColor = System.Drawing.Color.AliceBlue;
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(253, 0);
            this.pnContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(1027, 680);
            this.pnContent.TabIndex = 5;
            this.pnContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnContent_Paint);
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1280, 680);
            this.pnMain.TabIndex = 0;
            this.pnMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMain_Paint);
            // 
            // pnFooter
            // 
            this.pnFooter.AutoScroll = true;
            this.pnFooter.BackColor = System.Drawing.Color.Black;
            this.pnFooter.Controls.Add(this.pnContainLogOut);
            this.pnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFooter.Location = new System.Drawing.Point(0, 546);
            this.pnFooter.Margin = new System.Windows.Forms.Padding(2);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(253, 134);
            this.pnFooter.TabIndex = 4;
            this.pnFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnFooter_Paint);
            // 
            // pnContainLogOut
            // 
            this.pnContainLogOut.BorderColor = System.Drawing.Color.Black;
            this.pnContainLogOut.BorderRadius = 15;
            this.pnContainLogOut.BorderThickness = 3;
            this.pnContainLogOut.Controls.Add(this.picLogOut);
            this.pnContainLogOut.Controls.Add(this.btnLogOut);
            this.pnContainLogOut.Location = new System.Drawing.Point(3, 63);
            this.pnContainLogOut.Name = "pnContainLogOut";
            this.pnContainLogOut.Padding = new System.Windows.Forms.Padding(10);
            this.pnContainLogOut.Size = new System.Drawing.Size(248, 68);
            this.pnContainLogOut.TabIndex = 0;
            this.pnContainLogOut.MouseHover += new System.EventHandler(this.btnLogOut_MouseHover);
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
            this.btnLogOut.BorderRadius = 5;
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogOut.FillColor = System.Drawing.Color.Black;
            this.btnLogOut.FocusedColor = System.Drawing.Color.LightCyan;
            this.btnLogOut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.btnLogOut.ForeColor = System.Drawing.Color.Aqua;
            this.btnLogOut.Image = global::App_Library.Properties.Resources.icons8_log_out2;
            this.btnLogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLogOut.Location = new System.Drawing.Point(10, 10);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(228, 48);
            this.btnLogOut.TabIndex = 18;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            this.btnLogOut.MouseLeave += new System.EventHandler(this.pnContainLogOut_MouseLeave);
            this.btnLogOut.MouseHover += new System.EventHandler(this.btnLogOut_MouseHover);
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
            this.pnLeft.Size = new System.Drawing.Size(253, 680);
            this.pnLeft.TabIndex = 4;
            this.pnLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.pnLeft_Paint);
            // 
            // pnSideBar
            // 
            this.pnSideBar.BackColor = System.Drawing.Color.Salmon;
            this.pnSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSideBar.Location = new System.Drawing.Point(0, 110);
            this.pnSideBar.Margin = new System.Windows.Forms.Padding(2);
            this.pnSideBar.Name = "pnSideBar";
            this.pnSideBar.Size = new System.Drawing.Size(253, 436);
            this.pnSideBar.TabIndex = 5;
            this.pnSideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnSideBar_Paint);
            // 
            // pnUser
            // 
            this.pnUser.BackColor = System.Drawing.Color.Black;
            this.pnUser.Controls.Add(this.lbRole);
            this.pnUser.Controls.Add(this.lbName);
            this.pnUser.Controls.Add(this.picAvatar);
            this.pnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnUser.Location = new System.Drawing.Point(0, 0);
            this.pnUser.Margin = new System.Windows.Forms.Padding(2);
            this.pnUser.Name = "pnUser";
            this.pnUser.Size = new System.Drawing.Size(253, 110);
            this.pnUser.TabIndex = 3;
            this.pnUser.Paint += new System.Windows.Forms.PaintEventHandler(this.pnUser_Paint);
            // 
            // lbRole
            // 
            this.lbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbRole.ForeColor = System.Drawing.Color.Aqua;
            this.lbRole.Location = new System.Drawing.Point(64, 56);
            this.lbRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(160, 24);
            this.lbRole.TabIndex = 4;
            this.lbRole.Text = "Role";
            this.lbRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbRole.Click += new System.EventHandler(this.lbRole_Click);
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbName.ForeColor = System.Drawing.Color.Aqua;
            this.lbName.Location = new System.Drawing.Point(64, 32);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(160, 24);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbName.Click += new System.EventHandler(this.lbName_Click);
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
            this.picAvatar.Click += new System.EventHandler(this.picAvatar_Click);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(134, 30);
            this.guna2ContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.guna2ContextMenuStrip1_Opening);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = global::App_Library.Properties.Resources.logout;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click_1);
            // 
            // timerPicShop
            // 
            this.timerPicShop.Interval = 5;
            this.timerPicShop.Tick += new System.EventHandler(this.timerPicShop_Tick);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Image = global::App_Library.Properties.Resources.account;
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1280, 680);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnFooter.ResumeLayout(false);
            this.pnContainLogOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogOut)).EndInit();
            this.pnLeft.ResumeLayout(false);
            this.pnUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Timer timerPicHome;
        private Guna.UI2.WinForms.Guna2Panel pnMain;
        private Panel pnFooter;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Panel pnLeft;
        private Panel pnSideBar;
        private Panel pnUser;
        private Label lbRole;
        private Label lbName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picAvatar;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
        private Timer timerPicShop;
        private Guna.UI2.WinForms.Guna2Panel pnContainLogOut;
        private Guna.UI2.WinForms.Guna2PictureBox picLogOut;
        public Panel pnContent;
    }
}
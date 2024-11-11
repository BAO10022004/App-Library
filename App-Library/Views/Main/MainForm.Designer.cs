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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnSideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnListsButton = new System.Windows.Forms.FlowLayoutPanel();
            this.pnHome = new Guna.UI2.WinForms.Guna2Panel();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.lbHome = new System.Windows.Forms.Label();
            this.pnShop = new Guna.UI2.WinForms.Guna2Panel();
            this.picShop = new System.Windows.Forms.PictureBox();
            this.lbShop = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gneSearchmain = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gnePnContainContent = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timerPicHome = new System.Windows.Forms.Timer(this.components);
            this.timerPicShop = new System.Windows.Forms.Timer(this.components);
            this.pnContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnSideBar.SuspendLayout();
            this.pnListsButton.SuspendLayout();
            this.pnHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.pnShop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShop)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pnSideBar);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 826);
            this.panel1.TabIndex = 1;
            // 
            // pnSideBar
            // 
            this.pnSideBar.Controls.Add(this.pnListsButton);
            this.pnSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSideBar.Location = new System.Drawing.Point(0, 129);
            this.pnSideBar.Name = "pnSideBar";
            this.pnSideBar.Size = new System.Drawing.Size(236, 697);
            this.pnSideBar.TabIndex = 4;
            // 
            // pnListsButton
            // 
            this.pnListsButton.Controls.Add(this.pnHome);
            this.pnListsButton.Controls.Add(this.pnShop);
            this.pnListsButton.Location = new System.Drawing.Point(3, 3);
            this.pnListsButton.Name = "pnListsButton";
            this.pnListsButton.Size = new System.Drawing.Size(233, 733);
            this.pnListsButton.TabIndex = 3;
            // 
            // pnHome
            // 
            this.pnHome.BackColor = System.Drawing.Color.White;
            this.pnHome.Controls.Add(this.picHome);
            this.pnHome.Controls.Add(this.lbHome);
            this.pnHome.Location = new System.Drawing.Point(3, 3);
            this.pnHome.Name = "pnHome";
            this.pnHome.Size = new System.Drawing.Size(230, 60);
            this.pnHome.TabIndex = 2;
            // 
            // picHome
            // 
            this.picHome.BackColor = System.Drawing.Color.Transparent;
            this.picHome.Image = global::App_Library.Properties.Resources.HomeHover;
            this.picHome.Location = new System.Drawing.Point(6, 15);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(32, 32);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHome.TabIndex = 1;
            this.picHome.TabStop = false;
            // 
            // lbHome
            // 
            this.lbHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHome.Location = new System.Drawing.Point(71, 0);
            this.lbHome.Margin = new System.Windows.Forms.Padding(0);
            this.lbHome.Name = "lbHome";
            this.lbHome.Size = new System.Drawing.Size(159, 73);
            this.lbHome.TabIndex = 0;
            this.lbHome.Text = "Home";
            this.lbHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbHome.Click += new System.EventHandler(this.lbHome_Click);
            // 
            // pnShop
            // 
            this.pnShop.Controls.Add(this.picShop);
            this.pnShop.Controls.Add(this.lbShop);
            this.pnShop.Location = new System.Drawing.Point(3, 69);
            this.pnShop.Name = "pnShop";
            this.pnShop.Size = new System.Drawing.Size(230, 60);
            this.pnShop.TabIndex = 3;
            // 
            // picShop
            // 
            this.picShop.Image = global::App_Library.Properties.Resources.book_fair;
            this.picShop.Location = new System.Drawing.Point(6, 15);
            this.picShop.Name = "picShop";
            this.picShop.Size = new System.Drawing.Size(32, 32);
            this.picShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShop.TabIndex = 1;
            this.picShop.TabStop = false;
            // 
            // lbShop
            // 
            this.lbShop.BackColor = System.Drawing.Color.White;
            this.lbShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbShop.Location = new System.Drawing.Point(71, 0);
            this.lbShop.Margin = new System.Windows.Forms.Padding(0);
            this.lbShop.Name = "lbShop";
            this.lbShop.Size = new System.Drawing.Size(162, 62);
            this.lbShop.TabIndex = 1;
            this.lbShop.Text = "Shop";
            this.lbShop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbShop.Click += new System.EventHandler(this.lbShop_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lbName);
            this.panel4.Controls.Add(this.guna2CirclePictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 129);
            this.panel4.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbName.Location = new System.Drawing.Point(-1, 88);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(236, 29);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.ContextMenuStrip = this.guna2ContextMenuStrip1;
            this.guna2CirclePictureBox1.Image = global::App_Library.Properties.Resources.IconLogin;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(81, 11);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(60, 60);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 1;
            this.guna2CirclePictureBox1.TabStop = false;
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
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(215, 84);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Image = global::App_Library.Properties.Resources.account;
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = global::App_Library.Properties.Resources.logout;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.logOutToolStripMenuItem.Text = "LogOut";
            // 
            // gneSearchmain
            // 
            this.gneSearchmain.BorderRadius = 30;
            // 
            // gnePnContainContent
            // 
            this.gnePnContainContent.BorderRadius = 30;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            // 
            // timerPicHome
            // 
            this.timerPicHome.Interval = 5;
            this.timerPicHome.Tick += new System.EventHandler(this.timerPicHome_Tick);
            // 
            // timerPicShop
            // 
            this.timerPicShop.Interval = 5;
            this.timerPicShop.Tick += new System.EventHandler(this.timerPicShop_Tick);
            // 
            // pnContent
            // 
            this.pnContent.BackColor = System.Drawing.Color.AliceBlue;
            this.pnContent.Location = new System.Drawing.Point(242, 0);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(1340, 826);
            this.pnContent.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1584, 826);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.pnSideBar.ResumeLayout(false);
            this.pnListsButton.ResumeLayout(false);
            this.pnHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.pnShop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picShop)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse gneSearchmain;
        private Guna.UI2.WinForms.Guna2Elipse gnePnContainContent;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.FlowLayoutPanel pnSideBar;
        private System.Windows.Forms.Label lbHome;
        private System.Windows.Forms.Label lbShop;
        private System.Windows.Forms.FlowLayoutPanel pnListsButton;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;

        private System.Windows.Forms.PictureBox picHome;
        private Guna.UI2.WinForms.Guna2Panel pnHome;
        private Guna.UI2.WinForms.Guna2Panel pnShop;
        private System.Windows.Forms.PictureBox picShop;
        private Timer timerPicHome;
        private Timer timerPicShop;
        private Panel pnContent;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
    }
}
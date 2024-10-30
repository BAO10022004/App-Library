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
            this.pnHome = new System.Windows.Forms.Panel();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.lbHome = new System.Windows.Forms.Label();
            this.pnShop = new System.Windows.Forms.Panel();
            this.picShop = new System.Windows.Forms.PictureBox();
            this.lbShop = new System.Windows.Forms.Label();
            this.lbLogOut = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnSearchMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
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
            this.pnSearchMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(325, 826);
            this.panel1.TabIndex = 1;
            // 
            // pnSideBar
            // 
            this.pnSideBar.Controls.Add(this.pnListsButton);
            this.pnSideBar.Controls.Add(this.lbLogOut);
            this.pnSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSideBar.Location = new System.Drawing.Point(0, 168);
            this.pnSideBar.Name = "pnSideBar";
            this.pnSideBar.Size = new System.Drawing.Size(325, 658);
            this.pnSideBar.TabIndex = 4;
            // 
            // pnListsButton
            // 
            this.pnListsButton.Controls.Add(this.pnHome);
            this.pnListsButton.Controls.Add(this.pnShop);
            this.pnListsButton.Location = new System.Drawing.Point(3, 3);
            this.pnListsButton.Name = "pnListsButton";
            this.pnListsButton.Size = new System.Drawing.Size(322, 582);
            this.pnListsButton.TabIndex = 3;
            // 
            // pnHome
            // 
            this.pnHome.BackColor = System.Drawing.Color.White;
            this.pnHome.Controls.Add(this.picHome);
            this.pnHome.Controls.Add(this.lbHome);
            this.pnHome.Location = new System.Drawing.Point(3, 3);
            this.pnHome.Name = "pnHome";
            this.pnHome.Size = new System.Drawing.Size(319, 73);
            this.pnHome.TabIndex = 2;
            // 
            // picHome
            // 
            this.picHome.BackColor = System.Drawing.Color.Transparent;
            this.picHome.Image = global::App_Library.Properties.Resources.HomeHover;
            this.picHome.Location = new System.Drawing.Point(27, 20);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(32, 32);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHome.TabIndex = 1;
            this.picHome.TabStop = false;
            // 
            // lbHome
            // 
            this.lbHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHome.Location = new System.Drawing.Point(111, 0);
            this.lbHome.Margin = new System.Windows.Forms.Padding(0);
            this.lbHome.Name = "lbHome";
            this.lbHome.Size = new System.Drawing.Size(208, 73);
            this.lbHome.TabIndex = 0;
            this.lbHome.Text = "Home";
            this.lbHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbHome.Click += new System.EventHandler(this.lbHome_Click);
            // 
            // pnShop
            // 
            this.pnShop.Controls.Add(this.picShop);
            this.pnShop.Controls.Add(this.lbShop);
            this.pnShop.Location = new System.Drawing.Point(3, 82);
            this.pnShop.Name = "pnShop";
            this.pnShop.Size = new System.Drawing.Size(319, 73);
            this.pnShop.TabIndex = 3;
            // 
            // picShop
            // 
            this.picShop.Image = global::App_Library.Properties.Resources.book_fair;
            this.picShop.Location = new System.Drawing.Point(27, 21);
            this.picShop.Name = "picShop";
            this.picShop.Size = new System.Drawing.Size(32, 32);
            this.picShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShop.TabIndex = 1;
            this.picShop.TabStop = false;
            // 
            // lbShop
            // 
            this.lbShop.BackColor = System.Drawing.Color.White;
            this.lbShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbShop.Location = new System.Drawing.Point(117, 0);
            this.lbShop.Margin = new System.Windows.Forms.Padding(0);
            this.lbShop.Name = "lbShop";
            this.lbShop.Size = new System.Drawing.Size(199, 73);
            this.lbShop.TabIndex = 1;
            this.lbShop.Text = "Shop";
            this.lbShop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbShop.Click += new System.EventHandler(this.lbShop_Click);
            // 
            // lbLogOut
            // 
            this.lbLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLogOut.Location = new System.Drawing.Point(3, 588);
            this.lbLogOut.Name = "lbLogOut";
            this.lbLogOut.Size = new System.Drawing.Size(319, 70);
            this.lbLogOut.TabIndex = 2;
            this.lbLogOut.Text = "LogOut";
            this.lbLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.pnSearchMain);
            this.panel4.Controls.Add(this.lbName);
            this.panel4.Controls.Add(this.lbEmail);
            this.panel4.Controls.Add(this.guna2CirclePictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(325, 168);
            this.panel4.TabIndex = 3;
            // 
            // pnSearchMain
            // 
            this.pnSearchMain.BackColor = System.Drawing.Color.LightGray;
            this.pnSearchMain.Controls.Add(this.pictureBox1);
            this.pnSearchMain.Controls.Add(this.txbSearch);
            this.pnSearchMain.Location = new System.Drawing.Point(12, 116);
            this.pnSearchMain.Name = "pnSearchMain";
            this.pnSearchMain.Size = new System.Drawing.Size(303, 46);
            this.pnSearchMain.TabIndex = 6;
            this.pnSearchMain.Click += new System.EventHandler(this.pnSearchMain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App_Library.Properties.Resources.magnifying_glass__1_;
            this.pictureBox1.Location = new System.Drawing.Point(256, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txbSearch
            // 
            this.txbSearch.BackColor = System.Drawing.Color.LightGray;
            this.txbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSearch.Enabled = false;
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbSearch.Location = new System.Drawing.Point(7, 10);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(227, 20);
            this.txbSearch.TabIndex = 0;
            this.txbSearch.Click += new System.EventHandler(this.txbSearch_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbName.Location = new System.Drawing.Point(92, 43);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(82, 29);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Name";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbEmail.Location = new System.Drawing.Point(93, 72);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(232, 20);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "Giabaoonthcs123@gmail.com";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::App_Library.Properties.Resources.IconLogin;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(8, 24);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(80, 80);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 1;
            this.guna2CirclePictureBox1.TabStop = false;
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
            this.guna2Elipse1.TargetControl = this.pnSearchMain;
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
            this.pnContent.Location = new System.Drawing.Point(331, 0);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(1251, 826);
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
            this.panel4.PerformLayout();
            this.pnSearchMain.ResumeLayout(false);
            this.pnSearchMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse gneSearchmain;
        private Guna.UI2.WinForms.Guna2Elipse gnePnContainContent;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnSearchMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Label lbName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.FlowLayoutPanel pnSideBar;
        private System.Windows.Forms.Label lbHome;
        private System.Windows.Forms.Label lbShop;
        private System.Windows.Forms.Label lbLogOut;
        private System.Windows.Forms.FlowLayoutPanel pnListsButton;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lbEmail;

        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Panel pnHome;
        private System.Windows.Forms.Panel pnShop;
        private System.Windows.Forms.PictureBox picShop;
        private Timer timerPicHome;
        private Timer timerPicShop;
        private Panel pnContent;
    }
}
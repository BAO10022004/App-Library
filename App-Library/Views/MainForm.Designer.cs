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
            this.lbHome = new System.Windows.Forms.Label();
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
            this.pnContent = new System.Windows.Forms.Panel();
            this.pbLoadBook = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.bgwLoadBook = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.pnSideBar.SuspendLayout();
            this.pnListsButton.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnSearchMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.pnContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            this.pnListsButton.Controls.Add(this.lbHome);
            this.pnListsButton.Controls.Add(this.lbShop);
            this.pnListsButton.Location = new System.Drawing.Point(3, 3);
            this.pnListsButton.Name = "pnListsButton";
            this.pnListsButton.Size = new System.Drawing.Size(322, 582);
            this.pnListsButton.TabIndex = 3;
            // 
            // lbHome
            // 
            this.lbHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHome.Location = new System.Drawing.Point(0, 0);
            this.lbHome.Margin = new System.Windows.Forms.Padding(0);
            this.lbHome.Name = "lbHome";
            this.lbHome.Size = new System.Drawing.Size(319, 62);
            this.lbHome.TabIndex = 0;
            this.lbHome.Text = "Home";
            this.lbHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbHome.Click += new System.EventHandler(this.lbHome_Click);
            // 
            // lbShop
            // 
            this.lbShop.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbShop.Location = new System.Drawing.Point(0, 62);
            this.lbShop.Margin = new System.Windows.Forms.Padding(0);
            this.lbShop.Name = "lbShop";
            this.lbShop.Size = new System.Drawing.Size(319, 62);
            this.lbShop.TabIndex = 1;
            this.lbShop.Text = "Shop";
            this.lbShop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panel4.BackColor = System.Drawing.Color.DeepSkyBlue;
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
            this.pnSearchMain.BackColor = System.Drawing.Color.White;
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
            this.txbSearch.BackColor = System.Drawing.Color.White;
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
            this.lbName.Click += new System.EventHandler(this.lbName_Click);
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
            // pnContent
            // 
            this.pnContent.BackColor = System.Drawing.Color.AliceBlue;
            this.pnContent.Controls.Add(this.pbLoadBook);
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(325, 0);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(1259, 826);
            this.pnContent.TabIndex = 2;
            // 
            // pbLoadBook
            // 
            this.pbLoadBook.AutoStart = true;
            this.pbLoadBook.BackColor = System.Drawing.Color.Transparent;
            this.pbLoadBook.Location = new System.Drawing.Point(629, 425);
            this.pbLoadBook.Name = "pbLoadBook";
            this.pbLoadBook.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pbLoadBook.Size = new System.Drawing.Size(90, 90);
            this.pbLoadBook.TabIndex = 1;
            // 
            // bgwLoadBook
            // 
            this.bgwLoadBook.WorkerReportsProgress = true;
            this.bgwLoadBook.WorkerSupportsCancellation = true;
            this.bgwLoadBook.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwLoadDB_DoWorkAsync);
            this.bgwLoadBook.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwLoadDB_ProgressChanged);
            this.bgwLoadBook.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwLoadDB_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
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
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnSearchMain.ResumeLayout(false);
            this.pnSearchMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.pnContent.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnContent;
        private System.ComponentModel.BackgroundWorker bgwLoadBook;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator pbLoadBook;
    }
}
namespace App_Library.Views.Main.CollectionShop
{
    partial class NewShopMain
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
            this.pnContainSearch = new Guna.UI2.WinForms.Guna2Panel();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.pnSearchShop = new Guna.UI2.WinForms.Guna2Panel();
            this.pnContainTextSearch = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnOptionViewBook = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnProperties = new Guna.UI2.WinForms.Guna2Panel();
            this.pnMainForm = new System.Windows.Forms.FlowLayoutPanel();
            this.pnAd = new Guna.UI2.WinForms.Guna2Panel();
            this.pnHotDeal = new Guna.UI2.WinForms.Guna2Panel();
            this.pnBestSelling = new Guna.UI2.WinForms.Guna2Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.geSearch = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.geTextBoxSerch = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.geButtonSearch = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timerDownClick = new System.Windows.Forms.Timer(this.components);
            this.timerUpClick = new System.Windows.Forms.Timer(this.components);
            this.pnContainSearch.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.pnSearchShop.SuspendLayout();
            this.pnContainTextSearch.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnOptionViewBook.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.pnMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContainSearch
            // 
            this.pnContainSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnContainSearch.Controls.Add(this.pnSearch);
            this.pnContainSearch.Controls.Add(this.pnOptionViewBook);
            this.pnContainSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContainSearch.Location = new System.Drawing.Point(0, 0);
            this.pnContainSearch.Name = "pnContainSearch";
            this.pnContainSearch.Size = new System.Drawing.Size(1340, 200);
            this.pnContainSearch.TabIndex = 0;
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.pnSearchShop);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSearch.Location = new System.Drawing.Point(0, 0);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(1340, 116);
            this.pnSearch.TabIndex = 6;
            // 
            // pnSearchShop
            // 
            this.pnSearchShop.BackColor = System.Drawing.Color.MintCream;
            this.pnSearchShop.BorderColor = System.Drawing.Color.PaleGreen;
            this.pnSearchShop.BorderRadius = 26;
            this.pnSearchShop.BorderThickness = 3;
            this.pnSearchShop.Controls.Add(this.pnContainTextSearch);
            this.pnSearchShop.Controls.Add(this.guna2Panel1);
            this.pnSearchShop.Location = new System.Drawing.Point(303, 19);
            this.pnSearchShop.Name = "pnSearchShop";
            this.pnSearchShop.Size = new System.Drawing.Size(735, 73);
            this.pnSearchShop.TabIndex = 2;
            // 
            // pnContainTextSearch
            // 
            this.pnContainTextSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnContainTextSearch.Controls.Add(this.txtSearch);
            this.pnContainTextSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainTextSearch.Location = new System.Drawing.Point(0, 0);
            this.pnContainTextSearch.Name = "pnContainTextSearch";
            this.pnContainTextSearch.Size = new System.Drawing.Size(654, 73);
            this.pnContainTextSearch.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(31, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Lime;
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(541, 48);
            this.txtSearch.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2Panel1.BorderThickness = 4;
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel1.Location = new System.Drawing.Point(654, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(81, 73);
            this.guna2Panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Honeydew;
            this.pictureBox1.Image = global::App_Library.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(6, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnOptionViewBook
            // 
            this.pnOptionViewBook.Controls.Add(this.guna2Panel6);
            this.pnOptionViewBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnOptionViewBook.Location = new System.Drawing.Point(0, 116);
            this.pnOptionViewBook.Name = "pnOptionViewBook";
            this.pnOptionViewBook.Size = new System.Drawing.Size(1340, 84);
            this.pnOptionViewBook.TabIndex = 5;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel6.BorderRadius = 15;
            this.guna2Panel6.BorderThickness = 3;
            this.guna2Panel6.Controls.Add(this.label2);
            this.guna2Panel6.ForeColor = System.Drawing.Color.White;
            this.guna2Panel6.Location = new System.Drawing.Point(0, 3);
            this.guna2Panel6.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(109, 52);
            this.guna2Panel6.TabIndex = 0;
            this.guna2Panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnViewAll_MouseDown);
            this.guna2Panel6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnViewAll_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "All";
            // 
            // pnProperties
            // 
            this.pnProperties.BackColor = System.Drawing.Color.Transparent;
            this.pnProperties.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnProperties.Location = new System.Drawing.Point(1321, 200);
            this.pnProperties.Name = "pnProperties";
            this.pnProperties.Size = new System.Drawing.Size(19, 626);
            this.pnProperties.TabIndex = 1;
            this.pnProperties.Visible = false;
            // 
            // pnMainForm
            // 
            this.pnMainForm.AutoScroll = true;
            this.pnMainForm.BackColor = System.Drawing.Color.Honeydew;
            this.pnMainForm.Controls.Add(this.pnAd);
            this.pnMainForm.Controls.Add(this.pnHotDeal);
            this.pnMainForm.Controls.Add(this.pnBestSelling);
            this.pnMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMainForm.Location = new System.Drawing.Point(0, 200);
            this.pnMainForm.Name = "pnMainForm";
            this.pnMainForm.Size = new System.Drawing.Size(1321, 626);
            this.pnMainForm.TabIndex = 2;
            // 
            // pnAd
            // 
            this.pnAd.BackColor = System.Drawing.Color.Transparent;
            this.pnAd.Location = new System.Drawing.Point(3, 3);
            this.pnAd.Name = "pnAd";
            this.pnAd.Size = new System.Drawing.Size(1300, 350);
            this.pnAd.TabIndex = 2;
            this.pnAd.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pnAd_Scroll);
            // 
            // pnHotDeal
            // 
            this.pnHotDeal.BackColor = System.Drawing.Color.Transparent;
            this.pnHotDeal.Location = new System.Drawing.Point(0, 356);
            this.pnHotDeal.Margin = new System.Windows.Forms.Padding(0);
            this.pnHotDeal.Name = "pnHotDeal";
            this.pnHotDeal.Size = new System.Drawing.Size(1300, 413);
            this.pnHotDeal.TabIndex = 3;
            // 
            // pnBestSelling
            // 
            this.pnBestSelling.BackColor = System.Drawing.Color.Transparent;
            this.pnBestSelling.Location = new System.Drawing.Point(0, 769);
            this.pnBestSelling.Margin = new System.Windows.Forms.Padding(0);
            this.pnBestSelling.Name = "pnBestSelling";
            this.pnBestSelling.Size = new System.Drawing.Size(1300, 413);
            this.pnBestSelling.TabIndex = 4;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompletedAsync);
            // 
            // geSearch
            // 
            this.geSearch.BorderRadius = 50;
            this.geSearch.TargetControl = this.pnSearchShop;
            // 
            // geTextBoxSerch
            // 
            this.geTextBoxSerch.BorderRadius = 40;
            this.geTextBoxSerch.TargetControl = this.txtSearch;
            // 
            // geButtonSearch
            // 
            this.geButtonSearch.BorderRadius = 30;
            this.geButtonSearch.TargetControl = this.pictureBox1;
            // 
            // timerDownClick
            // 
            this.timerDownClick.Interval = 5;
            this.timerDownClick.Tick += new System.EventHandler(this.timerClick_Tick);
            // 
            // timerUpClick
            // 
            this.timerUpClick.Interval = 5;
            this.timerUpClick.Tick += new System.EventHandler(this.timerUpClick_Tick);
            // 
            // NewShopMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1340, 826);
            this.Controls.Add(this.pnMainForm);
            this.Controls.Add(this.pnProperties);
            this.Controls.Add(this.pnContainSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewShopMain";
            this.Text = "NewShopMain";
            this.Load += new System.EventHandler(this.NewShopMain_LoadAsync);
            this.pnContainSearch.ResumeLayout(false);
            this.pnSearch.ResumeLayout(false);
            this.pnSearchShop.ResumeLayout(false);
            this.pnContainTextSearch.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnOptionViewBook.ResumeLayout(false);
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.pnMainForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnContainSearch;
        private Guna.UI2.WinForms.Guna2Panel pnProperties;
        private System.Windows.Forms.FlowLayoutPanel pnMainForm;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Elipse geSearch;
        private Guna.UI2.WinForms.Guna2Elipse geTextBoxSerch;
        private Guna.UI2.WinForms.Guna2Elipse geButtonSearch;
        private System.Windows.Forms.Timer timerDownClick;
        private System.Windows.Forms.Timer timerUpClick;
        private Guna.UI2.WinForms.Guna2Panel pnHotDeal;
        private System.Windows.Forms.Panel pnSearch;
        private Guna.UI2.WinForms.Guna2Panel pnSearchShop;
        private Guna.UI2.WinForms.Guna2Panel pnContainTextSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel pnAd;
        private Guna.UI2.WinForms.Guna2Panel pnBestSelling;
        private Guna.UI2.WinForms.Guna2Panel pnOptionViewBook;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private System.Windows.Forms.Label label2;
    }
}
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
            this.pnSearch = new Guna.UI2.WinForms.Guna2Panel();
            this.pnProperties = new Guna.UI2.WinForms.Guna2Panel();
            this.pnMainForm = new System.Windows.Forms.FlowLayoutPanel();
            this.pnAd = new Guna.UI2.WinForms.Guna2Panel();
            this.pnHotDeal = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bwkCreateHotDeal = new System.ComponentModel.BackgroundWorker();
            this.pnSearchShop = new Guna.UI2.WinForms.Guna2Panel();
            this.geSearch = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnContainTextSearch = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.geTextBoxSerch = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.geButtonSearch = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnSearch.SuspendLayout();
            this.pnMainForm.SuspendLayout();
            this.pnSearchShop.SuspendLayout();
            this.pnContainTextSearch.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSearch
            // 
            this.pnSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnSearch.Controls.Add(this.pnSearchShop);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnSearch.Location = new System.Drawing.Point(0, 741);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(1251, 85);
            this.pnSearch.TabIndex = 0;
            // 
            // pnProperties
            // 
            this.pnProperties.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnProperties.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnProperties.Location = new System.Drawing.Point(1232, 0);
            this.pnProperties.Name = "pnProperties";
            this.pnProperties.Size = new System.Drawing.Size(19, 741);
            this.pnProperties.TabIndex = 1;
            this.pnProperties.Visible = false;
            // 
            // pnMainForm
            // 
            this.pnMainForm.AutoScroll = true;
            this.pnMainForm.BackColor = System.Drawing.Color.Honeydew;
            this.pnMainForm.Controls.Add(this.pnAd);
            this.pnMainForm.Controls.Add(this.pnHotDeal);
            this.pnMainForm.Controls.Add(this.guna2Panel2);
            this.pnMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMainForm.Location = new System.Drawing.Point(0, 0);
            this.pnMainForm.Name = "pnMainForm";
            this.pnMainForm.Size = new System.Drawing.Size(1232, 741);
            this.pnMainForm.TabIndex = 2;
            // 
            // pnAd
            // 
            this.pnAd.BackColor = System.Drawing.Color.Transparent;
            this.pnAd.Location = new System.Drawing.Point(3, 3);
            this.pnAd.Name = "pnAd";
            this.pnAd.Size = new System.Drawing.Size(1188, 419);
            this.pnAd.TabIndex = 2;
            // 
            // pnHotDeal
            // 
            this.pnHotDeal.BackColor = System.Drawing.Color.Transparent;
            this.pnHotDeal.Location = new System.Drawing.Point(0, 425);
            this.pnHotDeal.Margin = new System.Windows.Forms.Padding(0);
            this.pnHotDeal.Name = "pnHotDeal";
            this.pnHotDeal.Size = new System.Drawing.Size(1170, 413);
            this.pnHotDeal.TabIndex = 3;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Location = new System.Drawing.Point(3, 841);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1170, 413);
            this.guna2Panel2.TabIndex = 1;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompletedAsync);
            // 
            // bwkCreateHotDeal
            // 
            this.bwkCreateHotDeal.WorkerReportsProgress = true;
            this.bwkCreateHotDeal.WorkerSupportsCancellation = true;
            this.bwkCreateHotDeal.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwkCreateHotDeal_DoWork);
            this.bwkCreateHotDeal.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwkCreateHotDeal_ProgressChanged);
            this.bwkCreateHotDeal.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwkCreateHotDeal_RunWorkerCompletedAsync);
            // 
            // pnSearchShop
            // 
            this.pnSearchShop.BackColor = System.Drawing.Color.MintCream;
            this.pnSearchShop.BorderColor = System.Drawing.Color.PaleGreen;
            this.pnSearchShop.BorderRadius = 26;
            this.pnSearchShop.BorderThickness = 3;
            this.pnSearchShop.Controls.Add(this.pnContainTextSearch);
            this.pnSearchShop.Controls.Add(this.guna2Panel1);
            this.pnSearchShop.Location = new System.Drawing.Point(304, 6);
            this.pnSearchShop.Name = "pnSearchShop";
            this.pnSearchShop.Size = new System.Drawing.Size(481, 67);
            this.pnSearchShop.TabIndex = 0;
            // 
            // geSearch
            // 
            this.geSearch.BorderRadius = 50;
            this.geSearch.TargetControl = this.pnSearchShop;
            // 
            // pnContainTextSearch
            // 
            this.pnContainTextSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnContainTextSearch.Controls.Add(this.txtSearch);
            this.pnContainTextSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainTextSearch.Location = new System.Drawing.Point(0, 0);
            this.pnContainTextSearch.Name = "pnContainTextSearch";
            this.pnContainTextSearch.Size = new System.Drawing.Size(400, 67);
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
            this.txtSearch.Location = new System.Drawing.Point(18, 8);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Lime;
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(342, 48);
            this.txtSearch.TabIndex = 0;
            // 
            // geTextBoxSerch
            // 
            this.geTextBoxSerch.BorderRadius = 40;
            this.geTextBoxSerch.TargetControl = this.txtSearch;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel1.Location = new System.Drawing.Point(400, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(81, 67);
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
            // geButtonSearch
            // 
            this.geButtonSearch.BorderRadius = 30;
            this.geButtonSearch.TargetControl = this.pictureBox1;
            // 
            // NewShopMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1251, 826);
            this.Controls.Add(this.pnMainForm);
            this.Controls.Add(this.pnProperties);
            this.Controls.Add(this.pnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewShopMain";
            this.Text = "NewShopMain";
            this.Load += new System.EventHandler(this.NewShopMain_LoadAsync);
            this.pnSearch.ResumeLayout(false);
            this.pnMainForm.ResumeLayout(false);
            this.pnSearchShop.ResumeLayout(false);
            this.pnContainTextSearch.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnSearch;
        private Guna.UI2.WinForms.Guna2Panel pnProperties;
        private System.Windows.Forms.FlowLayoutPanel pnMainForm;
        private Guna.UI2.WinForms.Guna2Panel pnHotDeal;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Panel pnAd;
        private System.ComponentModel.BackgroundWorker bwkCreateHotDeal;
        private Guna.UI2.WinForms.Guna2Panel pnSearchShop;
        private Guna.UI2.WinForms.Guna2Elipse geSearch;
        private Guna.UI2.WinForms.Guna2Panel pnContainTextSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Elipse geTextBoxSerch;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse geButtonSearch;
    }
}
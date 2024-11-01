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
            this.pnSearch = new Guna.UI2.WinForms.Guna2Panel();
            this.pnProperties = new Guna.UI2.WinForms.Guna2Panel();
            this.pnMainForm = new System.Windows.Forms.FlowLayoutPanel();
            this.pnAd = new Guna.UI2.WinForms.Guna2Panel();
            this.pnHotDeal = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bwkCreateHotDeal = new System.ComponentModel.BackgroundWorker();
            this.pnMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSearch
            // 
            this.pnSearch.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnSearch.Location = new System.Drawing.Point(0, 754);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(1251, 72);
            this.pnSearch.TabIndex = 0;
            // 
            // pnProperties
            // 
            this.pnProperties.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnProperties.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnProperties.Location = new System.Drawing.Point(1232, 0);
            this.pnProperties.Name = "pnProperties";
            this.pnProperties.Size = new System.Drawing.Size(19, 754);
            this.pnProperties.TabIndex = 1;
            this.pnProperties.Visible = false;
            // 
            // pnMainForm
            // 
            this.pnMainForm.AutoScroll = true;
            this.pnMainForm.BackColor = System.Drawing.Color.RosyBrown;
            this.pnMainForm.Controls.Add(this.pnAd);
            this.pnMainForm.Controls.Add(this.pnHotDeal);
            this.pnMainForm.Controls.Add(this.guna2Panel2);
            this.pnMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMainForm.Location = new System.Drawing.Point(0, 0);
            this.pnMainForm.Name = "pnMainForm";
            this.pnMainForm.Size = new System.Drawing.Size(1232, 754);
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
            this.pnHotDeal.Size = new System.Drawing.Size(1188, 478);
            this.pnHotDeal.TabIndex = 3;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Location = new System.Drawing.Point(3, 906);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1188, 419);
            this.guna2Panel2.TabIndex = 1;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // bwkCreateHotDeal
            // 
            this.bwkCreateHotDeal.WorkerReportsProgress = true;
            this.bwkCreateHotDeal.WorkerSupportsCancellation = true;
            this.bwkCreateHotDeal.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwkCreateHotDeal_DoWork);
            this.bwkCreateHotDeal.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwkCreateHotDeal_ProgressChanged);
            this.bwkCreateHotDeal.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwkCreateHotDeal_RunWorkerCompletedAsync);
            // 
            // NewShopMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1251, 826);
            this.Controls.Add(this.pnMainForm);
            this.Controls.Add(this.pnProperties);
            this.Controls.Add(this.pnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewShopMain";
            this.Text = "NewShopMain";
            this.Load += new System.EventHandler(this.NewShopMain_LoadAsync);
            this.pnMainForm.ResumeLayout(false);
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
    }
}
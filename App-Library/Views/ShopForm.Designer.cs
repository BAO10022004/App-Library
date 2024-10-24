using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace App_Library.Views
{
    partial class ShopForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bgwLoadData = new System.ComponentModel.BackgroundWorker();
            this.pnShopMain = new System.Windows.Forms.Panel();
            this.pbLoadDB = new System.Windows.Forms.ProgressBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnProperties = new System.Windows.Forms.Panel();
            this.pnShopMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bgwLoadData
            // 
            this.bgwLoadData.WorkerReportsProgress = true;
            this.bgwLoadData.WorkerSupportsCancellation = true;
            this.bgwLoadData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwLoadDB_DoWorkAsync);
            this.bgwLoadData.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwLoadDB_ProgressChanged);
            this.bgwLoadData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwLoadDB_RunWorkerCompleted);
            // 
            // pnShopMain
            // 
            this.pnShopMain.Controls.Add(this.pbLoadDB);
            this.pnShopMain.Controls.Add(this.flowLayoutPanel1);
            this.pnShopMain.Location = new System.Drawing.Point(1, 9);
            this.pnShopMain.Name = "pnShopMain";
            this.pnShopMain.Size = new System.Drawing.Size(1259, 829);
            this.pnShopMain.TabIndex = 3;
            this.pnShopMain.Click += new System.EventHandler(this.pnShopMain_Click);
            // 
            // pbLoadDB
            // 
            this.pbLoadDB.Location = new System.Drawing.Point(194, 379);
            this.pbLoadDB.Maximum = 4;
            this.pbLoadDB.Name = "pbLoadDB";
            this.pbLoadDB.Size = new System.Drawing.Size(378, 40);
            this.pbLoadDB.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1259, 353);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pnProperties
            // 
            this.pnProperties.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnProperties.Location = new System.Drawing.Point(1237, 823);
            this.pnProperties.Name = "pnProperties";
            this.pnProperties.Size = new System.Drawing.Size(10, 815);
            this.pnProperties.TabIndex = 5;
            // 
            // ShopForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1259, 826);
            this.Controls.Add(this.pnProperties);
            this.Controls.Add(this.pnShopMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShopForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.pnShopMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        BackgroundWorker bgwLoadDB = new BackgroundWorker();
        private System.Windows.Forms.Timer timer1;
        private BackgroundWorker bgwLoadData;
        private Panel pnShopMain;
        private ProgressBar pbLoadDB;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnProperties;
    }
}
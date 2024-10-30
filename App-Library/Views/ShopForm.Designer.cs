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
            this.timerAd = new System.Windows.Forms.Timer(this.components);
            this.pnProperties = new System.Windows.Forms.Panel();
            this.pnShopMain = new System.Windows.Forms.Panel();
            this.pbLoadData = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BWLoadData = new System.ComponentModel.BackgroundWorker();
            this.timerAd2 = new System.Windows.Forms.Timer(this.components);
            this.pnShopMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerAd
            // 
            this.timerAd.Interval = 1;
            this.timerAd.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnProperties
            // 
            this.pnProperties.BackColor = System.Drawing.SystemColors.Control;
            this.pnProperties.Location = new System.Drawing.Point(1237, 823);
            this.pnProperties.Name = "pnProperties";
            this.pnProperties.Size = new System.Drawing.Size(10, 815);
            this.pnProperties.TabIndex = 5;
            // 
            // pnShopMain
            // 
            this.pnShopMain.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnShopMain.Controls.Add(this.pbLoadData);
            this.pnShopMain.Controls.Add(this.flowLayoutPanel1);
            this.pnShopMain.Location = new System.Drawing.Point(1, 9);
            this.pnShopMain.Name = "pnShopMain";
            this.pnShopMain.Size = new System.Drawing.Size(1259, 829);
            this.pnShopMain.TabIndex = 3;
            this.pnShopMain.Click += new System.EventHandler(this.pnShopMain_Click);
            this.pnShopMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnShopMain_Paint);
            // 
            // pbLoadData
            // 
            this.pbLoadData.Location = new System.Drawing.Point(572, 341);
            this.pbLoadData.Name = "pbLoadData";
            this.pbLoadData.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pbLoadData.Size = new System.Drawing.Size(90, 90);
            this.pbLoadData.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1259, 335);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // BWLoadData
            // 
            this.BWLoadData.WorkerReportsProgress = true;
            this.BWLoadData.WorkerSupportsCancellation = true;
            this.BWLoadData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BWLoadData_DoWork);
            this.BWLoadData.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BWLoadData_ProgressChanged);
            this.BWLoadData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BWLoadData_RunWorkerCompleted);
            // 
            // timerAd2
            // 
            this.timerAd2.Interval = 1;
            this.timerAd2.Tick += new System.EventHandler(this.timerAd2_Tick);
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
        private System.Windows.Forms.Timer timerAd;
        private Panel pnShopMain;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnProperties;
        private Guna.UI2.WinForms.Guna2ProgressIndicator pbLoadData;
        private BackgroundWorker BWLoadData;
        private Timer timerAd2;
    }
}
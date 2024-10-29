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
            this.bgwLoadData = new System.ComponentModel.BackgroundWorker();
            this.pnProperties = new System.Windows.Forms.Panel();
            this.pnShopMain = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
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
            this.pnProperties.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnProperties.Location = new System.Drawing.Point(1237, 823);
            this.pnProperties.Name = "pnProperties";
            this.pnProperties.Size = new System.Drawing.Size(10, 815);
            this.pnProperties.TabIndex = 5;
            // 
            // pnShopMain
            // 
            this.pnShopMain.Controls.Add(this.flowLayoutPanel1);
            this.pnShopMain.Location = new System.Drawing.Point(1, 9);
            this.pnShopMain.Name = "pnShopMain";
            this.pnShopMain.Size = new System.Drawing.Size(1259, 829);
            this.pnShopMain.TabIndex = 3;
            this.pnShopMain.Click += new System.EventHandler(this.pnShopMain_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1259, 353);
            this.flowLayoutPanel1.TabIndex = 0;
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
        private BackgroundWorker bgwLoadData;
        private Panel pnShopMain;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnProperties;
    }
}
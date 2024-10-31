using App_Library.Views.ToolerForm;
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
            this.pnProperties = new App_Library.Views.ToolerForm.MyPanel();
            this.BWLoadData = new System.ComponentModel.BackgroundWorker();
            this.timerAd2 = new System.Windows.Forms.Timer(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbLoadData = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.pnShopMain = new System.Windows.Forms.Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnContainHotDeal = new Guna.UI2.WinForms.Guna2Panel();
            this.pnHotDeal = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.LPHotDeal = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnShopMain.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.pnContainHotDeal.SuspendLayout();
            this.pnHotDeal.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.LPHotDeal.SuspendLayout();
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
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 80;
            this.guna2Elipse1.TargetControl = this.flowLayoutPanel1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(128, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(940, 294);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Visible = false;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // pbLoadData
            // 
            this.pbLoadData.Location = new System.Drawing.Point(3, 3);
            this.pbLoadData.Name = "pbLoadData";
            this.pbLoadData.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pbLoadData.Size = new System.Drawing.Size(90, 90);
            this.pbLoadData.TabIndex = 2;
            // 
            // pnShopMain
            // 
            this.pnShopMain.BackColor = System.Drawing.Color.White;
            this.pnShopMain.BackgroundImage = global::App_Library.Properties.Resources.gradient__2_;
            this.pnShopMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnShopMain.Controls.Add(this.guna2Panel2);
            this.pnShopMain.Controls.Add(this.guna2Panel1);
            this.pnShopMain.Location = new System.Drawing.Point(1, 9);
            this.pnShopMain.Name = "pnShopMain";
            this.pnShopMain.Size = new System.Drawing.Size(1246, 905);
            this.pnShopMain.TabIndex = 3;
            this.pnShopMain.Click += new System.EventHandler(this.pnShopMain_Click);
            this.pnShopMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnShopMain_Paint);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.pnContainHotDeal);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 335);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1246, 570);
            this.guna2Panel2.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.flowLayoutPanel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1246, 335);
            this.guna2Panel1.TabIndex = 1;
            // 
            // pnContainHotDeal
            // 
            this.pnContainHotDeal.Controls.Add(this.pnHotDeal);
            this.pnContainHotDeal.Location = new System.Drawing.Point(3, 6);
            this.pnContainHotDeal.Name = "pnContainHotDeal";
            this.pnContainHotDeal.Size = new System.Drawing.Size(1218, 486);
            this.pnContainHotDeal.TabIndex = 0;
            // 
            // pnHotDeal
            // 
            this.pnHotDeal.Controls.Add(this.guna2Panel3);
            this.pnHotDeal.Controls.Add(this.panel1);
            this.pnHotDeal.Controls.Add(this.label1);
            this.pnHotDeal.Location = new System.Drawing.Point(8, 8);
            this.pnHotDeal.Name = "pnHotDeal";
            this.pnHotDeal.Size = new System.Drawing.Size(1224, 478);
            this.pnHotDeal.TabIndex = 4;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Panel3.BorderRadius = 20;
            this.guna2Panel3.BorderThickness = 2;
            this.guna2Panel3.Controls.Add(this.LPHotDeal);
            this.guna2Panel3.Location = new System.Drawing.Point(-18, 50);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1271, 361);
            this.guna2Panel3.TabIndex = 3;
            // 
            // LPHotDeal
            // 
            this.LPHotDeal.Controls.Add(this.pbLoadData);
            this.LPHotDeal.Location = new System.Drawing.Point(21, 3);
            this.LPHotDeal.Name = "LPHotDeal";
            this.LPHotDeal.Size = new System.Drawing.Size(1237, 355);
            this.LPHotDeal.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(211, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 44);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOT DEAL !!!";
            // 
            // ShopForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1259, 884);
            this.Controls.Add(this.pnProperties);
            this.Controls.Add(this.pnShopMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShopForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.pnShopMain.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.pnContainHotDeal.ResumeLayout(false);
            this.pnHotDeal.ResumeLayout(false);
            this.pnHotDeal.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.LPHotDeal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        BackgroundWorker bgwLoadDB = new BackgroundWorker();
        private System.Windows.Forms.Timer timerAd;
        private MyPanel pnProperties;
        private BackgroundWorker BWLoadData;
        private Timer timerAd2;
        private Panel pnShopMain;
        private FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ProgressIndicator pbLoadData;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel pnContainHotDeal;
        private Guna.UI2.WinForms.Guna2Panel pnHotDeal;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private FlowLayoutPanel LPHotDeal;
        private Panel panel1;
        private Label label1;
    }
}
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbLoadDB = new System.Windows.Forms.ProgressBar();
            this.bgwLoadData = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1183, 456);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseDown);
            this.flowLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseMove);
            this.flowLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbLoadDB
            // 
            this.pbLoadDB.Location = new System.Drawing.Point(263, 465);
            this.pbLoadDB.Maximum = 4;
            this.pbLoadDB.Name = "pbLoadDB";
            this.pbLoadDB.Size = new System.Drawing.Size(533, 40);
            this.pbLoadDB.TabIndex = 1;
            // 
            // bgwLoadData
            // 
            this.bgwLoadData.WorkerReportsProgress = true;
            this.bgwLoadData.WorkerSupportsCancellation = true;
            this.bgwLoadData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwLoadDB_DoWorkAsync);
            this.bgwLoadData.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwLoadDB_ProgressChanged);
            this.bgwLoadData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwLoadDB_RunWorkerCompleted);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 763);
            this.Controls.Add(this.pbLoadDB);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShopForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        BackgroundWorker bgwLoadDB = new BackgroundWorker();
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar pbLoadDB;
        private BackgroundWorker bgwLoadData;
    }
}
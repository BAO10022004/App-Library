namespace App_Library.Views
{
    partial class StockForm
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMain = new System.Windows.Forms.Label();
            this.pnMain = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.lbMain);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1089, 119);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(0, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1089, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "___________";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbMain
            // 
            this.lbMain.BackColor = System.Drawing.Color.White;
            this.lbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMain.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMain.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbMain.Location = new System.Drawing.Point(0, 0);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(1089, 119);
            this.lbMain.TabIndex = 0;
            this.lbMain.Text = "MY STOCK";
            this.lbMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.White;
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 119);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1089, 561);
            this.pnMain.TabIndex = 1;
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1089, 680);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.guna2Panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StockForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lbMain;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel pnMain;
    }
}
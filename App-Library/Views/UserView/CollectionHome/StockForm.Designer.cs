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
            this.pnContent = new Guna.UI2.WinForms.Guna2Panel();
            this.pnMain = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnNextShop = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.pnContent.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
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
            // pnContent
            // 
            this.pnContent.BackColor = System.Drawing.Color.White;
            this.pnContent.Controls.Add(this.pnMain);
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(0, 119);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(1089, 561);
            this.pnContent.TabIndex = 1;
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.label2);
            this.pnMain.Controls.Add(this.guna2Panel2);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1089, 561);
            this.pnMain.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1089, 131);
            this.label2.TabIndex = 2;
            this.label2.Text = "YOUR STOCK IS EMPTY !!! ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btnNextShop);
            this.guna2Panel2.Location = new System.Drawing.Point(3, 134);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1086, 100);
            this.guna2Panel2.TabIndex = 4;
            // 
            // btnNextShop
            // 
            this.btnNextShop.Animated = true;
            this.btnNextShop.AnimatedGIF = true;
            this.btnNextShop.BorderColor = System.Drawing.Color.White;
            this.btnNextShop.BorderRadius = 20;
            this.btnNextShop.BorderThickness = 4;
            this.btnNextShop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNextShop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNextShop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNextShop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNextShop.FillColor = System.Drawing.Color.White;
            this.btnNextShop.Font = new System.Drawing.Font("Cooper Black", 14.25F);
            this.btnNextShop.ForeColor = System.Drawing.Color.Blue;
            this.btnNextShop.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnNextShop.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnNextShop.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnNextShop.HoverState.Image = global::App_Library.Properties.Resources.nextAnimation__2_2;
            this.btnNextShop.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNextShop.ImageSize = new System.Drawing.Size(50, 50);
            this.btnNextShop.Location = new System.Drawing.Point(390, 12);
            this.btnNextShop.Name = "btnNextShop";
            this.btnNextShop.Size = new System.Drawing.Size(311, 85);
            this.btnNextShop.TabIndex = 3;
            this.btnNextShop.Text = "GO TO THE STORE";
            this.btnNextShop.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNextShop.Click += new System.EventHandler(this.btnNextShop_Click);
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1089, 680);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.guna2Panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StockForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.pnContent.ResumeLayout(false);
            this.pnMain.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lbMain;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel pnContent;
        internal System.Windows.Forms.FlowLayoutPanel pnMain;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnNextShop;
    }
}
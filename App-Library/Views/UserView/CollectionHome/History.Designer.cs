namespace App_Library.Views.UserView.CollectionHome
{
    partial class History
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
            this.pnMain = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMain = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNextShop = new Guna.UI2.WinForms.Guna2Button();
            this.pnMain.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.Transparent;
            this.pnMain.BorderColor = System.Drawing.Color.LightCoral;
            this.pnMain.Controls.Add(this.btnNextShop);
            this.pnMain.Controls.Add(this.label2);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 119);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1089, 561);
            this.pnMain.TabIndex = 3;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.lbMain);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1089, 119);
            this.guna2Panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
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
            this.lbMain.BackColor = System.Drawing.Color.Transparent;
            this.lbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMain.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMain.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbMain.Location = new System.Drawing.Point(0, 0);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(1089, 119);
            this.lbMain.TabIndex = 0;
            this.lbMain.Text = "HISTORY";
            this.lbMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1089, 131);
            this.label2.TabIndex = 0;
            this.label2.Text = "YOUR HISTORY IS EMPTY !!! ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnNextShop
            // 
            this.btnNextShop.Animated = true;
            this.btnNextShop.AnimatedGIF = true;
            this.btnNextShop.BorderColor = System.Drawing.Color.MistyRose;
            this.btnNextShop.BorderRadius = 20;
            this.btnNextShop.BorderThickness = 4;
            this.btnNextShop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNextShop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNextShop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNextShop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNextShop.FillColor = System.Drawing.Color.MistyRose;
            this.btnNextShop.Font = new System.Drawing.Font("Cooper Black", 14.25F);
            this.btnNextShop.ForeColor = System.Drawing.Color.Salmon;
            this.btnNextShop.HoverState.BorderColor = System.Drawing.Color.Salmon;
            this.btnNextShop.HoverState.Image = global::App_Library.Properties.Resources.nextAnimation__2_2;
            this.btnNextShop.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNextShop.ImageSize = new System.Drawing.Size(50, 50);
            this.btnNextShop.Location = new System.Drawing.Point(415, 169);
            this.btnNextShop.Name = "btnNextShop";
            this.btnNextShop.Size = new System.Drawing.Size(311, 85);
            this.btnNextShop.TabIndex = 1;
            this.btnNextShop.Text = "GO TO THE STORE";
            this.btnNextShop.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNextShop.Click += new System.EventHandler(this.btnNextShop_Click);
            this.btnNextShop.MouseLeave += new System.EventHandler(this.btnNextShop_MouseLeave);
            this.btnNextShop.MouseHover += new System.EventHandler(this.btnNextShop_MouseHover);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1089, 680);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "History";
            this.Text = "SettingForm";
            this.Load += new System.EventHandler(this.History_Load);
            this.pnMain.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnMain;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMain;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnNextShop;
    }
}
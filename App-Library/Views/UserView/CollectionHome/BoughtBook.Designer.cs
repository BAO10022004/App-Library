namespace App_Library.Views.UserView.CollectionHome
{
    partial class BoughtBook
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
            this.btnGrid = new Guna.UI2.WinForms.Guna2Button();
            this.btnList = new Guna.UI2.WinForms.Guna2Button();
            this.pnContent = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnGrid);
            this.guna2Panel1.Controls.Add(this.btnList);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1089, 64);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnGrid
            // 
            this.btnGrid.Animated = true;
            this.btnGrid.BorderRadius = 10;
            this.btnGrid.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGrid.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGrid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGrid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGrid.FillColor = System.Drawing.Color.Orange;
            this.btnGrid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGrid.ForeColor = System.Drawing.Color.White;
            this.btnGrid.HoverState.FillColor = System.Drawing.Color.DarkOrange;
            this.btnGrid.Image = global::App_Library.Properties.Resources.grid;
            this.btnGrid.ImageSize = new System.Drawing.Size(30, 30);
            this.btnGrid.Location = new System.Drawing.Point(12, 12);
            this.btnGrid.Name = "btnGrid";
            this.btnGrid.Size = new System.Drawing.Size(61, 46);
            this.btnGrid.TabIndex = 1;
            this.btnGrid.Click += new System.EventHandler(this.btnGrid_Click);
            // 
            // btnList
            // 
            this.btnList.Animated = true;
            this.btnList.BorderRadius = 10;
            this.btnList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnList.FillColor = System.Drawing.Color.Orange;
            this.btnList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.HoverState.FillColor = System.Drawing.Color.DarkOrange;
            this.btnList.Image = global::App_Library.Properties.Resources.list;
            this.btnList.ImageSize = new System.Drawing.Size(30, 30);
            this.btnList.Location = new System.Drawing.Point(93, 12);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(61, 46);
            this.btnList.TabIndex = 0;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // pnContent
            // 
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(0, 64);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(1089, 497);
            this.pnContent.TabIndex = 1;
            // 
            // BoughtBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1089, 561);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BoughtBook";
            this.Text = "BoughtBook";
            this.Load += new System.EventHandler(this.BoughtBook_Load);
            this.Resize += new System.EventHandler(this.BoughtBook_Resize);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnList;
        private Guna.UI2.WinForms.Guna2Button btnGrid;
        internal System.Windows.Forms.FlowLayoutPanel pnContent;
    }
}
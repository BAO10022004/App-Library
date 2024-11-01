namespace App_Library.Views.Main.CollectionShop
{
    partial class AdForm
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
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.fpAdBook = new System.Windows.Forms.FlowLayoutPanel();
            this.timerAd = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel3.BorderRadius = 25;
            this.guna2Panel3.BorderThickness = 5;
            this.guna2Panel3.Controls.Add(this.fpAdBook);
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(127, 12);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1008, 321);
            this.guna2Panel3.TabIndex = 1;
            // 
            // fpAdBook
            // 
            this.fpAdBook.BackColor = System.Drawing.Color.White;
            this.fpAdBook.Location = new System.Drawing.Point(26, 13);
            this.fpAdBook.Name = "fpAdBook";
            this.fpAdBook.Size = new System.Drawing.Size(962, 298);
            this.fpAdBook.TabIndex = 0;
            // 
            // timerAd
            // 
            this.timerAd.Interval = 1;
            // 
            // AdForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1212, 335);
            this.Controls.Add(this.guna2Panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdForm";
            this.Text = "AdForm";
            this.Load += new System.EventHandler(this.AdForm_Load);
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.FlowLayoutPanel fpAdBook;
        private System.Windows.Forms.Timer timerAd;
    }
}
namespace App_Library.Views.Main.CollectionShop
{
    partial class Form1
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.gnpButtonAll = new Guna.UI2.WinForms.Guna2Panel();
            this.gnpGroupBookForCategory = new Guna.UI2.WinForms.Guna2Panel();
            this.gnpGroupButtonCategory = new Guna.UI2.WinForms.Guna2Panel();
            this.gnpContainCaterogyBook = new Guna.UI2.WinForms.Guna2Panel();
            this.LPHotDeal = new System.Windows.Forms.FlowLayoutPanel();
            this.pnContainHotDeal = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gnpContainFpHotDeal = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnHotDeal = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnShopMain = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timerAd2 = new System.Windows.Forms.Timer(this.components);
            this.BWLoadData = new System.ComponentModel.BackgroundWorker();
            this.pnProperties = new App_Library.Views.ToolerForm.MyPanel();
            this.timerAd = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1.SuspendLayout();
            this.gnpButtonAll.SuspendLayout();
            this.gnpGroupButtonCategory.SuspendLayout();
            this.gnpContainCaterogyBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.gnpContainFpHotDeal.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.pnHotDeal.SuspendLayout();
            this.pnShopMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.flowLayoutPanel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1247, 335);
            this.guna2Panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(148, 21);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(940, 294);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(27, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ALL";
            // 
            // gnpButtonAll
            // 
            this.gnpButtonAll.BorderColor = System.Drawing.Color.Black;
            this.gnpButtonAll.BorderRadius = 10;
            this.gnpButtonAll.BorderThickness = 3;
            this.gnpButtonAll.Controls.Add(this.label2);
            this.gnpButtonAll.FillColor = System.Drawing.Color.Transparent;
            this.gnpButtonAll.Location = new System.Drawing.Point(39, 16);
            this.gnpButtonAll.Name = "gnpButtonAll";
            this.gnpButtonAll.Size = new System.Drawing.Size(102, 47);
            this.gnpButtonAll.TabIndex = 0;
            // 
            // gnpGroupBookForCategory
            // 
            this.gnpGroupBookForCategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.gnpGroupBookForCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gnpGroupBookForCategory.Location = new System.Drawing.Point(0, 76);
            this.gnpGroupBookForCategory.Name = "gnpGroupBookForCategory";
            this.gnpGroupBookForCategory.Size = new System.Drawing.Size(1069, 774);
            this.gnpGroupBookForCategory.TabIndex = 1;
            // 
            // gnpGroupButtonCategory
            // 
            this.gnpGroupButtonCategory.BackColor = System.Drawing.Color.Transparent;
            this.gnpGroupButtonCategory.Controls.Add(this.gnpButtonAll);
            this.gnpGroupButtonCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.gnpGroupButtonCategory.Location = new System.Drawing.Point(0, 0);
            this.gnpGroupButtonCategory.Name = "gnpGroupButtonCategory";
            this.gnpGroupButtonCategory.Size = new System.Drawing.Size(1069, 76);
            this.gnpGroupButtonCategory.TabIndex = 0;
            // 
            // gnpContainCaterogyBook
            // 
            this.gnpContainCaterogyBook.BackColor = System.Drawing.Color.Transparent;
            this.gnpContainCaterogyBook.Controls.Add(this.gnpGroupBookForCategory);
            this.gnpContainCaterogyBook.Controls.Add(this.gnpGroupButtonCategory);
            this.gnpContainCaterogyBook.Location = new System.Drawing.Point(48, 524);
            this.gnpContainCaterogyBook.Name = "gnpContainCaterogyBook";
            this.gnpContainCaterogyBook.Size = new System.Drawing.Size(1069, 850);
            this.gnpContainCaterogyBook.TabIndex = 4;
            // 
            // LPHotDeal
            // 
            this.LPHotDeal.AutoScroll = true;
            this.LPHotDeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LPHotDeal.Location = new System.Drawing.Point(21, 3);
            this.LPHotDeal.Name = "LPHotDeal";
            this.LPHotDeal.Size = new System.Drawing.Size(1135, 380);
            this.LPHotDeal.TabIndex = 3;
            // 
            // pnContainHotDeal
            // 
            this.pnContainHotDeal.Location = new System.Drawing.Point(6, 3);
            this.pnContainHotDeal.Name = "pnContainHotDeal";
            this.pnContainHotDeal.Size = new System.Drawing.Size(1220, 486);
            this.pnContainHotDeal.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 10;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::App_Library.Properties.Resources.deal;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(10, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(49, 44);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            // 
            // gnpContainFpHotDeal
            // 
            this.gnpContainFpHotDeal.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gnpContainFpHotDeal.BorderRadius = 12;
            this.gnpContainFpHotDeal.BorderThickness = 2;
            this.gnpContainFpHotDeal.Controls.Add(this.LPHotDeal);
            this.gnpContainFpHotDeal.Location = new System.Drawing.Point(4, 53);
            this.gnpContainFpHotDeal.Name = "gnpContainFpHotDeal";
            this.gnpContainFpHotDeal.Size = new System.Drawing.Size(1181, 396);
            this.gnpContainFpHotDeal.TabIndex = 3;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.AutoScroll = true;
            this.guna2Panel2.Controls.Add(this.pnHotDeal);
            this.guna2Panel2.Controls.Add(this.gnpContainCaterogyBook);
            this.guna2Panel2.Controls.Add(this.pnContainHotDeal);
            this.guna2Panel2.Location = new System.Drawing.Point(3, 335);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1244, 1407);
            this.guna2Panel2.TabIndex = 2;
            // 
            // pnHotDeal
            // 
            this.pnHotDeal.Controls.Add(this.guna2PictureBox1);
            this.pnHotDeal.Controls.Add(this.gnpContainFpHotDeal);
            this.pnHotDeal.Controls.Add(this.panel1);
            this.pnHotDeal.Controls.Add(this.label1);
            this.pnHotDeal.Location = new System.Drawing.Point(6, 40);
            this.pnHotDeal.Name = "pnHotDeal";
            this.pnHotDeal.Size = new System.Drawing.Size(1188, 478);
            this.pnHotDeal.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(268, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 44);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(65, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOT DEAL !!!";
            // 
            // pnShopMain
            // 
            this.pnShopMain.BackColor = System.Drawing.Color.White;
            this.pnShopMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnShopMain.Controls.Add(this.guna2Panel2);
            this.pnShopMain.Controls.Add(this.guna2Panel1);
            this.pnShopMain.Location = new System.Drawing.Point(-223, -756);
            this.pnShopMain.Name = "pnShopMain";
            this.pnShopMain.Size = new System.Drawing.Size(1247, 1743);
            this.pnShopMain.TabIndex = 6;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.flowLayoutPanel1;
            // 
            // timerAd2
            // 
            this.timerAd2.Interval = 1;
            // 
            // BWLoadData
            // 
            this.BWLoadData.WorkerReportsProgress = true;
            this.BWLoadData.WorkerSupportsCancellation = true;
            // 
            // pnProperties
            // 
            this.pnProperties.BackColor = System.Drawing.SystemColors.Control;
            this.pnProperties.Location = new System.Drawing.Point(1014, 391);
            this.pnProperties.Name = "pnProperties";
            this.pnProperties.Size = new System.Drawing.Size(10, 815);
            this.pnProperties.TabIndex = 7;
            // 
            // timerAd
            // 
            this.timerAd.Interval = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnShopMain);
            this.Controls.Add(this.pnProperties);
            this.Name = "Form1";
            this.Text = "Form1";
            this.guna2Panel1.ResumeLayout(false);
            this.gnpButtonAll.ResumeLayout(false);
            this.gnpButtonAll.PerformLayout();
            this.gnpGroupButtonCategory.ResumeLayout(false);
            this.gnpContainCaterogyBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.gnpContainFpHotDeal.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.pnHotDeal.ResumeLayout(false);
            this.pnHotDeal.PerformLayout();
            this.pnShopMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel gnpButtonAll;
        private Guna.UI2.WinForms.Guna2Panel gnpGroupBookForCategory;
        private Guna.UI2.WinForms.Guna2Panel gnpGroupButtonCategory;
        private Guna.UI2.WinForms.Guna2Panel gnpContainCaterogyBook;
        private System.Windows.Forms.FlowLayoutPanel LPHotDeal;
        private Guna.UI2.WinForms.Guna2Panel pnContainHotDeal;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel gnpContainFpHotDeal;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel pnHotDeal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnShopMain;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Timer timerAd2;
        private System.ComponentModel.BackgroundWorker BWLoadData;
        private ToolerForm.MyPanel pnProperties;
        private System.Windows.Forms.Timer timerAd;
    }
}
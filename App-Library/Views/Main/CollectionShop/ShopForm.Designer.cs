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
            this.pnShopMain = new System.Windows.Forms.Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnHotDeal = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gnpContainFpHotDeal = new Guna.UI2.WinForms.Guna2Panel();
            this.LPHotDeal = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gnpContainCaterogyBook = new Guna.UI2.WinForms.Guna2Panel();
            this.gnpGroupBookForCategory = new Guna.UI2.WinForms.Guna2Panel();
            this.gnpGroupButtonCategory = new Guna.UI2.WinForms.Guna2Panel();
            this.gnpButtonAll = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnContainHotDeal = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnShopMain.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.pnHotDeal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.gnpContainFpHotDeal.SuspendLayout();
            this.gnpContainCaterogyBook.SuspendLayout();
            this.gnpGroupButtonCategory.SuspendLayout();
            this.gnpButtonAll.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
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
            this.pnProperties.Location = new System.Drawing.Point(1237, 1149);
            this.pnProperties.Name = "pnProperties";
            this.pnProperties.Size = new System.Drawing.Size(10, 815);
            this.pnProperties.TabIndex = 5;
            this.pnProperties.Paint += new System.Windows.Forms.PaintEventHandler(this.pnProperties_Paint);
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
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.flowLayoutPanel1;
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
            this.flowLayoutPanel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.flowLayoutPanel1_Scroll);
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // pnShopMain
            // 
            this.pnShopMain.BackColor = System.Drawing.Color.White;
            this.pnShopMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnShopMain.Controls.Add(this.guna2Panel2);
            this.pnShopMain.Controls.Add(this.guna2Panel1);
            this.pnShopMain.Location = new System.Drawing.Point(0, 2);
            this.pnShopMain.Name = "pnShopMain";
            this.pnShopMain.Size = new System.Drawing.Size(1247, 1743);
            this.pnShopMain.TabIndex = 3;
            this.pnShopMain.Click += new System.EventHandler(this.pnShopMain_Click);
            this.pnShopMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnShopMain_Paint);
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
            this.guna2Panel2.Click += new System.EventHandler(this.pnShopMain_Click);
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
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
            this.pnHotDeal.Click += new System.EventHandler(this.pnShopMain_Click);
            this.pnHotDeal.Paint += new System.Windows.Forms.PaintEventHandler(this.pnHotDeal_Paint);
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
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
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
            this.gnpContainFpHotDeal.Paint += new System.Windows.Forms.PaintEventHandler(this.gnpContainFpHotDeal_Paint);
            // 
            // LPHotDeal
            // 
            this.LPHotDeal.AutoScroll = true;
            this.LPHotDeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LPHotDeal.Location = new System.Drawing.Point(21, 3);
            this.LPHotDeal.Name = "LPHotDeal";
            this.LPHotDeal.Size = new System.Drawing.Size(1135, 380);
            this.LPHotDeal.TabIndex = 3;
            this.LPHotDeal.Paint += new System.Windows.Forms.PaintEventHandler(this.LPHotDeal_Paint);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(268, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 44);
            this.panel1.TabIndex = 2;
            this.panel1.Click += new System.EventHandler(this.pnShopMain_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
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
            this.label1.Click += new System.EventHandler(this.pnShopMain_Click);
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
            this.gnpContainCaterogyBook.Paint += new System.Windows.Forms.PaintEventHandler(this.gnpContainCaterogyBook_Paint);
            this.gnpContainCaterogyBook.MouseHover += new System.EventHandler(this.gnpContainCaterogyBook_MouseHover);
            // 
            // gnpGroupBookForCategory
            // 
            this.gnpGroupBookForCategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.gnpGroupBookForCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gnpGroupBookForCategory.Location = new System.Drawing.Point(0, 76);
            this.gnpGroupBookForCategory.Name = "gnpGroupBookForCategory";
            this.gnpGroupBookForCategory.Size = new System.Drawing.Size(1069, 774);
            this.gnpGroupBookForCategory.TabIndex = 1;
            this.gnpGroupBookForCategory.Paint += new System.Windows.Forms.PaintEventHandler(this.gnpGroupBookForCategory_Paint);
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
            this.gnpGroupButtonCategory.Paint += new System.Windows.Forms.PaintEventHandler(this.gnpGroupButtonCategory_Paint);
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
            this.gnpButtonAll.Click += new System.EventHandler(this.gnpButtonAll_Click);
            this.gnpButtonAll.Paint += new System.Windows.Forms.PaintEventHandler(this.gnpButtonAll_Paint);
            this.gnpButtonAll.MouseLeave += new System.EventHandler(this.gnpButtonAll_MouseLeave);
            this.gnpButtonAll.MouseHover += new System.EventHandler(this.gnpButtonAll_MouseHover);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pnContainHotDeal
            // 
            this.pnContainHotDeal.Location = new System.Drawing.Point(6, 3);
            this.pnContainHotDeal.Name = "pnContainHotDeal";
            this.pnContainHotDeal.Size = new System.Drawing.Size(1220, 486);
            this.pnContainHotDeal.TabIndex = 0;
            this.pnContainHotDeal.Click += new System.EventHandler(this.pnShopMain_Click);
            this.pnContainHotDeal.Paint += new System.Windows.Forms.PaintEventHandler(this.pnContainHotDeal_Paint);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.flowLayoutPanel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1247, 335);
            this.guna2Panel1.TabIndex = 1;
            this.guna2Panel1.Click += new System.EventHandler(this.pnShopMain_Click);
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // ShopForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 1900);
            this.ClientSize = new System.Drawing.Size(1260, 829);
            this.Controls.Add(this.pnProperties);
            this.Controls.Add(this.pnShopMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShopForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.pnShopMain.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.pnHotDeal.ResumeLayout(false);
            this.pnHotDeal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.gnpContainFpHotDeal.ResumeLayout(false);
            this.gnpContainCaterogyBook.ResumeLayout(false);
            this.gnpGroupButtonCategory.ResumeLayout(false);
            this.gnpButtonAll.ResumeLayout(false);
            this.gnpButtonAll.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        BackgroundWorker bgwLoadDB = new BackgroundWorker();
        private Timer timerAd;
        private MyPanel pnProperties;
        private BackgroundWorker BWLoadData;
        private Timer timerAd2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnShopMain;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel pnHotDeal;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel gnpContainFpHotDeal;
        private FlowLayoutPanel LPHotDeal;
        private Panel panel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Panel gnpContainCaterogyBook;
        private Guna.UI2.WinForms.Guna2Panel gnpGroupBookForCategory;
        private Guna.UI2.WinForms.Guna2Panel gnpGroupButtonCategory;
        private Guna.UI2.WinForms.Guna2Panel gnpButtonAll;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Panel pnContainHotDeal;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
namespace App_Library.Views.Orthers.CollectionProfile
{
    partial class ProfileForm
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
            this.pnBackground = new System.Windows.Forms.Panel();
            this.picAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.gnElipseAvatar = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnMain = new Guna.UI2.WinForms.Guna2Panel();
            this.pnBookWaiting = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCountBookWaiting = new System.Windows.Forms.Label();
            this.lblWaiting = new System.Windows.Forms.Label();
            this.pnBookAlready = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCountBookAlready = new System.Windows.Forms.Label();
            this.lblStore = new System.Windows.Forms.Label();
            this.lblEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblUserName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnChangePassword = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.timerOpenEditForm = new System.Windows.Forms.Timer(this.components);
            this.timerCloseEditForm = new System.Windows.Forms.Timer(this.components);
            this.timeropenChangePassword = new System.Windows.Forms.Timer(this.components);
            this.pnBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnMain.SuspendLayout();
            this.pnBookWaiting.SuspendLayout();
            this.pnBookAlready.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBackground
            // 
            this.pnBackground.BackColor = System.Drawing.Color.White;
            this.pnBackground.Controls.Add(this.picAvatar);
            this.pnBackground.Controls.Add(this.guna2Panel2);
            this.pnBackground.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBackground.Location = new System.Drawing.Point(0, 0);
            this.pnBackground.Margin = new System.Windows.Forms.Padding(0);
            this.pnBackground.Name = "pnBackground";
            this.pnBackground.Size = new System.Drawing.Size(1030, 360);
            this.pnBackground.TabIndex = 0;
            // 
            // picAvatar
            // 
            this.picAvatar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picAvatar.BackColor = System.Drawing.Color.Transparent;
            this.picAvatar.Image = global::App_Library.Properties.Resources.account;
            this.picAvatar.ImageRotate = 0F;
            this.picAvatar.Location = new System.Drawing.Point(447, 157);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picAvatar.Size = new System.Drawing.Size(200, 200);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 2;
            this.picAvatar.TabStop = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Beige;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1030, 261);
            this.guna2Panel2.TabIndex = 0;
            // 
            // gnElipseAvatar
            // 
            this.gnElipseAvatar.BorderRadius = 200;
            this.gnElipseAvatar.TargetControl = this.picAvatar;
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.pnBookWaiting);
            this.pnMain.Controls.Add(this.pnBookAlready);
            this.pnMain.Controls.Add(this.lblEmail);
            this.pnMain.Controls.Add(this.lblUserName);
            this.pnMain.Controls.Add(this.btnChangePassword);
            this.pnMain.Controls.Add(this.btnEdit);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 360);
            this.pnMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1030, 320);
            this.pnMain.TabIndex = 1;
            // 
            // pnBookWaiting
            // 
            this.pnBookWaiting.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnBookWaiting.BackColor = System.Drawing.Color.Silver;
            this.pnBookWaiting.Controls.Add(this.lblCountBookWaiting);
            this.pnBookWaiting.Controls.Add(this.lblWaiting);
            this.pnBookWaiting.Location = new System.Drawing.Point(617, 172);
            this.pnBookWaiting.Name = "pnBookWaiting";
            this.pnBookWaiting.Size = new System.Drawing.Size(100, 50);
            this.pnBookWaiting.TabIndex = 16;
            // 
            // lblCountBookWaiting
            // 
            this.lblCountBookWaiting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCountBookWaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountBookWaiting.Location = new System.Drawing.Point(0, 25);
            this.lblCountBookWaiting.Name = "lblCountBookWaiting";
            this.lblCountBookWaiting.Size = new System.Drawing.Size(100, 25);
            this.lblCountBookWaiting.TabIndex = 9;
            this.lblCountBookWaiting.Text = "0";
            this.lblCountBookWaiting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWaiting
            // 
            this.lblWaiting.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaiting.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblWaiting.Location = new System.Drawing.Point(0, 0);
            this.lblWaiting.Name = "lblWaiting";
            this.lblWaiting.Size = new System.Drawing.Size(100, 25);
            this.lblWaiting.TabIndex = 8;
            this.lblWaiting.Text = "Waiting";
            this.lblWaiting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnBookAlready
            // 
            this.pnBookAlready.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnBookAlready.BackColor = System.Drawing.Color.Silver;
            this.pnBookAlready.Controls.Add(this.lblCountBookAlready);
            this.pnBookAlready.Controls.Add(this.lblStore);
            this.pnBookAlready.Location = new System.Drawing.Point(347, 172);
            this.pnBookAlready.Name = "pnBookAlready";
            this.pnBookAlready.Size = new System.Drawing.Size(100, 50);
            this.pnBookAlready.TabIndex = 15;
            // 
            // lblCountBookAlready
            // 
            this.lblCountBookAlready.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCountBookAlready.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountBookAlready.Location = new System.Drawing.Point(0, 25);
            this.lblCountBookAlready.Name = "lblCountBookAlready";
            this.lblCountBookAlready.Size = new System.Drawing.Size(100, 25);
            this.lblCountBookAlready.TabIndex = 9;
            this.lblCountBookAlready.Text = "0";
            this.lblCountBookAlready.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStore
            // 
            this.lblStore.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStore.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblStore.Location = new System.Drawing.Point(0, 0);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(100, 25);
            this.lblStore.TabIndex = 8;
            this.lblStore.Text = "Store";
            this.lblStore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = false;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(407, 76);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(250, 50);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUserName.AutoSize = false;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(407, 20);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(250, 50);
            this.lblUserName.TabIndex = 13;
            this.lblUserName.Text = "User Name";
            this.lblUserName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnChangePassword.BorderRadius = 20;
            this.btnChangePassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChangePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChangePassword.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(567, 252);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(200, 50);
            this.btnChangePassword.TabIndex = 12;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BorderRadius = 20;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(297, 252);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(200, 50);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // timerOpenEditForm
            // 
            this.timerOpenEditForm.Interval = 1;
            this.timerOpenEditForm.Tick += new System.EventHandler(this.timerOpenEditForm_Tick);
            // 
            // timerCloseEditForm
            // 
            this.timerCloseEditForm.Interval = 1;
            this.timerCloseEditForm.Tick += new System.EventHandler(this.timerCloseEditForm_Tick);
            // 
            // timeropenChangePassword
            // 
            this.timeropenChangePassword.Interval = 1;
            this.timeropenChangePassword.Tick += new System.EventHandler(this.timeropenChangePassword_Tick);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 680);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.pnBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.pnBookWaiting.ResumeLayout(false);
            this.pnBookAlready.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBackground;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picAvatar;
        private Guna.UI2.WinForms.Guna2Elipse gnElipseAvatar;
        private Guna.UI2.WinForms.Guna2Panel pnMain;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel pnBookWaiting;
        private System.Windows.Forms.Label lblCountBookWaiting;
        private System.Windows.Forms.Label lblWaiting;
        private Guna.UI2.WinForms.Guna2Panel pnBookAlready;
        private System.Windows.Forms.Label lblCountBookAlready;
        private System.Windows.Forms.Label lblStore;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUserName;
        private Guna.UI2.WinForms.Guna2Button btnChangePassword;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private System.Windows.Forms.Timer timerOpenEditForm;
        private System.Windows.Forms.Timer timerCloseEditForm;
        private System.Windows.Forms.Timer timeropenChangePassword;
    }
}
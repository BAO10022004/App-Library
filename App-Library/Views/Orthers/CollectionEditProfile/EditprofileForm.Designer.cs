namespace App_Library.Views.Orthers.CollectionEditProfile
{
    partial class EditprofileForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gnElipseForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lbUsername = new System.Windows.Forms.Label();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaves = new Guna.UI2.WinForms.Guna2Button();
            this.picAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.picEditImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditImage)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // gnElipseForm
            // 
            this.gnElipseForm.BorderRadius = 50;
            this.gnElipseForm.TargetControl = this;
            // 
            // lbUsername
            // 
            this.lbUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.Honeydew;
            this.lbUsername.Location = new System.Drawing.Point(9, 218);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(186, 42);
            this.lbUsername.TabIndex = 20;
            this.lbUsername.Text = "USERNAME";
            this.lbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(91, 424);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(170, 51);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaves
            // 
            this.btnSaves.Animated = true;
            this.btnSaves.BorderRadius = 10;
            this.btnSaves.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaves.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaves.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaves.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaves.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.btnSaves.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaves.ForeColor = System.Drawing.Color.White;
            this.btnSaves.Location = new System.Drawing.Point(314, 424);
            this.btnSaves.Name = "btnSaves";
            this.btnSaves.Size = new System.Drawing.Size(170, 51);
            this.btnSaves.TabIndex = 22;
            this.btnSaves.Text = "SAVES";
            this.btnSaves.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.ErrorImage = global::App_Library.Properties.Resources.account;
            this.picAvatar.Image = global::App_Library.Properties.Resources.account;
            this.picAvatar.ImageRotate = 0F;
            this.picAvatar.Location = new System.Drawing.Point(215, 26);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picAvatar.Size = new System.Drawing.Size(150, 150);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 23;
            this.picAvatar.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(9, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 42);
            this.label1.TabIndex = 24;
            this.label1.Text = "EMAIL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbUsername
            // 
            this.txbUsername.BorderRadius = 10;
            this.txbUsername.BorderThickness = 2;
            this.txbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbUsername.DefaultText = "";
            this.txbUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.txbUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbUsername.Location = new System.Drawing.Point(201, 218);
            this.txbUsername.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.PasswordChar = '\0';
            this.txbUsername.PlaceholderText = "";
            this.txbUsername.SelectedText = "";
            this.txbUsername.Size = new System.Drawing.Size(361, 42);
            this.txbUsername.TabIndex = 25;
            // 
            // txbEmail
            // 
            this.txbEmail.BorderRadius = 10;
            this.txbEmail.BorderThickness = 2;
            this.txbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbEmail.DefaultText = "";
            this.txbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.txbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbEmail.Location = new System.Drawing.Point(201, 305);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.PasswordChar = '\0';
            this.txbEmail.PlaceholderText = "";
            this.txbEmail.SelectedText = "";
            this.txbEmail.Size = new System.Drawing.Size(361, 42);
            this.txbEmail.TabIndex = 26;
            // 
            // picEditImage
            // 
            this.picEditImage.BackColor = System.Drawing.Color.Transparent;
            this.picEditImage.BorderRadius = 10;
            this.picEditImage.Image = global::App_Library.Properties.Resources.edit__1_;
            this.picEditImage.ImageRotate = 0F;
            this.picEditImage.Location = new System.Drawing.Point(303, 129);
            this.picEditImage.Name = "picEditImage";
            this.picEditImage.Size = new System.Drawing.Size(41, 37);
            this.picEditImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEditImage.TabIndex = 27;
            this.picEditImage.TabStop = false;
            this.picEditImage.Click += new System.EventHandler(this.picEdit_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.picEditImage);
            this.guna2ShadowPanel1.Controls.Add(this.txbEmail);
            this.guna2ShadowPanel1.Controls.Add(this.txbUsername);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.picAvatar);
            this.guna2ShadowPanel1.Controls.Add(this.btnSaves);
            this.guna2ShadowPanel1.Controls.Add(this.btnCancel);
            this.guna2ShadowPanel1.Controls.Add(this.lbUsername);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(257, 29);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(570, 500);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // EditprofileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = global::App_Library.Properties.Resources.pexels_baskincreativeco_17668381;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 641);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditprofileForm";
            this.Opacity = 0.8D;
            this.Text = "EditprofileForm";
            this.Load += new System.EventHandler(this.EditprofileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEditImage)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse gnElipseForm;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox picEditImage;
        private Guna.UI2.WinForms.Guna2TextBox txbEmail;
        private Guna.UI2.WinForms.Guna2TextBox txbUsername;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picAvatar;
        private Guna.UI2.WinForms.Guna2Button btnSaves;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.Label lbUsername;
    }
}
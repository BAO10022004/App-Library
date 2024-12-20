﻿namespace App_Library.Views.Orthers.CollectionEditProfile.ChangePasswordCollection
{
    partial class NewPasswordForm
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
            this.timerHHoverNext = new System.Windows.Forms.Timer(this.components);
            this.timerLeave = new System.Windows.Forms.Timer(this.components);
            this.timerOpenEyeForConfirm = new System.Windows.Forms.Timer(this.components);
            this.timerOpenEyeForPassWord = new System.Windows.Forms.Timer(this.components);
            this.picEyeConfirm = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picEyePassword = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbMessegeErrorConfirm = new System.Windows.Forms.Label();
            this.lbMessegeErrorPassword = new System.Windows.Forms.Label();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyePassword)).BeginInit();
            this.SuspendLayout();
            // 
            // timerHHoverNext
            // 
            this.timerHHoverNext.Interval = 1;
            this.timerHHoverNext.Tick += new System.EventHandler(this.timerHHoverNext_Tick);
            // 
            // timerLeave
            // 
            this.timerLeave.Interval = 1;
            this.timerLeave.Tick += new System.EventHandler(this.timerLeave_Tick);
            // 
            // timerOpenEyeForConfirm
            // 
            this.timerOpenEyeForConfirm.Interval = 1000;
            this.timerOpenEyeForConfirm.Tick += new System.EventHandler(this.timerOpenEyeForConfirm_Tick);
            // 
            // timerOpenEyeForPassWord
            // 
            this.timerOpenEyeForPassWord.Interval = 1000;
            this.timerOpenEyeForPassWord.Tick += new System.EventHandler(this.timerOpenEyeForPassWord_Tick);
            // 
            // picEyeConfirm
            // 
            this.picEyeConfirm.BackColor = System.Drawing.Color.White;
            this.picEyeConfirm.Image = global::App_Library.Properties.Resources.eye;
            this.picEyeConfirm.ImageRotate = 0F;
            this.picEyeConfirm.Location = new System.Drawing.Point(547, 358);
            this.picEyeConfirm.Name = "picEyeConfirm";
            this.picEyeConfirm.Size = new System.Drawing.Size(47, 37);
            this.picEyeConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEyeConfirm.TabIndex = 20;
            this.picEyeConfirm.TabStop = false;
            this.picEyeConfirm.Click += new System.EventHandler(this.picEyeConfirm_Click);
            // 
            // picEyePassword
            // 
            this.picEyePassword.BackColor = System.Drawing.Color.White;
            this.picEyePassword.Image = global::App_Library.Properties.Resources.eye;
            this.picEyePassword.ImageRotate = 0F;
            this.picEyePassword.Location = new System.Drawing.Point(547, 265);
            this.picEyePassword.Name = "picEyePassword";
            this.picEyePassword.Size = new System.Drawing.Size(47, 37);
            this.picEyePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEyePassword.TabIndex = 19;
            this.picEyePassword.TabStop = false;
            this.picEyePassword.Click += new System.EventHandler(this.picEyePassword_Click);
            // 
            // lbMessegeErrorConfirm
            // 
            this.lbMessegeErrorConfirm.AutoSize = true;
            this.lbMessegeErrorConfirm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessegeErrorConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbMessegeErrorConfirm.Location = new System.Drawing.Point(204, 421);
            this.lbMessegeErrorConfirm.Name = "lbMessegeErrorConfirm";
            this.lbMessegeErrorConfirm.Size = new System.Drawing.Size(0, 17);
            this.lbMessegeErrorConfirm.TabIndex = 18;
            // 
            // lbMessegeErrorPassword
            // 
            this.lbMessegeErrorPassword.AutoSize = true;
            this.lbMessegeErrorPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessegeErrorPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbMessegeErrorPassword.Location = new System.Drawing.Point(204, 326);
            this.lbMessegeErrorPassword.Name = "lbMessegeErrorPassword";
            this.lbMessegeErrorPassword.Size = new System.Drawing.Size(0, 17);
            this.lbMessegeErrorPassword.TabIndex = 17;
            // 
            // btnNext
            // 
            this.btnNext.BorderRadius = 30;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = global::App_Library.Properties.Resources.ArrowTittle;
            this.btnNext.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNext.ImageSize = new System.Drawing.Size(40, 40);
            this.btnNext.Location = new System.Drawing.Point(523, 469);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(80, 58);
            this.btnNext.TabIndex = 16;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseLeave += new System.EventHandler(this.btnNext_MouseLeave);
            this.btnNext.MouseHover += new System.EventHandler(this.btnNext_MouseHover);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderRadius = 15;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.DefaultText = "";
            this.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(207, 356);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '\0';
            this.txtConfirmPassword.PlaceholderText = "";
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(396, 48);
            this.txtConfirmPassword.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(101, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "CONFIRM";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 15;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(207, 261);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(396, 48);
            this.txtPassword.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(77, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "PASSWORD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 55);
            this.label1.TabIndex = 11;
            this.label1.Text = "NEW PASSWORD";
            // 
            // NewPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(632, 602);
            this.Controls.Add(this.picEyeConfirm);
            this.Controls.Add(this.picEyePassword);
            this.Controls.Add(this.lbMessegeErrorConfirm);
            this.Controls.Add(this.lbMessegeErrorPassword);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewPasswordForm";
            this.Text = "NewPasswordForm";
            ((System.ComponentModel.ISupportInitialize)(this.picEyeConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyePassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMessegeErrorConfirm;
        private System.Windows.Forms.Label lbMessegeErrorPassword;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerHHoverNext;
        private System.Windows.Forms.Timer timerLeave;
        private Guna.UI2.WinForms.Guna2PictureBox picEyePassword;
        private Guna.UI2.WinForms.Guna2PictureBox picEyeConfirm;
        private System.Windows.Forms.Timer timerOpenEyeForConfirm;
        private System.Windows.Forms.Timer timerOpenEyeForPassWord;
    }
}
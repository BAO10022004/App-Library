﻿using App_Library.Models;
using App_Library.Services;
using App_Library.Services.Interfaces;
using DnsClient.Protocol;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
// $2a$10$eITLrNBDrQ5zvpaAToD2GO20B5hYEzKY2gtvvpirHIeJiXUECnAf2
namespace App_Library.Views
{
    public partial class LoginForm : Form
    {
        private readonly MongoDbContext _context;
        private readonly IAuthService _authService;
        public LoginForm(MongoDbContext context)
        {
            _context = context;
            _authService = new AuthService(_context);
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void timerClickButonLogin_Tick(object sender, EventArgs e)
        {

        }
        private async void btnLogin_Click_1(object sender, EventArgs e)
        {
            bool checkLoginSuccess = (await _authService.LoginAsync(txbEmail.Text, txbPassword.Text));
            if(checkLoginSuccess)
            {
                SessionManager.CurrentUsername = txbEmail.Text;
                var list = await _context.Users.Find(u => u.PasswordHash == txbPassword.Text).ToListAsync();
                foreach(var item in list )
                {
                    SessionManager.CurrentUserId = item.Id;
                    break;
                }
                timerOpenMainForm.Tick += new System.EventHandler(this.timerOpenMainForm_Tick);
                timerOpenMainForm.Start();
            }
        }
        Form ActForm;
        public void activeFormChild(Form form, object obj)
        {
            if (ActForm != null)
            {
                ActForm.Close();
            }
            ActForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            Program.sp.PnSubLogin.Controls.Add(form);
            Program.sp.PnSubLogin.Tag = form;
            Program.sp.Location = new Point(0, 0);
            Program.sp.BtnExit.Location = new Point(1540 - 35, 1);
            form.Show();
        }
        private void timerOpenMainForm_Tick(object sender, EventArgs e)
        {
        
            Size newSize = (new Size(1536, 864));
            if (Program.sp.Location.X > 0)
            {
                int y = Program.sp.Location.Y - 5;
                Program.sp.Location = new Point((550 / 62 * y), y);
            }
            else
            {
                timerOpenMainForm.Stop();
                Program.sp.WindowState = FormWindowState.Maximized;
                Program.sp.PnSubLogin.Controls.Clear();
                activeFormChild(new MainForm(_context), sender);
                
            }
            if (Program.sp.Size.Height < 1080 && Program.sp.Size.Width < 1920)
            {
                Program.sp.Size = new Size(Program.sp.Size.Width + 150, Program.sp.Size.Height);
                Program.sp.Size = new Size(Program.sp.Size.Width, Program.sp.Size.Height + 30);
            }
        }
    }
}

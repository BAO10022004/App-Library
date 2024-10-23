using App_Library.Services.Interfaces;
using App_Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library.Views
{
    public partial class Form1 : Form
    {
        private readonly MongoDbContext _context;
        private readonly IAuthService _authService;
        public Form1(MongoDbContext context)
        {
            _context = context;
            this.Size = (new MainForm(context)).Size;
            InitializeComponent();
            
        }
    }
}

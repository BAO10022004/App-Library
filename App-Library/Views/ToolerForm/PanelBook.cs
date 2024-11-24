using App_Library.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library.Views.ToolerForm
{
    internal class PanelBook : Guna2Panel
    {
        Book data;

        public PanelBook(Book data)
        {
            this.data = data;
        }
        
        public Book Data1 { get => data; set => data = value; }
    }
}

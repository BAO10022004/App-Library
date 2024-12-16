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
    public class PanelBook : Guna2Panel
    {
        Book data;
        Panel parent;
        public PanelBook(Book data, Panel parent )
        {
            this.data = data;
            this.parent = parent;
        }

        public Book Data { get => data; set => data = value; }
        public Panel Parent { get => parent; set => parent = value; }
    }
}

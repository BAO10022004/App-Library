using App_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library.Views.ToolerForm
{
    internal class PanelBook : Panel
    {
        Book data;

        public PanelBook(Book data)
        {
            this.data = data;
        }
        public Book Data { get => data; }
    }
}

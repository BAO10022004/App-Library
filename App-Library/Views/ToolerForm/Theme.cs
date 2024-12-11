using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library.Views.ToolerForm
{
    internal class Theme
    {
       public  Dictionary<Form, Color> BackRound { get; set; }
        public Dictionary<Form, Color> ForeColor { get; set; }
        public Theme()
        {
            BackRound = new Dictionary<Form, Color>();
            ForeColor = new Dictionary<Form, Color>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Library.Views.ToolerForm
{
    internal class Theme
    {
       public  Color BackRound { get; set; }
        public Color ForeColor { get; set; }
        public Theme(bool isDarkMode)
        {
            if (isDarkMode)
            {
                BackRound = Color.Black;
                ForeColor = Color.White;
            }
            else
            {
                BackRound = Color.White;
                ForeColor = Color.Black;
            }
        }
    }
}

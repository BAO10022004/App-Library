using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Library.Models
{
    public static class SessionManager
    {
        public static string CurrentUsername { get; set; }
        public static string CurrentUserId { get; set; }
    }
}

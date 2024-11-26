using App_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Library.Services
{
    public class Session
    {
        public static string Token { get; set; }
        public static User CurentUser { get; set; }
    }
}

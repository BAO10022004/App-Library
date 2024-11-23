using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Library.Models
{
    internal class UpdateUserDTO
    {
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PhotoURL { get; set; }
        public string Username { get; set; }
    }
}

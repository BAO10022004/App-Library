using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Library.Services
{
    public class AppConfig
    {
        public ApiSettings ApiSettings { get; set; }
        public GGSettings GGSettings { get; set; }
    }

    public class ApiSettings
    {
        public string BaseUrl { get; set; }
    }
    public class GGSettings
    {
        public string clientId { get; set; }
        public string clientSecret { get; set; }
        public string redirectUri { get; set; }
        public string tokenEndpoint { get; set; }
    }
}

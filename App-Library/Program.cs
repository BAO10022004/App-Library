using App_Library.Models;
using App_Library.Views;
using App_Library.Views.SignIn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library
{
    internal static class Program
    {
        static public SplashForm sp;
        static public User user;
        static public List<Panel> ListBookAd;
        static public List<Book> books;
        /// summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            sp = new SplashForm();
            Application.Run(sp);
            //Application.Run(new PdfViewerForm());
            //Application.Run(new GoogleLoginForm());
            //Application.Run(new Form1());
        }
    }
}

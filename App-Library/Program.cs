using App_Library.Services;
using App_Library.Services.Interfaces;
using App_Library.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library
{
    internal static class Program
    {
        static public  SplashForm sp ;
        /// summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            MongoDbContext context = new MongoDbContext("mongodb+srv://6351071034:1234567890@cluster1.yodnw.mongodb.net/","Library");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            sp = new SplashForm(context);
            Application.Run(sp);
        }
    }
}

using System;
using System.Windows.Forms;
using company_management.Views;
using company_management.Controllers;
using company_management.Models;

namespace company_management
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());


            

        }

    }
}

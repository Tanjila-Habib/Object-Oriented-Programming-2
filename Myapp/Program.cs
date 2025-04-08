using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Myapp
{
    internal static class Program
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


            //Application.Run(new Userdashboard(LoginForm lg,"default");
            //Application.Run(new BirthCertificate.ViewCertificateForm());
            //Application.Run(new AdminDashboard(new LoginForm(), "Def"));
            //Application.Run(new UserManagement());
        }
    }
}

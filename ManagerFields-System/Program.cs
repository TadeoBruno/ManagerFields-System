using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagerFields_System.Vista;
using ManagerFields_System.Presentador;
using ManagerFields_System.Modelo;
using ManagerFields_System._Repositorio;
using System.Configuration;
using System.Data.SqlClient;

namespace ManagerFields_System
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string sqlConecctionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            IMainVista vista = new MainVista();
            new MainPresentador(vista, sqlConecctionString);
            Application.Run((Form)vista);
        }
    }
}

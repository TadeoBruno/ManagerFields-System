using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagerFields_System.Vista;
using ManagerFields_System.Modelo;
using ManagerFields_System._Repositorio;

namespace ManagerFields_System.Presentador
{
    public class MainPresentador
    {
        private IMainVista mainVista;
        private readonly string sqlConecctionString;

        public MainPresentador(IMainVista mainVista, string sqlConecctionString)
        {
            this.mainVista = mainVista;
            this.sqlConecctionString = sqlConecctionString;
            this.mainVista.MostarTurnosVista += MostrarTurnosVista;
        }

        private void MostrarTurnosVista(object sender, EventArgs e)
        {
            ITurnosVista vista = TurnosVistaForm.GetInstance((MainVista)mainVista);
            ITurnosRepositorio repositorio = new TurnoRepositorio(sqlConecctionString);
            new TurnosPresentador(vista, repositorio);
        }
    }
}

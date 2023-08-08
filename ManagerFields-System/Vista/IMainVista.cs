using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerFields_System.Vista
{
    public interface IMainVista
    {
        event EventHandler MostarTurnosVista;
        event EventHandler MostarCanchasVista;
        event EventHandler MostarSociosVista;
        event EventHandler MostarInventarioVista;
        event EventHandler MostarEmpleadosVista;
        event EventHandler MostarEventosDeportivosVista;
        event EventHandler MostarIngresosEgresosVista;


    }
}

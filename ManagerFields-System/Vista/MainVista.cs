using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerFields_System.Vista
{
    public partial class MainVista : Form, IMainVista
    {
        public MainVista()
        {
            InitializeComponent();
            btnTurnos.Click += delegate { MostarTurnosVista?.Invoke(this, EventArgs.Empty); };  
        }

        public event EventHandler MostarTurnosVista;
        public event EventHandler MostarCanchasVista;
        public event EventHandler MostarSociosVista;
        public event EventHandler MostarEmpleadosVista;
        public event EventHandler MostarEventosDeportivosVista;
        public event EventHandler MostarInventarioVista;
        public event EventHandler MostarIngresosEgresosVista;
    }
}

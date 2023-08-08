using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerFields_System.Vista
{
    public interface ITurnosVista
    {
        //Propiedades - Capas
        string IdTurno { get; set; }
        string DescripcionTurno { get; set; }
        string FechaTurno { get; set; }
        string HoraTurno { get; set; }
        string PecherasTurno { get; set; }
        string PelotaTurno { get; set; }
        string CanchaTurno { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string MessageResult { get; set; }

        //Eventos
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Metodos
        void SetTurnosListaBindingSource(BindingSource turnosLista);
        void Show();
    }
}

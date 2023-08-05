using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagerFields_System.Modelo;
using ManagerFields_System.Vista;
using System.Windows.Forms;

namespace ManagerFields_System.Presentador
{
    public class TurnosPresentador
    {
        //Campos
        private ITurnosVista vista;
        private ITurnosRepositorio repositorio;
        private BindingSource turnosBindingSource;
        private IEnumerable<TurnoModelo> turnosLista;

        //Constructor
        public TurnosPresentador(ITurnosVista vista, ITurnosRepositorio repositorio)
        {
            this.turnosBindingSource = new BindingSource();
            this.vista = vista;
            this.repositorio = repositorio;

            this.vista.SearchEvent += BuscarTurno;
            this.vista.AddNewEvent += AgregarTurno;
            this.vista.EditEvent += RecuperarTurnoParaEditar;
            this.vista.DeleteEvent += EliminarTurnoSeleccionado;
            this.vista.SaveEvent += GuardarTurno;
            this.vista.CancelEvent += CancelarAcción;
            
            this.vista.SetTurnosListaBindingSource(turnosBindingSource);
            //Cargar lista turnos en vista
            LoadAllTurnosList();
            //Mostrar vista
            this.vista.Show();

        }

        //Metodos
        private void LoadAllTurnosList()
        {
            turnosLista = repositorio.GetAll();
            turnosBindingSource.DataSource = turnosLista;
        }

        private void BuscarTurno(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrEmpty(this.vista.SearchValue);
            if (emptyValue == false)
                turnosLista = repositorio.GetByValue(this.vista.SearchValue);
            else turnosLista = repositorio.GetAll();
            turnosBindingSource.DataSource = turnosLista;
        }

        private void CancelarAcción(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void GuardarTurno(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EliminarTurnoSeleccionado(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RecuperarTurnoParaEditar(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AgregarTurno(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}

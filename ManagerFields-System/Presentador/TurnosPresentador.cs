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
            CleanviewFields();
        }

        private void GuardarTurno(object sender, EventArgs e)
        {
            var modelo = new TurnoModelo();
            modelo.IdTurno = Convert.ToInt32(vista.IdTurno);
            modelo.DescripcionTurno = vista.DescripcionTurno;
            //modelo.HoraTurno = Convert.ToString(vista.HoraTurno);
            //modelo.FechaTurno = Convert.ToDateTime(vista.FechaTurno);
            modelo.PecherasTurno = vista.PecherasTurno;
            modelo.PelotaTurno = vista.PelotaTurno;
            modelo.CanchaTurno = Convert.ToInt32(vista.CanchaTurno);

            try
            {
                new Tareas_Comunes.ModelDataValitation().Validate(modelo);
                if (vista.IsEdit)  //Editar modelo existente    
                {
                    repositorio.Edit(modelo);
                    vista.MessageResult = "Turno editado con éxito";
                }
                else //Agregar nuevo modelo
                {
                    repositorio.Add(modelo);
                    vista.MessageResult = "Turno agregado con éxito";
                }
                vista.IsSuccessful = true;
                LoadAllTurnosList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                vista.IsSuccessful = false;
                vista.MessageResult = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            vista.IdTurno = "0";
            vista.DescripcionTurno = "";
            vista.HoraTurno = "";
            vista.FechaTurno = "";
            vista.PecherasTurno = "";
            vista.PelotaTurno = "";
            vista.CanchaTurno = "";
        }

        private void EliminarTurnoSeleccionado(object sender, EventArgs e)
        {
            try
            {
                var turno = (TurnoModelo)turnosBindingSource.Current;
                repositorio.Delete(turno.IdTurno);
                vista.IsSuccessful = true;
                vista.MessageResult = "Turno eliminado con éxito";
                LoadAllTurnosList();
            }
            catch (Exception ex)
            {
                vista.IsSuccessful = false;
                vista.MessageResult = "A ocurrido un error, no se pudo eliminar el turno";
            }
        }

        private void RecuperarTurnoParaEditar(object sender, EventArgs e)
        {
            var turno = (TurnoModelo)turnosBindingSource.Current;
            vista.IdTurno = turno.IdTurno.ToString();
            vista.DescripcionTurno = turno.DescripcionTurno;
            vista.HoraTurno = turno.HoraTurno.ToString();
            vista.FechaTurno = turno.FechaTurno.ToString();
            vista.PecherasTurno = turno.PecherasTurno.ToString();
            vista.PelotaTurno = turno.PelotaTurno.ToString(); 
            vista.CanchaTurno = turno.CanchaTurno.ToString();
            vista.IsEdit = true;
        }

        private void AgregarTurno(object sender, EventArgs e)
        {
            vista.IsEdit = false;
        }

    }
}

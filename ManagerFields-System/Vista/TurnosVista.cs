using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagerFields_System.Modelo;
using ManagerFields_System._Repositorio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Data.Linq;

namespace ManagerFields_System.Vista
{
    public partial class TurnosVistaForm : Form, ITurnosVista
    {
        //Campos
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        //Constructor
        public TurnosVistaForm()
        {
            InitializeComponent();
            AsociarYGenerarEventosVista();
            tabControl1.TabPages.Remove(tabPageDetalleTurnos);
            btnCerrar.Click += delegate { this.Close(); };
        }

        private void AsociarYGenerarEventosVista()
        {
            //Buscar
            btnBuscarTurno.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); } ;
            btnBuscarTurno.KeyDown+=(s,e)=>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            //Agergar
            btnAgregarTurno.Click += delegate 
            { 
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageTurnosLista );
                tabControl1.TabPages.Add(tabPageDetalleTurnos);
                tabPageDetalleTurnos.Text = "Agregar Turno";
            };

            //Editar
            btnEditarTurno.Click += delegate
            { 
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageTurnosLista);
                tabControl1.TabPages.Add(tabPageDetalleTurnos);
                tabPageDetalleTurnos.Text = "Editar Turno";
            };

            //Eliminar
            btnEliminarTurno.Click += delegate 
            {
                var result = MessageBox.Show("Estas seguro de que quieres eliminar el turno seleccionado?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(message);
                }
            };

            //Cancelar
            btnCancelarTurno.Click += delegate
            { 
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageDetalleTurnos);
                tabControl1.TabPages.Add(tabPageTurnosLista);
            };

            //Guardar
            btnGuardarTurno.Click += delegate 
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPageDetalleTurnos);
                    tabControl1.TabPages.Add(tabPageTurnosLista);
                }
                MessageBox.Show(message);
            };

        }

        //Propiedades
        public string IdTurno
        {
            get { return txtIdTurno.Text; }
            set { txtIdTurno.Text = value; }
        }

        public string DescripcionTurno
        {
            get { return txtDescripcionTurno.Text; }
            set { txtDescripcionTurno.Text = value; }
        }

        public string FechaTurno
        {
            get { return txtFechaTurno.Text; }
            set { txtFechaTurno.Text = value; }
        }

        public string HoraTurno 
        {
            get {return txtHoraTurno.Text; }
            set {txtHoraTurno.Text = value; }
        }

        public string PecherasTurno
        {
            get { return txtbPecheras.Text; }
            set { txtbPecheras.Text = value; }
        }

        public string PelotaTurno
        {
            get { return txtbPelota.Text; }
            set { txtbPelota.Text = value; }
        }

        public string CanchaTurno
        {
            get { return txtbCancha.Text; }
            set { txtbCancha.Text = value; }
        }

        public string SearchValue 
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; } 
        }
        
        public bool IsEdit 
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
       
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        
        public string MessageResult
        {
            get {return message; }
            set { message = value; }
        }
        

        //Eventos
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;


        //Metodos
        public void SetTurnosListaBindingSource(BindingSource turnosLista)
        {
            dataGridView1.DataSource = turnosLista;
        }

        //Singleton
        private static TurnosVistaForm instance;
        public static TurnosVistaForm GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new TurnosVistaForm();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
    }
}

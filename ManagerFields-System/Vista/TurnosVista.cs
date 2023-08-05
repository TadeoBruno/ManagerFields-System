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

namespace ManagerFields_System.Vista
{
    public partial class TurnosVista : Form, ITurnosVista
    {
        //Campos
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        //Constructor
        public TurnosVista()
        {
            InitializeComponent();
            AsociarYGenerarEventosVista();
            tabControl1.TabPages.Remove(tabPageDetalleTurnos);
        }

        private void AsociarYGenerarEventosVista()
        {
            btnBuscarTurno.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); } ;
            btnBuscarTurno.KeyDown+=(s,e)=>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
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
    }
}

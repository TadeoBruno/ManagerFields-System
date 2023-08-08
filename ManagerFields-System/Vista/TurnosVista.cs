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
    public partial class TurnosVistaFrom : Form, ITurnosVista
    {
        //Campos
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        //Constructor
        public TurnosVistaFrom()
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

        public string PecherasTurno
        {
            get {
                if (rbtnNoPecheras.Checked)
                    return rbtnNoPecheras.Text;
                else if (rbtnSiPecheras.Checked)
                    return rbtnSiPecheras.Text;
                return "";
            }
            set {
                if (value == rbtnNoPecheras.Text)
                    rbtnNoPecheras.Checked = true;
                else if (value == rbtnSiPecheras.Text)
                    rbtnSiPecheras.Checked = true;
            }
        }

        public string PelotaTurno
        {
            get {
                if (rbtnNoPelota.Checked) 
                    return rbtnNoPelota.Text;
                else if (rbtnSiPelota.Checked)
                    return rbtnSiPelota.Text;
                return "";
            }
            set {
                if (value == rbtnNoPelota.Text)
                    rbtnNoPelota.Checked = true;
                else if (value == rbtnSiPelota.Text)
                    rbtnSiPelota.Checked = true;
            }
        }

        /*public string CanchaTurno
        {
            get
            {
                if (rbtnCancha1.Checked)
                    return rbtnCancha1.Text;
                else if (rbtnCancha2.Checked)
                    return rbtnCancha2.Text;
                else if (rbtnCancha3.Checked)
                    return rbtnCancha3.Text;
                return "";
            }
            set
            {
                if (value == rbtnCancha1.Text)
                    rbtnCancha1.Checked = true;
                else if (value == rbtnCancha2.Text)
                    rbtnCancha2.Checked = true;
                else if (value == rbtnCancha3.Text)
                    rbtnCancha3.Checked = true;
            }
        }
        */

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

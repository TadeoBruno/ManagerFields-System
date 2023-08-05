using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ManagerFields_System.Modelo
{
    public class TurnoModelo
    {
        private int idTurno;
        private string descripcionTurno;
        private DateTime fechaTurno;
        private TimeSpan horaTurno;

        [DisplayName("Id")]
        public int IdTurno
        {
            get { return idTurno; }
            set { idTurno = value; }
        }

        [DisplayName("Descripción")]
        [Required(ErrorMessage = "La descripción es requerida")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La descripción debe tener entre 3 y 50 caracteres")]
        public string DescripcionTurno
        {
            get { return descripcionTurno; }
            set { descripcionTurno = value; }
        }

        [DisplayName("Fecha")]
        [Required(ErrorMessage = "La fecha es requerida")]
        public DateTime FechaTurno
        {
            get { return fechaTurno; }
            set { fechaTurno = value; }
        }

        [DisplayName("Hora")]
        [Required(ErrorMessage = "La hora es requerida")]
        public TimeSpan HoraTurno
        {
            get { return horaTurno; }
            set { horaTurno = value; }
        }

    }
}

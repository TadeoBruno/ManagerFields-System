using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerFields_System.Modelo
{
    public interface ITurnosRepositorio
    {
        void Add(TurnoModelo turnoModelo);
        void Edit(TurnoModelo turnoModelo);
        void Delete(int idTurno);
        IEnumerable<TurnoModelo> GetAll();
        IEnumerable<TurnoModelo> GetByValue(string value); //Buscador
    }
}

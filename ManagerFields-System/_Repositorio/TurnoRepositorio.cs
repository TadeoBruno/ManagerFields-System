using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ManagerFields_System.Modelo;

namespace ManagerFields_System._Repositorio
{
    public class TurnoRepositorio : BaseRepositorio, ITurnosRepositorio
    {
        //Constructor
        public TurnoRepositorio(string connectionString)
        {
            this.connectionString = connectionString;
        }
        //Metodos
        public void Add(TurnoModelo turnoModelo)
        {
            throw new NotImplementedException();
        }

        public void Delete(int idTurno)
        {
            throw new NotImplementedException();
        }

        public void Edit(TurnoModelo turnoModelo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TurnoModelo> GetAll()
        {
            var turnosLista = new List<TurnoModelo>();
            using (var connection=new SqlConnection(connectionString))
            using (var command=new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Turnos order by turno_id desc";
                using (var reader=command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var turnoModel = new TurnoModelo();
                        turnoModel.IdTurno = (int)reader[0];
                        turnoModel.DescripcionTurno = reader[1].ToString();
                        turnoModel.FechaTurno = (DateTime)reader[2];
                        turnoModel.HoraTurno = (TimeSpan)reader[3];
                        turnoModel.PecherasTurno = (bool)reader[4];
                        turnoModel.PelotaTurno = (bool)reader[5];
                        turnosLista.Add(turnoModel);

                    }
                }
            }

            return turnosLista;
        }

        public IEnumerable<TurnoModelo> GetByValue(string value)
        {
            var turnosLista = new List<TurnoModelo>();
            int idTurno = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0 ;
            string descripcionTurno = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Turnos 
                                        where turno_id=@id or turno_descripcion like @name+'%'
                                        order by turno_id desc";
                command.Parameters.Add("@id", SqlDbType.Int).Value = idTurno;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = descripcionTurno;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var turnoModel = new TurnoModelo();
                        turnoModel.IdTurno = (int)reader[0];
                        turnoModel.DescripcionTurno = reader[1].ToString();
                        turnoModel.FechaTurno = (DateTime)reader[2];
                        turnoModel.HoraTurno = (TimeSpan)reader[3];
                        turnoModel.PecherasTurno = (bool)reader[4];
                        turnoModel.PelotaTurno = (bool)reader[5];
                        turnosLista.Add(turnoModel);

                    }
                }
            }

            return turnosLista;
        }
    }
}

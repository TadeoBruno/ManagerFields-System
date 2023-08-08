using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ManagerFields_System.Modelo;
using ManagerFields_System.Vista;

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
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into Turnos values (@descripcion, @hora, @fecha, @pecheras, @pelota)";
                command.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = turnoModelo.DescripcionTurno;
                command.Parameters.Add("@hora", SqlDbType.Time).Value = turnoModelo.HoraTurno;
                command.Parameters.Add("@fecha", SqlDbType.Date).Value = turnoModelo.FechaTurno;
                command.Parameters.Add("@pecheras", SqlDbType.NVarChar).Value = turnoModelo.PecherasTurno;
                command.Parameters.Add("@pelota", SqlDbType.NVarChar).Value = turnoModelo.PelotaTurno;
                command.Parameters.Add("@cancha", SqlDbType.Int).Value = turnoModelo.PelotaTurno;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int idTurno)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from Turnos where turno_id=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = idTurno;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(TurnoModelo turnoModelo)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update Turno
                                        set turno_descripcion=@descripcion, turno_hora=@hora, turno_fecha=@fecha, turno_pecheras=@pecheras, turno_pelota=@pelota, turno_cancha=@cancha
                                        where turno_id=@id";
                command.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = turnoModelo.DescripcionTurno;
                command.Parameters.Add("@hora", SqlDbType.Time).Value = turnoModelo.HoraTurno;
                command.Parameters.Add("@fecha", SqlDbType.Date).Value = turnoModelo.FechaTurno;
                command.Parameters.Add("@pecheras", SqlDbType.NVarChar).Value = turnoModelo.PecherasTurno;
                command.Parameters.Add("@pelota", SqlDbType.NVarChar).Value = turnoModelo.PelotaTurno;
                command.Parameters.Add("@cancha", SqlDbType.Int).Value = turnoModelo.PelotaTurno;
                command.ExecuteNonQuery();
            }
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
                        turnoModel.PecherasTurno = (string)reader[4];
                        turnoModel.PelotaTurno = (string)reader[5];
                        turnoModel.CanchaTurno = (int)reader[6];
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
                        turnoModel.PecherasTurno = (string)reader[4];
                        turnoModel.PelotaTurno = (string)reader[5];
                        turnoModel.CanchaTurno = (int)reader[6];
                        turnosLista.Add(turnoModel);

                    }
                }
            }

            return turnosLista;
        }
    }
}

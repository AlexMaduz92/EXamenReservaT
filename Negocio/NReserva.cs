using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.BaseDatos
{
    public class ReservaDataAccess
    {
        private readonly string connectionString;

        public ReservaDataAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<DReserva> ObtenerReservas()
        {
            List<DReserva> reservas = new List<DReserva>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ReservaId, FechaReserva, TeatroId, ClienteId, AsientoN FROM DReserva";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DReserva reserva = new DReserva
                            {
                                ReservaId = Convert.ToInt32(reader["ReservaId"]),
                                FechaReserva = Convert.ToDateTime(reader["FechaReserva"]),
                                TeatroId = Convert.ToInt32(reader["TeatroId"]),
                                ClienteId = Convert.ToInt32(reader["ClienteId"]),
                                AsientoN = Convert.ToInt32(reader["AsientoN"])
                            };
                            reservas.Add(reserva);
                        }
                    }
                }
            }

            return reservas;
        }
    }
}

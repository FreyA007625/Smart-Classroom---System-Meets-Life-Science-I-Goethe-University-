using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartClassRoom_Panel.Models
{
    public class SC_Context
    {
        public string ConnectionString { get; set; }

        public SC_Context(string connectionString)
        {
            ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<Classroom> GetAllClassrooms()
        {
            List<Classroom> list = new List<Classroom>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from classrooms", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Classroom()
                        {
                            CO2_Concentration = reader["CO2_Concentration"].ToString(),
                            Time = DateTime.Parse(reader["Time"].ToString()),
                            Temperature = Convert.ToInt32(reader["Temperature"]),
                            Location = reader["Location"].ToString()
                        }) ;
                    }
                }
            }
            return list;
        }

    }
}

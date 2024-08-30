using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using RecapWebAPI_COMMON.Entities;
using RecapWebAPI_DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RecapWebAPI_DAL.Respositories
{
    public class PlayerRepo : IPlayerRepo
    {
        private readonly string _connectionString;

        //IConfiguration => nuget Microsoft.Extensions.Configuration
        // Permet d'accèder à appsettings.json
        public PlayerRepo(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("default");
        }

        private Player Mapper(SqlDataReader reader)
        {
            return new Player
            {
                Id = (int)reader["Id"],
                Lastname = reader["Lastname"].ToString(),
                Firstname = reader["Firstname"].ToString(),
                Nickname = reader["Nickname"].ToString(),
                Email = reader["Email"].ToString()
            };
        }

        public List<Player> GetAll()
        {
            List<Player> list = new List<Player>();

            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    string sqlQuery = "SELECT * FROM players";
                    cmd.CommandText = sqlQuery;
                    cnx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(Mapper(reader));
                        }
                    }
                    cnx.Close();
                }

            }
            return list;
        }
    }
}

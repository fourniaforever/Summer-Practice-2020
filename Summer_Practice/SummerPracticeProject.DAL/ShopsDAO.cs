using SummerPracticeProject.Dao.Interfaces;
using SummerPracticeProject.Entities;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SummerPracticeProject.DAL
{
    public class ShopsDAO : TemplateDAO, IShopsDao
    {
        public void Add(Shops s)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = GetSqlCommand(connection, "dbo.AddShop");
                AddSqlParameter(GetSqlParameter("Name", s.Name, DbType.String), command);
                AddSqlParameter(GetSqlParameter("Address", s.Address, DbType.String), command);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Remove(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = GetSqlCommand(connection, "dbo.RemoveUsersById");
                AddSqlParameter(GetSqlParameter("Id", id, DbType.Int32), command);

                connection.Open();
                var reader = command.ExecuteReader();
            }
        }

        public Shops GetById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = GetSqlCommand(connection, "dbo.GetShopsById");
                AddSqlParameter(GetSqlParameter("Id", id, DbType.Int32), command);

                connection.Open();
                var reader = command.ExecuteReader();
                Shops ChosenShop = null;
                while (reader.Read())
                {
                    ChosenShop = new Shops

                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"] as string,
                        Address = reader["Address"] as string
                    };
                }
                return ChosenShop;
            }
        }

        public IEnumerable<Shops> GetAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetAllShops", connection);  //SQL-команда
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                connection.Open();
                var reader = cmd.ExecuteReader();
                List<Shops> shops = new List<Shops>();
                while (reader.Read())
                {
                    shops.Add(new Shops
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"] as string,
                        Address = reader["Address"] as string
                    });
                }
                return shops;
            }
        }

        public IEnumerable<string> SelectShopsByRate(int rate)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("SelectShopsByRate", connection);  //SQL-команда
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@rate", rate);
                connection.Open();
                var reader = cmd.ExecuteReader();
                List<string> Dishes = new List<string>();
                while (reader.Read())
                {
                    Dishes.Add(reader["Name"] as string);
                }
                return Dishes;
            }
        }
    }
}
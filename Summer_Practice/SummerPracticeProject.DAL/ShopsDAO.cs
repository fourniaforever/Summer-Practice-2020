using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummerPracticeProject.Dao.Interfaces;
using SummerPracticeProject.Entities;
using System.Data;
using System.Data.SqlClient;

namespace SummerPracticeProject.DAL
{
    public class ShopsDAO :IShopsDao
    {
        private string _connectionString = @"";
        private static Dictionary<int, Shops> _shops= new Dictionary<int, Shops>();
        public void Add(Shops s)
        {
            int lastKey = _shops.Keys.LastOrDefault();
            s.Id = lastKey + 1;
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.AddShop";

                var idParameter = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Id",
                    Value = s.Id,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(idParameter);

                var nameParameter = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@Name",
                    Value = s.Name,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(nameParameter);

                var addressParameter = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@Address",
                    Value = s.Address,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(addressParameter);
                connection.Open();
                var reader = command.ExecuteReader();
            }
        }
        public void Remove(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.RemoveShopsById";

                var idParameter = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Id",
                    Value = id,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(idParameter);

                connection.Open();
                var reader = command.ExecuteReader();
            }
        }

        public Shops GetById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.GetShopsById";

                var idParameter = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Id",
                    Value = id,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(idParameter);

                connection.Open();
                var reader = command.ExecuteReader();
                Shops ChosenShop = null;
                while (reader.Read())
                {
                    ChosenShop = new Shops((int)reader["Id"],
                       reader["Name"] as string,
                       reader["Address"] as string
                       );
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
                    shops.Add(new Shops((int)reader["Id"],
                       reader["Name"] as string,
                       reader["Address"] as string
                       ));
                }
                return shops;
            }

        }

        public IEnumerable<string> SelectShopsByRate(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("SelectShopsByRate", connection);  //SQL-команда
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCountry", id);
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

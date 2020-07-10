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
    public class ShopsDAO : TemplateDAO,IShopsDao
    {
        private static Dictionary<int, Shops> _shops= new Dictionary<int, Shops>();
        public void Add(Shops s)
        {
            int lastKey = _shops.Keys.LastOrDefault();
            s.Id = lastKey + 1;
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = GetSqlCommand(connection, "dbo.AddShop");
                AddSqlParameter(GetSqlParameter("Id", s.Id, DbType.Int32), command);
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
                SqlCommand command = GetSqlCommand(connection, "dbo.RemoveUser");
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

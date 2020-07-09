using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummerPracticeProject.Dao.Interfaces;
using SummerPracticeProject.Entities;

namespace SummerPracticeProject.DAL
{
    public class RatesDAO: IRatesDao
    {
        private string _connectionString = @"";
        private static Dictionary<int,Rates> _rates = new Dictionary<int,Rates>();
        public void Add(Rates r)
        {
            int lastKey = _rates.Keys.LastOrDefault();
            r.Id = lastKey + 1;
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.AddRate";

                var idParameter = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Id",
                    Value = r.Id,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(idParameter);

                var idShopParameter = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@IdShop",
                    Value = r.IdShop,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(idShopParameter);

                var dateParameter = new SqlParameter()
                {
                    DbType = DbType.DateTime,
                    ParameterName = "@Date",
                    Value = r.Date,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(dateParameter);

                var rateParameter = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Rate",
                    Value = r.Rate,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(rateParameter);

                var rateByParameter = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@RateBy",
                    Value = r.RateBy,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(rateByParameter);

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
                command.CommandText = "dbo.RemoveRatesById";

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

        public Rates GetById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.GetRatesById";

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
                Rates ChosenRate = null;
                while (reader.Read())
                {
                     ChosenRate = new Rates((int)reader["Id"],
                        (int)reader["IdShop"],
                        (DateTime)reader["Date"],
                        (int)reader["Rate"],
                        (int)reader["RateBy"]);
                }
                return ChosenRate;
            }
        }

        public IEnumerable<Rates> GetAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetAllRates", connection);  //SQL-команда
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                connection.Open();
                var reader = cmd.ExecuteReader();
                List<Rates> rates = new List<Rates>();
                while (reader.Read())
                {
                    rates.Add(new Rates((int)reader["Id"],
                        (int)reader["IdShop"],
                        (DateTime)reader["Date"],
                        (int)reader["Rate"],
                        (int)reader["RateBy"]));
                }
                return rates;
            }

        }
    }
}

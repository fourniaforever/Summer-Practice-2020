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
    public class RatesDAO: TemplateDAO,IRatesDao
    {
        public void Add(Rates r)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = GetSqlCommand(connection, "dbo.AddRate");
                AddSqlParameter(GetSqlParameter("IdShop", r.IdShop, DbType.Int32), command);
                AddSqlParameter(GetSqlParameter("Date", r.Date, DbType.DateTime), command);
                AddSqlParameter(GetSqlParameter("Rate", r.Rate, DbType.Int32), command);
                AddSqlParameter(GetSqlParameter("RateBy", r.RateBy, DbType.Int32), command);
                connection.Open();
                var reader = command.ExecuteReader();
            }
        }
        public void Remove(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = GetSqlCommand(connection, "dbo.RemoveRatesById");
                AddSqlParameter(GetSqlParameter("Id", id, DbType.Int32), command);
                connection.Open();
                var reader = command.ExecuteReader();
            }
        }

        public Rates GetById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = GetSqlCommand(connection, "dbo.GetRatesById");
                AddSqlParameter(GetSqlParameter("Id", id, DbType.Int32), command);

                connection.Open();
                var reader = command.ExecuteReader();
                Rates ChosenRate = null;
                while (reader.Read())
                {
                     ChosenRate = new Rates
                     {
                        Id = (int)reader["Id"],
                        IdShop = (int)reader["IdShop"],
                        Date = (DateTime)reader["Date"],
                        Rate = (int)reader["Rate"],
                        RateBy = (int)reader["RateBy"]
                     };
                }
                return ChosenRate;
            }
        }

        public Rates GetByRate(int rate)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = GetSqlCommand(connection, "dbo.GetRatesByRate");
                AddSqlParameter(GetSqlParameter("Rate", rate, DbType.Int32), command);

                connection.Open();
                var reader = command.ExecuteReader();
                Rates ChosenRate = null;
                while (reader.Read())
                {
                    ChosenRate = new Rates
                    {
                       Id = (int)reader["Id"],
                       IdShop = (int)reader["IdShop"],
                       Date = (DateTime)reader["Date"],
                       Rate = (int)reader["Rate"],
                       RateBy = (int)reader["RateBy"]
                    };
                }
                return ChosenRate;
            }
        }
        public Rates GetByShopId(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = GetSqlCommand(connection, "dbo.GetRatesByRate");
                AddSqlParameter(GetSqlParameter("IdShop", id, DbType.Int32), command);

                connection.Open();
                var reader = command.ExecuteReader();
                Rates ChosenRate = null;
                while (reader.Read())
                {
                    ChosenRate = new Rates
                    {
                        Id = (int)reader["Id"],
                        IdShop = (int)reader["IdShop"],
                        Date = (DateTime)reader["Date"],
                        Rate = (int)reader["Rate"],
                        RateBy = (int)reader["RateBy"]
                    };
                }
                return ChosenRate;
            }
        }

        public IEnumerable<Rates> GetAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetAllRates", connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };  //SQL-команда

                connection.Open();
                var reader = cmd.ExecuteReader();
                List<Rates> rates = new List<Rates>();
                while (reader.Read())
                {
                    rates.Add(new Rates
                    {
                        Id = (int)reader["Id"],
                        IdShop = (int)reader["IdShop"],
                        Date = (DateTime)reader["Date"],
                        Rate = (int)reader["Rate"],
                        RateBy = (int)reader["RateBy"]
                    });
                }
                return rates;
            }

        }
    }
}

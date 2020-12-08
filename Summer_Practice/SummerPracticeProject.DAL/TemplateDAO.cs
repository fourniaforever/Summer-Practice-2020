using System.Data;
using System.Data.SqlClient;

namespace SummerPracticeProject.DAL
{
    public class TemplateDAO
    {
        protected string _connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=ShopsRates;Integrated Security=True";

        public SqlParameter GetSqlParameter(string nameofparameter, object value, DbType type)
        {
            return new SqlParameter()
            {
                DbType = type,
                ParameterName = nameofparameter,
                Value = value,
                Direction = ParameterDirection.Input
            };
        }

        public SqlCommand GetSqlCommand(SqlConnection connection, string command)
        {
            SqlCommand sqlCommand = connection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = command;
            return sqlCommand;
        }

        public void AddSqlParameter(SqlParameter parameter, SqlCommand command)
        {
            command.Parameters.Add(parameter);
        }
    }
}
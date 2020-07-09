using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummerPracticeProject.Dao.Interfaces;
using System.Data.SqlClient;
using System.Data;
using SummerPracticeProject.Entities;


namespace SummerPracticeProject.DAL
{
    public class UsersDAO: IUsersDao
    {
        private string _connectionString = "";
        private static Dictionary<int, Users> _users = new Dictionary<int, Users>();
        public void Add(Users users)
        {
            int lastKey = _users.Keys.LastOrDefault();
            users.Id = lastKey + 1;
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.AddShop";

                var idParameter = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Id",
                    Value = users.Id,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(idParameter);

                var nameParameter = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@Name",
                    Value = users.Name,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(nameParameter);

                /*var addressParameter = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@Address",
                    Value = users.Address,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(addressParameter);
                */
                connection.Open();
                var reader = command.ExecuteReader();
            }
        }

        public bool Authentication(Users user)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.Authentication";

                var usernameParameter = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@Login",
                    Value = user.Login,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(usernameParameter);

                var passwordParameter = new SqlParameter()
                {
                    DbType = DbType.Binary,
                    ParameterName = "@Password",
                    Value = user.Hash,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(passwordParameter);

                connection.Open();

                var resultCommand = command.ExecuteScalar();

                return (int)resultCommand > 0;

            }
        }
    }
}

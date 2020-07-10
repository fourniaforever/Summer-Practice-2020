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
    public class UsersDAO: TemplateDAO,IUsersDao
    {
        private static Dictionary<int, Users> _users = new Dictionary<int, Users>();
        public void Add(Users users)
        {
            int lastKey = _users.Keys.LastOrDefault();
            users.Id = lastKey + 1;
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = GetSqlCommand(connection,"dbo.AddUser");
                AddSqlParameter(GetSqlParameter("Id",users.Id,DbType.Int32),command);
                AddSqlParameter(GetSqlParameter("Name", users.Name, DbType.String), command);
                AddSqlParameter(GetSqlParameter("Surname", users.Surname, DbType.String), command);
                AddSqlParameter(GetSqlParameter("Login", users.Login, DbType.String), command);
                AddSqlParameter(GetSqlParameter("Password", users.Password, DbType.Binary), command);
                AddSqlParameter(GetSqlParameter("City", users.City, DbType.String), command);
                connection.Open();
                command.ExecuteNonQuery();

            }
        }

        public bool Authentication(Users user)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = GetSqlCommand(connection, "dbo.AddUser");
                AddSqlParameter(GetSqlParameter("Login", user.Login, DbType.String), command);
                AddSqlParameter(GetSqlParameter("Password", user.Password, DbType.Binary), command);

                connection.Open();
                var resultCommand = command.ExecuteScalar();

                return (int)resultCommand > 0;
            }
        }

        public void Edit(Users users)
        {
            int lastKey = _users.Keys.LastOrDefault();
            users.Id = lastKey + 1;
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = GetSqlCommand(connection, "dbo.AddUser");
                AddSqlParameter(GetSqlParameter("Id", users.Id, DbType.Int32), command);
                AddSqlParameter(GetSqlParameter("Name", users.Name, DbType.String), command);
                AddSqlParameter(GetSqlParameter("Surname", users.Surname, DbType.String), command);
                AddSqlParameter(GetSqlParameter("Login", users.Login, DbType.String), command);
                AddSqlParameter(GetSqlParameter("Password", users.Password, DbType.Binary), command);
                AddSqlParameter(GetSqlParameter("City", users.City, DbType.String), command);
                connection.Open();
                command.ExecuteNonQuery();

            }
        }


    }
}

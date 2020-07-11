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
        
        public void Add(Users users)
        {
            
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = GetSqlCommand(connection,"dbo.AddUser");
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
                SqlCommand command = GetSqlCommand(connection, "dbo.Authentication");
                AddSqlParameter(GetSqlParameter("Login", user.Login, DbType.String), command);
                AddSqlParameter(GetSqlParameter("Password", user.Password, DbType.Binary), command);

                connection.Open();
                var resultCommand = command.ExecuteScalar();

                return (int)resultCommand > 0;
            }
        }

        public void Edit(Users users)
        {
            
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = GetSqlCommand(connection, "dbo.AddUser");
                AddSqlParameter(GetSqlParameter("Name", users.Name, DbType.String), command);
                AddSqlParameter(GetSqlParameter("Surname", users.Surname, DbType.String), command);
                AddSqlParameter(GetSqlParameter("Login", users.Login, DbType.String), command);
                AddSqlParameter(GetSqlParameter("Password", users.Password, DbType.Binary), command);
                AddSqlParameter(GetSqlParameter("City", users.City, DbType.String), command);
                connection.Open();
                command.ExecuteNonQuery();

            }
        }

        public Users GetById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = GetSqlCommand(connection, "dbo.GetUsersById");
                AddSqlParameter(GetSqlParameter("Id", id, DbType.Int32), command);

                connection.Open();
                var reader = command.ExecuteReader();
                Users ChosenUser = null;
                while (reader.Read())
                {
                    ChosenUser = new Users(){
                       Id = (int)reader["Id"],
                       Name = reader["Name"] as string
                       };
                }
                return ChosenUser;
            }
        }


        public Users GetByLogin(string login)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = GetSqlCommand(connection, "dbo.GetUserByLogin");
                AddSqlParameter(GetSqlParameter("Login", login, DbType.String), command);

                connection.Open();
                var reader = command.ExecuteReader();
                Users ChosenUser = null;
                while (reader.Read())
                {
                    ChosenUser = new Users()
                    { 
                        Id = (int)reader["Id"],
                        Name = reader["Name"] as string,
                        Surname = reader["Surname"] as string,
                        Login = reader["Login"] as string,
                        City = reader["City"] as string
                    };
                }
                return ChosenUser;
            }
        }


    }
}

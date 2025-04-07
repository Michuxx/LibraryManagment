using LibraryManagmentProject.Models;
using Microsoft.Data.SqlClient;
using System;

namespace LibraryManagmentProject.Repositories
{
    public class UserRepository
    {
        private readonly string connectionString;
        public UserRepository()
        {
            SQLCONNECT sqlConnect = new SQLCONNECT();
            connectionString = sqlConnect.connectionString;

        }
        public void RegistryUser(User user)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var command = new SqlCommand("INSERT INTO Users (UserName, HashedPassword) VALUES (@Username, @PasswordHash)", connection);
                    command.Parameters.AddWithValue("@Username", user.UserName);
                    command.Parameters.AddWithValue("@PasswordHash", user.HashedPassword);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
            }
        }

        public User GetUserByUsername(string username)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var command = new SqlCommand("SELECT * FROM Users WHERE UserName = @UserName", connection);
                    command.Parameters.AddWithValue("@UserName", username);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                UserId = reader.GetInt32(0),
                                UserName = reader.GetString(1),
                                HashedPassword = reader.GetString(2),
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
            }

            return null;
        }
    }
}

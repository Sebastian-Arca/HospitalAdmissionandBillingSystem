using Microsoft.Data.SqlClient;

namespace BusinessLogic.Repository
{
    public class UserRepository
    {
        public string Login(
            string username,
            string password)
        {
            string connectionString =
                DatabaseConfig.GetConnectionString();

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                connection.Open();

                string query =
                    @"SELECT TOP 1 Role
                      FROM dbo.Users
                      WHERE Username = @username
                      AND [Password] = @password";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@username",
                        username);

                    command.Parameters.AddWithValue(
                        "@password",
                        password);

                    object result =
                        command.ExecuteScalar();

                    return result?.ToString() ?? "";
                }
            }
        }
    }
}

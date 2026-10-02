using System;
using Microsoft.Extensions.Configuration;

namespace BusinessLogic
{
    public static class DatabaseConfig
    {
        public static string GetConnectionString()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString =
                config.GetConnectionString("HospitalDB") ?? "";

            if (connectionString == "")
            {
                throw new Exception(
                    "HospitalDB connection string was not found.");
            }

            return connectionString;
        }
    }
}
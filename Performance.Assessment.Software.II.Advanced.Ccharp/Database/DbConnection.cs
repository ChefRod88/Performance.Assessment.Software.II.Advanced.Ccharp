using System;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace SchedulingApp
{
    public static class DbConnection
    {
        private static MySqlConnection connection;

        // Initialize and open the database connection
        public static void OpenConnection()
        {
            try
            {
                if (connection == null)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                    Console.WriteLine("Database connection opened successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening database connection: {ex.Message}");
                throw;
            }
        }

        // Close the database connection
        public static void CloseConnection()
        {
            try
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    Console.WriteLine("Database connection closed successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error closing database connection: {ex.Message}");
                throw;
            }
        }

        // Get the active database connection
        public static MySqlConnection GetConnection()
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                OpenConnection();
            }
            return connection;
        }
    }
}

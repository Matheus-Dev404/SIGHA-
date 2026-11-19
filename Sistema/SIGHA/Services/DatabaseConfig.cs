using MySql.Data.MySqlClient;

namespace SIGHA.Services
{
    public static class DatabaseConfig
    {
        // Update credentials if your XAMPP uses a root password. By default, XAMPP root password is empty.
        private static readonly string connectionString = "Server=localhost;Port=3307;Database=sigha_db;Uid=root;Pwd=;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}

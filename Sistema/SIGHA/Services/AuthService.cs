using System;
using MySql.Data.MySqlClient;
using SIGHA.Models;

namespace SIGHA.Services
{
    public static class AuthService
    {
        public static bool Autenticar(string username, string password)
        {
            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT Id, Username, Role, NomeCompleto FROM Usuarios WHERE Username = @Username AND Password = @Password";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                SessaoTracker.UsuarioLogado = new Usuario
                                {
                                    Id = reader.GetInt32("Id"),
                                    Username = reader.GetString("Username"),
                                    Role = reader.GetString("Role"),
                                    NomeCompleto = reader.GetString("NomeCompleto")
                                };
                                return true;
                            }
                            else
                            {
                                System.Windows.Forms.MessageBox.Show("Usuário ou senha inválidos. Tente novamente!", "Aviso", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                                return false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // In a case where the DB is not setup yet but we want to fail gracefully or show a message:
                System.Windows.Forms.MessageBox.Show("Erro de conexão ao BD: " + ex.Message, "Erro SQL", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }

            return false;
        }

        public static void Logout()
        {
            SessaoTracker.UsuarioLogado = null;
        }
    }
}

using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SIGHA.Services;

namespace SIGHA
{
    public partial class panelCadastroUsuario : Form
    {
        public panelCadastroUsuario()
        {
            InitializeComponent();
            SIGHA.Services.ThemeManager.ApplyTheme(this);
            this.btnCadastroUsuario.Click += BtnCadastroUsuario_Click;
        }

        private void BtnCadastroUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BoxLoginUsuario.Text) || string.IsNullOrWhiteSpace(BoxSenhaUsuario.Text) || string.IsNullOrWhiteSpace(BoxNomeUsuario.Text))
            {
                MessageBox.Show("Preencha Nome, Login e Senha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Usuarios (Username, Password, Role, NomeCompleto, Setor) VALUES (@User, @Pass, @Role, @Nome, @Setor)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@User", BoxLoginUsuario.Text);
                        cmd.Parameters.AddWithValue("@Pass", BoxSenhaUsuario.Text);
                        
                        // Determinar Role pelo combo Setor ou default Atendente
                        string setorDesc = comboBoxSetor.SelectedItem?.ToString() ?? "Atendimento";
                        string role = "Atendente";
                        if (setorDesc == "Admin") role = "Administrador";
                        else if (setorDesc == "Medicina") role = "Medico";
                        else if (setorDesc == "Enfermagem") role = "Enfermeiro";
                        
                        cmd.Parameters.AddWithValue("@Role", role);
                        cmd.Parameters.AddWithValue("@Nome", BoxNomeUsuario.Text);
                        cmd.Parameters.AddWithValue("@Setor", setorDesc);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

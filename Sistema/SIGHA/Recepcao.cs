using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SIGHA.Services;

namespace SIGHA
{
	public partial class Recepcao : Form
	{
		public Recepcao()
		{
			InitializeComponent();
			SIGHA.Services.ThemeManager.ApplyTheme(this);
            this.btnEnviarParaTriagem.Click += BtnEnviarParaTriagem_Click;
		}

        private void BtnEnviarParaTriagem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BoxCpfPaciente.Text))
            {
                MessageBox.Show("Preencha o CPF do Paciente para enviar à  triagem.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    
                    // Verificar se CPF existe
                    string checkSql = "SELECT Id FROM Pacientes WHERE Cpf = @Cpf";
                    using (var checkCmd = new MySqlCommand(checkSql, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Cpf", BoxCpfPaciente.Text);
                        var exists = checkCmd.ExecuteScalar();
                        if (exists == null)
                        {
                            MessageBox.Show("Paciente não encontrado. Cadastre o paciente primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string query = "INSERT INTO Recepcoes (PacienteCpf, SintomasIniciais) VALUES (@Cpf, @Sintomas)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Cpf", BoxCpfPaciente.Text);
                        cmd.Parameters.AddWithValue("@Sintomas", BoxSintomasIniciais.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Paciente inserido na Fila de Triagem com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar paciente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void label3_Click(object sender, EventArgs e) { }
	}
}

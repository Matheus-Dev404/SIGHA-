using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SIGHA.Services;

namespace SIGHA
{
	public partial class PanelCadastroPacientes : Form
	{
		public PanelCadastroPacientes()
		{
			InitializeComponent();
			SIGHA.Services.ThemeManager.ApplyTheme(this);
            
            this.btnSalvar.Click += BtnSalvar_Click;
            this.btnBuscar.Click += BtnBuscar_Click;
		}

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Box_Cpf.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Preencha ao menos Nome e CPF.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Pacientes (Cpf, Nome, DataNascimento, Sexo, Email) VALUES (@Cpf, @Nome, @DatNasc, @Sexo, @Email)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Cpf", Box_Cpf.Text);
                        cmd.Parameters.AddWithValue("@Nome", textBox1.Text);
                        cmd.Parameters.AddWithValue("@DatNasc", dateTimePicker1.Value.Date);
                        cmd.Parameters.AddWithValue("@Sexo", comboBox_Sexo.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@Email", Box_Email.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Paciente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT Id, Cpf, Nome, DataNascimento, Sexo, Email, DataCadastro FROM Pacientes WHERE Nome LIKE @busca OR Cpf LIKE @busca";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@busca", "%" + Box_Pesquisar.Text + "%");
                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void label1_Click(object sender, EventArgs e) { }
	}
}

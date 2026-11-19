using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SIGHA.Services;

namespace SIGHA
{
	public partial class Triagem : Form
	{
        private int _recepcaoIdAtual = 0;

		public Triagem()
		{
			InitializeComponent();
			SIGHA.Services.ThemeManager.ApplyTheme(this);
            this.Load += Triagem_Load;
            this.btnProxPaciente.Click += BtnProxPaciente_Click;
            this.btnSalvar.Click += BtnSalvar_Click;
		}

        private void Triagem_Load(object sender, EventArgs e)
        {
            CarregarFilaTriagem();
        }

        private void CarregarFilaTriagem()
        {
            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT t1.Id as RecepcaoId, t1.PacienteCpf as CPF, t2.Nome, t1.SintomasIniciais, t1.DataEntrada 
                                     FROM Recepcoes t1 
                                     INNER JOIN Pacientes t2 ON t1.PacienteCpf = t2.Cpf 
                                     WHERE t1.StatusAtendimento = 'Aguardando Triagem' 
                                     ORDER BY t1.DataEntrada ASC";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
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
                MessageBox.Show("Erro ao carregar fila de triagem: " + ex.Message);
            }
        }

        private void BtnProxPaciente_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.Rows[0].Cells["RecepcaoId"].Value != null)
            {
                _recepcaoIdAtual = Convert.ToInt32(dataGridView1.Rows[0].Cells["RecepcaoId"].Value);
                MessageBox.Show($"Próximo paciente chamado: {dataGridView1.Rows[0].Cells["Nome"].Value}", "Próximo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("A fila de triagem está vazia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _recepcaoIdAtual = 0;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (_recepcaoIdAtual == 0)
            {
                MessageBox.Show("Nenhum paciente selecionado da fila de triagem.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    
                    // Inserir registro de Triagem
                    string queryInsert = "INSERT INTO Triagens (RecepcaoId, Evolucao, CodigoManchester) VALUES (@RecepcaoId, @Evolucao, @Manchester)";
                    using (var cmdInsert = new MySqlCommand(queryInsert, conn))
                    {
                        cmdInsert.Parameters.AddWithValue("@RecepcaoId", _recepcaoIdAtual);
                        cmdInsert.Parameters.AddWithValue("@Evolucao", textBox1.Text);
                        cmdInsert.Parameters.AddWithValue("@Manchester", comboBox1.SelectedItem?.ToString() ?? "Verde");
                        cmdInsert.ExecuteNonQuery();
                    }

                    // Atualizar Status da Recepcao
                    string queryUpdate = "UPDATE Recepcoes SET StatusAtendimento = 'Aguardando Medico' WHERE Id = @RecepcaoId";
                    using (var cmdUpdate = new MySqlCommand(queryUpdate, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@RecepcaoId", _recepcaoIdAtual);
                        cmdUpdate.ExecuteNonQuery();
                    }

                    MessageBox.Show("Triagem salva com sucesso. Paciente encaminhado para atendimento médico.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "";
                    _recepcaoIdAtual = 0;
                    CarregarFilaTriagem();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar triagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void label1_Click(object sender, EventArgs e) { }
	}
}

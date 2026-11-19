using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SIGHA.Services;

namespace SIGHA
{
    public partial class PanelHistoricoPaciente : Form
    {
        public PanelHistoricoPaciente()
        {
            InitializeComponent();
            SIGHA.Services.ThemeManager.ApplyTheme(this);
            this.Load += PanelHistoricoPaciente_Load;

            if (this.btnBuscar != null)
                this.btnBuscar.Click += btnBuscar_Click;
        }

        private void PanelHistoricoPaciente_Load(object sender, EventArgs e)
        {
            if (DataGridViewHistoricoPaciente != null)
                DataGridViewHistoricoPaciente.DataSource = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cpf = txtBuscaHistoricoPacienteCPF?.Text.Trim() ?? "";

            if (string.IsNullOrWhiteSpace(cpf))
            {
                MessageBox.Show("Digite um CPF para pesquisar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();

                    // Verificar paciente
                    string qPac = "SELECT Nome FROM Pacientes WHERE Cpf = @Cpf";
                    using (var cmd = new MySqlCommand(qPac, conn))
                    {
                        cmd.Parameters.AddWithValue("@Cpf", cpf);
                        var nome = cmd.ExecuteScalar();
                        if (nome == null)
                        {
                            MessageBox.Show("Paciente não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Histórico completo: consultas + exames
                    string qHist = @"
                        SELECT c.DataAtendimento AS Data,
                               'Consulta'        AS Tipo,
                               u.NomeCompleto    AS Profissional,
                               c.DetalhesConsulta AS Descricao
                        FROM   ConsultasProntuario c
                        JOIN   Usuarios u ON c.MedicoId = u.Id
                        WHERE  c.PacienteCpf = @Cpf

                        UNION ALL

                        SELECT e.DataSolicitacao AS Data,
                               CONCAT('Exame — ', e.Status) AS Tipo,
                               u.NomeCompleto    AS Profissional,
                               e.DescricaoExame  AS Descricao
                        FROM   Exames e
                        JOIN   Usuarios u ON e.MedicoId = u.Id
                        WHERE  e.PacienteCpf = @Cpf

                        ORDER  BY Data DESC";

                    using (var cmd = new MySqlCommand(qHist, conn))
                    {
                        cmd.Parameters.AddWithValue("@Cpf", cpf);
                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            var dt = new DataTable();
                            adapter.Fill(dt);
                            if (DataGridViewHistoricoPaciente != null)
                            {
                                DataGridViewHistoricoPaciente.DataSource = dt;
                                DataGridViewHistoricoPaciente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            }
                            if (dt.Rows.Count == 0)
                                MessageBox.Show("Nenhum histórico encontrado para este paciente.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar histórico: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

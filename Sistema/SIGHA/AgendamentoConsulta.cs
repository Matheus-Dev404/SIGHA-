using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SIGHA.Services;

namespace SIGHA
{
    public partial class AgendamentoConsulta : Form
    {
        public AgendamentoConsulta()
        {
            InitializeComponent();
            SIGHA.Services.ThemeManager.ApplyTheme(this);
            this.Load += AgendamentoConsulta_Load;

            if (this.btnCadastrar != null) this.btnCadastrar.Click += BtnCadastrar_Click;
            if (this.btnAtualizar != null) this.btnAtualizar.Click += (s, e) => CarregarAgendamentos();
            if (this.btnExcluir  != null) this.btnExcluir.Click  += BtnExcluir_Click;

            // Cálculo automático de troco
            if (this.BoxValorRecebidoPgto != null)
                this.BoxValorRecebidoPgto.TextChanged += CalcularTroco;
            if (this.BoxValorTotalPgto != null)
                this.BoxValorTotalPgto.TextChanged += CalcularTroco;
        }

        private void AgendamentoConsulta_Load(object sender, EventArgs e) => CarregarAgendamentos();

        private void CarregarAgendamentos()
        {
            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    string q = @"SELECT a.Id, a.PacienteCpf AS CPF,
                                        a.NomeProfissional AS Profissional,
                                        a.Especialidade, a.ServicoRealizado AS Servico,
                                        a.HorarioConsulta AS Horario,
                                        a.FormaPagamento AS Pagamento,
                                        a.ValorTotal AS Total, a.Status
                                 FROM   Agendamentos a
                                 ORDER  BY a.HorarioConsulta DESC";
                    using (var cmd = new MySqlCommand(q, conn))
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        adapter.Fill(dt);
                        if (dataGridView1 != null)
                        {
                            dataGridView1.DataSource = dt;
                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar agendamentos: " + ex.Message);
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BoxCpfPaciente?.Text))
            {
                MessageBox.Show("Informe o CPF do paciente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    string q = @"INSERT INTO Agendamentos
                                 (PacienteCpf, NomeProfissional, Especialidade, ServicoRealizado,
                                  ValorServico, FormaPagamento, ValorTotal, ValorRecebido, Troco)
                                 VALUES (@Cpf, @Prof, @Esp, @Serv, @Valor, @Pgto, @Total, @Recebido, @Troco)";

                    using (var cmd = new MySqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@Cpf",      BoxCpfPaciente?.Text ?? "");
                        cmd.Parameters.AddWithValue("@Prof",     BoxNomeProfissional?.Text ?? "");
                        cmd.Parameters.AddWithValue("@Esp",      BoxEspecialidadesProfissional?.Text ?? "");
                        cmd.Parameters.AddWithValue("@Serv",     BoxServico?.Text ?? "");
                        cmd.Parameters.AddWithValue("@Valor",    decimal.TryParse(BoxValorServico?.Text, out decimal v) ? v : 0);
                        cmd.Parameters.AddWithValue("@Pgto",     comboPgto?.SelectedItem?.ToString() ?? "Dinheiro");
                        cmd.Parameters.AddWithValue("@Total",    decimal.TryParse(BoxValorTotalPgto?.Text, out decimal t) ? t : 0);
                        cmd.Parameters.AddWithValue("@Recebido", decimal.TryParse(BoxValorRecebidoPgto?.Text, out decimal r) ? r : 0);
                        cmd.Parameters.AddWithValue("@Troco",    decimal.TryParse(BoxTrocoPgto?.Text, out decimal tr) ? tr : 0);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Agendamento cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarAgendamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1?.CurrentRow == null) return;
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

            if (MessageBox.Show("Excluir este agendamento?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand("DELETE FROM Agendamentos WHERE Id = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                CarregarAgendamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir: " + ex.Message);
            }
        }

        private void CalcularTroco(object sender, EventArgs e)
        {
            if (decimal.TryParse(BoxValorTotalPgto?.Text, out decimal total) &&
                decimal.TryParse(BoxValorRecebidoPgto?.Text, out decimal recebido))
            {
                if (BoxTrocoPgto != null)
                    BoxTrocoPgto.Text = (recebido - total).ToString("F2");
            }
        }

        private void label6_Click(object sender, EventArgs e) { }
        private void BoxEspecialidadesProfissional_TextChanged(object sender, EventArgs e) { }
    }
}

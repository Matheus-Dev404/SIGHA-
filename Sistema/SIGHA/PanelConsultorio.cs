using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SIGHA.Models;
using SIGHA.Services;

namespace SIGHA
{
    public partial class PanelConsultorio : Form
    {
        // Dados do paciente recebidos pela fila de espera
        private string _pacienteCpf = "";
        private int    _recepcaoId  = 0;

        // ── Construtor padrão (abertura manual sem paciente) ─────────────────
        public PanelConsultorio()
        {
            InitializeComponent();
            SIGHA.Services.ThemeManager.ApplyTheme(this);
            RegistrarEventos();
        }

        // ── Construtor chamado ao acionar "Chamar Paciente" na fila de espera ─
        public PanelConsultorio(string cpf, int recepcaoId)
        {
            InitializeComponent();
            SIGHA.Services.ThemeManager.ApplyTheme(this);
            _pacienteCpf = cpf;
            _recepcaoId  = recepcaoId;
            RegistrarEventos();
            this.Load += (s, e) => CarregarDadosPaciente();
        }

        private void RegistrarEventos()
        {
            this.btnBuscarMedicacao?.Let(b => b.Click += BtnBuscarMedicacao_Click);
            this.btnSolicitar?.Let(b => b.Click += BtnSolicitar_Click);
            this.btnConcluirAtendimento?.Let(b => b.Click += BtnConcluirAtendimento_Click);
            this.btnGerarRelatorioAtendimentoConsultorio?.Let(b => b.Click += BtnGerarRelatorio_Click);
        }

        // ── Carregar dados do paciente no DataGrid ───────────────────────────
        private void CarregarDadosPaciente()
        {
            if (string.IsNullOrEmpty(_pacienteCpf)) return;
            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    string q = @"
                        SELECT p.Nome, p.Cpf, p.DataNascimento, p.Sexo, p.Telefone,
                               r.SintomasIniciais AS Sintomas,
                               t.CodigoManchester AS CorManchester,
                               t.Evolucao         AS AvaliacaoEnfermagem
                        FROM   Pacientes p
                        JOIN   Recepcoes r ON r.PacienteCpf = p.Cpf AND r.Id = @RecId
                        LEFT JOIN Triagens t ON t.RecepcaoId = r.Id
                        WHERE  p.Cpf = @Cpf";

                    using (var cmd = new MySqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@Cpf",   _pacienteCpf);
                        cmd.Parameters.AddWithValue("@RecId", _recepcaoId);
                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            var dt = new DataTable();
                            adapter.Fill(dt);
                            if (dataGridViewDadosPaciente != null)
                            {
                                dataGridViewDadosPaciente.DataSource = dt;
                                dataGridViewDadosPaciente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do paciente: " + ex.Message);
            }
        }

        // ── Buscar medicação no estoque ──────────────────────────────────────
        private void BtnBuscarMedicacao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BoxNomeMedicação?.Text))
            {
                MessageBox.Show("Digite o nome da medicação para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    string q = @"SELECT Id, NomeProduto, UnidadeMedida, QuantidadeEstoque
                                 FROM   Produtos
                                 WHERE  NomeProduto LIKE @Nome AND QuantidadeEstoque > 0
                                 ORDER  BY NomeProduto";
                    using (var cmd = new MySqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", "%" + BoxNomeMedicação.Text.Trim() + "%");
                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            var dt = new DataTable();
                            adapter.Fill(dt);
                            if (dataGridViewMedicacaoEmEstoque != null)
                            {
                                dataGridViewMedicacaoEmEstoque.DataSource = dt;
                                dataGridViewMedicacaoEmEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            }
                            if (dt.Rows.Count == 0)
                                MessageBox.Show("Nenhuma medicação encontrada no estoque com esse nome.", "Estoque", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar medicação: " + ex.Message);
            }
        }

        // ── Solicitar medicação (INSERT em RequisicoesEstoque) ───────────────
        private void BtnSolicitar_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedicacaoEmEstoque?.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma medicação na lista antes de solicitar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(BoxQuantidadeDesejada?.Text, out int qtd) || qtd <= 0)
            {
                MessageBox.Show("Informe uma quantidade válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int produtoId = Convert.ToInt32(dataGridViewMedicacaoEmEstoque.CurrentRow.Cells["Id"].Value);
            string nomeProd = dataGridViewMedicacaoEmEstoque.CurrentRow.Cells["NomeProduto"].Value?.ToString();

            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    string q = @"INSERT INTO RequisicoesEstoque
                                    (SetorSolicitante, ProdutoId, QuantidadeSolicitada, Justificativa)
                                 VALUES (@Setor, @ProdId, @Qtd, @Justif)";
                    using (var cmd = new MySqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@Setor",  "Consultório Médico");
                        cmd.Parameters.AddWithValue("@ProdId", produtoId);
                        cmd.Parameters.AddWithValue("@Qtd",    qtd);
                        cmd.Parameters.AddWithValue("@Justif", $"Prescrito durante consulta — Paciente CPF {_pacienteCpf}");
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show($"✅ Requisição de {qtd}x {nomeProd} enviada com sucesso!\nO farmacêutico receberá a solicitação.",
                                "Requisição", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BoxQuantidadeDesejada.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao solicitar: " + ex.Message);
            }
        }

        // ── Concluir Atendimento (INSERT prontuário + UPDATE status) ─────────
        private void BtnConcluirAtendimento_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_pacienteCpf))
            {
                MessageBox.Show("Nenhum paciente carregado neste consultório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string evolucao = BoxRelatorio?.Text ?? "";
            int medicoId = SessaoTracker.UsuarioLogado?.Id ?? 0;

            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();

                    // Buscar TriagemId vinculado à recepção
                    int triId = 0;
                    using (var cmd = new MySqlCommand("SELECT Id FROM Triagens WHERE RecepcaoId = @Rid LIMIT 1", conn))
                    {
                        cmd.Parameters.AddWithValue("@Rid", _recepcaoId);
                        var v = cmd.ExecuteScalar();
                        if (v != null) triId = Convert.ToInt32(v);
                    }

                    // Inserir prontuário
                    string qIns = @"INSERT INTO ConsultasProntuario
                                    (PacienteCpf, TriagemId, MedicoId, DetalhesConsulta)
                                    VALUES (@Cpf, @TriId, @MedId, @Det)";
                    using (var cmd = new MySqlCommand(qIns, conn))
                    {
                        cmd.Parameters.AddWithValue("@Cpf",   _pacienteCpf);
                        cmd.Parameters.AddWithValue("@TriId", triId == 0 ? (object)DBNull.Value : triId);
                        cmd.Parameters.AddWithValue("@MedId", medicoId);
                        cmd.Parameters.AddWithValue("@Det",   evolucao);
                        cmd.ExecuteNonQuery();
                    }

                    // Finalizar recepção
                    using (var cmd = new MySqlCommand("UPDATE Recepcoes SET StatusAtendimento='Finalizado' WHERE Id=@Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", _recepcaoId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("✅ Atendimento concluído com sucesso!\nProntuário salvo no histórico do paciente.",
                                "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpar formulário
                BoxRelatorio.Text = "";
                dataGridViewDadosPaciente.DataSource = null;
                dataGridViewMedicacaoEmEstoque.DataSource = null;
                _pacienteCpf = "";
                _recepcaoId  = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao concluir atendimento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Gerar relatório do atendimento em PDF ─────────────────────────────
        private void BtnGerarRelatorio_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF|*.pdf";
                sfd.FileName = $"Atendimento_{_pacienteCpf}_{DateTime.Now:yyyyMMdd_HHmm}.pdf";
                if (sfd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    var pdoc = new PrintDocument();
                    pdoc.PrinterSettings.PrinterName = "Microsoft Print to PDF";
                    pdoc.PrinterSettings.PrintToFile = true;
                    pdoc.PrinterSettings.PrintFileName = sfd.FileName;
                    pdoc.PrintPage += (s2, ev) =>
                    {
                        var g = ev.Graphics;
                        var fTit  = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
                        var fBody = new System.Drawing.Font("Segoe UI",  9, System.Drawing.FontStyle.Regular);
                        var teal  = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(0, 131, 143));
                        int y = 40;

                        // Cabeçalho
                        string clinica = "SIGHA";
                        try
                        {
                            using (var conn2 = DatabaseConfig.GetConnection())
                            {
                                conn2.Open();
                                var sc = new MySqlCommand("SELECT NomeClinica FROM ConfiguracoesClinica WHERE Id=1", conn2);
                                var r = sc.ExecuteScalar();
                                if (r != null) clinica = r.ToString();
                            }
                        }
                        catch { }

                        g.DrawString(clinica, fTit, teal, 50, y); y += 28;
                        g.DrawString("RELATÓRIO DE ATENDIMENTO MÉDICO", new System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold),
                                     System.Drawing.Brushes.Black, 50, y); y += 22;
                        g.DrawString($"Data: {DateTime.Now:dd/MM/yyyy HH:mm}   |   Paciente CPF: {_pacienteCpf}   |   Médico ID: {SessaoTracker.UsuarioLogado?.Id}",
                                     fBody, System.Drawing.Brushes.Gray, 50, y); y += 30;
                        g.DrawLine(System.Drawing.Pens.LightGray, 50, y, 780, y); y += 16;

                        g.DrawString("EVOLUÇÃO / DIAGNÓSTICO:", new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold),
                                     System.Drawing.Brushes.Black, 50, y); y += 20;
                        g.DrawString(BoxRelatorio?.Text ?? "(sem anotações)", fBody, System.Drawing.Brushes.Black, 50, y);
                    };

                    pdoc.Print();
                    MessageBox.Show("✅ Relatório gerado com sucesso!", "PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao gerar PDF: " + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
    }

    // Helper de extensão para null-safe event wiring
    internal static class ButtonExtensions
    {
        internal static void Let(this System.Windows.Forms.Button btn, Action<System.Windows.Forms.Button> action)
        {
            if (btn != null) action(btn);
        }
    }
}

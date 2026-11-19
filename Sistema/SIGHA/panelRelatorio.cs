using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SIGHA.Services;

namespace SIGHA
{
    public partial class panelRelatorio : Form
    {
        private DataTable dtAtendimentos = new DataTable();
        private DataTable dtEstoque = new DataTable();

        public panelRelatorio()
        {
            InitializeComponent();
            SIGHA.Services.ThemeManager.ApplyTheme(this);
            this.Load += PanelRelatorio_Load;

            if (this.btnImprimirRelatorio != null)
                this.btnImprimirRelatorio.Click += BtnImprimirRelatorio_Click;
        }

        private void PanelRelatorio_Load(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();

                    // ── Atendimentos realizados ──────────────────────────────────────
                    string queryAtend = @"
                        SELECT r.DataEntrada AS Data,
                               p.Nome        AS Paciente,
                               r.StatusAtendimento AS Status
                        FROM   Recepcoes r
                        JOIN   Pacientes p ON r.PacienteCpf = p.Cpf
                        ORDER  BY r.DataEntrada DESC
                        LIMIT  200";

                    using (var cmd = new MySqlCommand(queryAtend, conn))
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        dtAtendimentos.Clear();
                        adapter.Fill(dtAtendimentos);
                        if (dataGridViewAtendimentosRealizados != null)
                            dataGridViewAtendimentosRealizados.DataSource = dtAtendimentos;
                    }

                    // ── Consumo de estoque (saídas) ──────────────────────────────────
                    string queryEst = @"
                        SELECT m.DataMovimentacao AS Data,
                               p.NomeProduto      AS Produto,
                               m.Quantidade,
                               m.TipoMovimentacao AS Tipo
                        FROM   MovimentacaoEstoque m
                        JOIN   Produtos p ON m.ProdutoId = p.Id
                        WHERE  m.TipoMovimentacao = 'Saída'
                        ORDER  BY m.DataMovimentacao DESC
                        LIMIT  200";

                    using (var cmd = new MySqlCommand(queryEst, conn))
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        dtEstoque.Clear();
                        adapter.Fill(dtEstoque);
                        if (dataGridViewConsumoEstoque != null)
                            dataGridViewConsumoEstoque.DataSource = dtEstoque;
                    }
                }
            }
            catch (Exception ex)
            {
                // Mostrar aviso silencioso — dados podem ainda não existir
                if (dataGridViewAtendimentosRealizados != null)
                    dataGridViewAtendimentosRealizados.DataSource = null;
            }
        }

        // ── Geração de PDF ───────────────────────────────────────────────────────────
        private void BtnImprimirRelatorio_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF|*.pdf";
                sfd.FileName = "Relatorio_SIGHA_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";
                sfd.Title = "Salvar Relatório em PDF";

                if (sfd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    var pdoc = new PrintDocument();
                    pdoc.PrinterSettings.PrinterName = "Microsoft Print to PDF";
                    pdoc.PrinterSettings.PrintToFile = true;
                    pdoc.PrinterSettings.PrintFileName = sfd.FileName;
                    pdoc.DefaultPageSettings.Landscape = false;
                    pdoc.PrintPage += PrintDocument_PrintPage;

                    pdoc.Print();
                    MessageBox.Show("✅ Relatório PDF gerado!\n\n" + sfd.FileName, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Erro ao gerar PDF.\n\nVerifique se a impressora 'Microsoft Print to PDF' está disponível no Windows.\n\n" + ex.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            var g = e.Graphics;
            var fontTitulo  = new Font("Segoe UI", 18, FontStyle.Bold);
            var fontSecao   = new Font("Segoe UI", 12, FontStyle.Bold);
            var fontCorpo   = new Font("Segoe UI",  9, FontStyle.Regular);
            var fontRodape  = new Font("Segoe UI",  8, FontStyle.Italic);
            var brushPrim   = new SolidBrush(Color.FromArgb(0, 131, 143));   // teal
            var brushText   = Brushes.Black;
            var brushGray   = Brushes.Gray;

            int x = 50, y = 45, lh = 18;

            // Cabeçalho
            g.DrawString("SIGHA — Relatório Consolidado", fontTitulo, brushPrim, x, y);
            y += 28;
            g.DrawString("Gerado em: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), fontCorpo, brushGray, x, y);
            y += 14;
            g.DrawLine(new Pen(Color.LightGray, 1), x, y, 800, y);
            y += 16;

            // ─ Atendimentos ─
            g.DrawString("ATENDIMENTOS RECENTES", fontSecao, brushPrim, x, y);
            y += 22;
            g.DrawString($"{"Data",-22}{"Paciente",-30}{"Status"}", fontCorpo, brushText, x, y);
            y += lh;
            g.DrawLine(new Pen(Color.LightGray, 1), x, y, 800, y);
            y += 6;

            int limit = Math.Min(dtAtendimentos.Rows.Count, 20);
            for (int i = 0; i < limit; i++)
            {
                var row = dtAtendimentos.Rows[i];
                string linha = $"{Convert.ToDateTime(row["Data"]):dd/MM/yy HH:mm,-22}{row["Paciente"],-30}{row["Status"]}";
                g.DrawString(linha, fontCorpo, brushText, x, y);
                y += lh;
            }
            if (dtAtendimentos.Rows.Count == 0)
            {
                g.DrawString("(nenhum atendimento registrado)", fontCorpo, brushGray, x, y);
                y += lh;
            }

            y += 14;
            g.DrawLine(new Pen(Color.LightGray, 1), x, y, 800, y);
            y += 16;

            // ─ Consumo de Estoque ─
            g.DrawString("CONSUMO DE ESTOQUE (SAÍDAS)", fontSecao, brushPrim, x, y);
            y += 22;
            g.DrawString($"{"Data",-16}{"Produto",-36}{"Qtd"}", fontCorpo, brushText, x, y);
            y += lh;
            g.DrawLine(new Pen(Color.LightGray, 1), x, y, 800, y);
            y += 6;

            limit = Math.Min(dtEstoque.Rows.Count, 20);
            for (int i = 0; i < limit; i++)
            {
                var row = dtEstoque.Rows[i];
                string linha = $"{Convert.ToDateTime(row["Data"]):dd/MM/yy,-16}{row["Produto"],-36}{row["Quantidade"]}";
                g.DrawString(linha, fontCorpo, brushText, x, y);
                y += lh;
            }
            if (dtEstoque.Rows.Count == 0)
            {
                g.DrawString("(nenhuma movimentação registrada)", fontCorpo, brushGray, x, y);
                y += lh;
            }

            // Rodapé
            y = e.PageBounds.Height - 60;
            g.DrawLine(new Pen(Color.LightGray, 1), x, y, 800, y);
            y += 10;
            g.DrawString("SIGHA — Sistema Integrado de Gestão Hospitalar e Ambulatorial  |  Confidencial", fontRodape, brushGray, x, y);
        }

        private void label2_Click(object sender, EventArgs e) { }
        private void dataGridViewAtendimentosRealizados_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}

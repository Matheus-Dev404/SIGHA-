using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SIGHA.Services;

namespace SIGHA
{
    public partial class panelRequisicoes : Form
    {
        public panelRequisicoes()
        {
            InitializeComponent();
            SIGHA.Services.ThemeManager.ApplyTheme(this);
            this.Load += (s, e) => CarregarRequisicoes();

            if (this.btnAprovarRequisicao != null)
                this.btnAprovarRequisicao.Click += BtnAprovarRequisicao_Click;

            if (this.btnAtualizarLista != null)
                this.btnAtualizarLista.Click += (s, e) => CarregarRequisicoes();
        }

        private void CarregarRequisicoes()
        {
            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    string q = @"
                        SELECT r.Id            AS ID_Requisicao,
                               p.NomeProduto   AS Medicacao,
                               r.QuantidadeSolicitada AS Quantidade,
                               r.SetorSolicitante     AS Setor,
                               r.Status,
                               r.DataRequisicao AS Data,
                               r.Justificativa
                        FROM   RequisicoesEstoque r
                        JOIN   Produtos p ON r.ProdutoId = p.Id
                        ORDER  BY r.DataRequisicao DESC";

                    using (var cmd = new MySqlCommand(q, conn))
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        adapter.Fill(dt);
                        if (dataGridViewRequisicoes != null)
                        {
                            dataGridViewRequisicoes.DataSource = dt;
                            dataGridViewRequisicoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar requisições: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAprovarRequisicao_Click(object sender, EventArgs e)
        {
            // Tentar pegar ID da textBox, ou da linha selecionada no grid
            int reqId = 0;

            if (!string.IsNullOrWhiteSpace(BoxIdRequisicao?.Text))
            {
                if (!int.TryParse(BoxIdRequisicao.Text.Trim(), out reqId) || reqId <= 0)
                {
                    MessageBox.Show("Informe um ID de requisição válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (dataGridViewRequisicoes?.CurrentRow != null)
            {
                reqId = Convert.ToInt32(dataGridViewRequisicoes.CurrentRow.Cells["ID_Requisicao"].Value);
            }
            else
            {
                MessageBox.Show("Selecione uma requisição ou informe o ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int prodId = 0; int qtd = 0; string status = ""; string nomeProd = "";
            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();

                    // Verificar se existe e pegar dados
                    string qCheck = @"SELECT r.ProdutoId, r.QuantidadeSolicitada, r.Status, p.NomeProduto, p.QuantidadeEstoque
                                      FROM RequisicoesEstoque r JOIN Produtos p ON r.ProdutoId = p.Id
                                      WHERE r.Id = @Id";
                    using (var cmd = new MySqlCommand(qCheck, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", reqId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show($"Requisição ID {reqId} não encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            prodId   = Convert.ToInt32(reader["ProdutoId"]);
                            qtd      = Convert.ToInt32(reader["QuantidadeSolicitada"]);
                            status   = reader["Status"].ToString();
                            nomeProd = reader["NomeProduto"].ToString();
                            int estoqueAtual = Convert.ToInt32(reader["QuantidadeEstoque"]);

                            if (estoqueAtual < qtd)
                            {
                                MessageBox.Show($"⚠️ Estoque insuficiente!\n{nomeProd}: {estoqueAtual} disponíveis, solicitado: {qtd}",
                                                "Estoque", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }

                    if (status == "Aprovada")
                    {
                        MessageBox.Show("Esta requisição já foi aprovada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Aprovar requisição
                    using (var cmd = new MySqlCommand("UPDATE RequisicoesEstoque SET Status='Aprovada', DataResposta=NOW() WHERE Id=@Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", reqId);
                        cmd.ExecuteNonQuery();
                    }

                    // Registrar saída no estoque (a trigger atualiza QuantidadeEstoque automaticamente)
                    using (var cmd = new MySqlCommand(@"INSERT INTO MovimentacaoEstoque
                                                        (ProdutoId, TipoMovimentacao, Quantidade, Observacao, UsuarioResponsavelId)
                                                        VALUES (@PId, 'Saída', @Qtd, @Obs, @Usr)", conn))
                    {
                        cmd.Parameters.AddWithValue("@PId", prodId);
                        cmd.Parameters.AddWithValue("@Qtd", qtd);
                        cmd.Parameters.AddWithValue("@Obs", $"Saída por aprovação de requisição #{reqId}");
                        cmd.Parameters.AddWithValue("@Usr", (object)SIGHA.Models.SessaoTracker.UsuarioLogado?.Id ?? DBNull.Value);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"✅ Requisição #{reqId} aprovada!\n{qtd}x {nomeProd} baixado do estoque.",
                                "Aprovado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (BoxIdRequisicao != null) BoxIdRequisicao.Text = "";
                CarregarRequisicoes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao aprovar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

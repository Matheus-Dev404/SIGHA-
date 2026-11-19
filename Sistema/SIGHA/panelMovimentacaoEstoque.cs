using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SIGHA.Services;

namespace SIGHA
{
    public partial class panelMovimentacaoEstoque : Form
    {
        public panelMovimentacaoEstoque()
        {
            InitializeComponent();
            SIGHA.Services.ThemeManager.ApplyTheme(this);
            this.Load += (s, e) => CarregarMovimentacoes();
            if (this.btnAtualizar != null) this.btnAtualizar.Click += (s, e) => CarregarMovimentacoes();
        }

        private void CarregarMovimentacoes()
        {
            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();

                    string qEntrada = @"SELECT m.DataMovimentacao AS Data, p.NomeProduto AS Produto,
                                               m.Quantidade, u.NomeCompleto AS Responsavel
                                        FROM   MovimentacaoEstoque m
                                        JOIN   Produtos p ON m.ProdutoId = p.Id
                                        LEFT   JOIN Usuarios u ON m.UsuarioResponsavelId = u.Id
                                        WHERE  m.TipoMovimentacao = 'Entrada'
                                        ORDER  BY m.DataMovimentacao DESC LIMIT 100";

                    using (var cmd = new MySqlCommand(qEntrada, conn))
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        adapter.Fill(dt);
                        if (dataGridViewEntradaProdutos != null)
                        {
                            dataGridViewEntradaProdutos.DataSource = dt;
                            dataGridViewEntradaProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }

                    string qSaida = @"SELECT m.DataMovimentacao AS Data, p.NomeProduto AS Produto,
                                             m.Quantidade, u.NomeCompleto AS Responsavel
                                      FROM   MovimentacaoEstoque m
                                      JOIN   Produtos p ON m.ProdutoId = p.Id
                                      LEFT   JOIN Usuarios u ON m.UsuarioResponsavelId = u.Id
                                      WHERE  m.TipoMovimentacao = 'Saída'
                                      ORDER  BY m.DataMovimentacao DESC LIMIT 100";

                    using (var cmd = new MySqlCommand(qSaida, conn))
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        adapter.Fill(dt);
                        if (dataGridViewSaidaProdutos != null)
                        {
                            dataGridViewSaidaProdutos.DataSource = dt;
                            dataGridViewSaidaProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar movimentações: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SIGHA.Services;

namespace SIGHA
{
    public partial class panelCadastrarProduto : Form
    {
        public panelCadastrarProduto()
        {
            InitializeComponent();
            SIGHA.Services.ThemeManager.ApplyTheme(this);
            this.btnCadastrar.Click += BtnCadastrar_Click;
            this.btnVisualizarProduto.Click += BtnVisualizarProduto_Click;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BoxNomeProduto.Text) || string.IsNullOrWhiteSpace(BoxQuantidade.Text))
            {
                MessageBox.Show("Preencha o Nome e Quantidade do Produto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Produtos (NomeProduto, UnidadeMedida, QuantidadeEstoque) VALUES (@Nome, @Unidade, @Qtd)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", BoxNomeProduto.Text);
                        cmd.Parameters.AddWithValue("@Unidade", BoxUnidadeMedida.Text);
                        cmd.Parameters.AddWithValue("@Qtd", int.TryParse(BoxQuantidade.Text, out int qtd) ? qtd : 0);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnVisualizarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Produtos";
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
                MessageBox.Show("Erro ao buscar produtos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

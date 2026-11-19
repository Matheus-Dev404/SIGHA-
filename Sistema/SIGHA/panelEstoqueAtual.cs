using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SIGHA.Services;

namespace SIGHA
{
    public partial class panelEstoqueAtual : Form
    {
        public panelEstoqueAtual()
        {
            InitializeComponent();
            SIGHA.Services.ThemeManager.ApplyTheme(this);
            this.Load += (s, e) => CarregarEstoque();
            if (this.btnAtualizar != null) this.btnAtualizar.Click += (s, e) => CarregarEstoque();
        }

        private void CarregarEstoque()
        {
            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT Id, NomeProduto, UnidadeMedida, QuantidadeEstoque, DataCadastro FROM Produtos ORDER BY NomeProduto";
                    using (var cmd = new MySqlCommand(query, conn))
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
                MessageBox.Show("Erro ao carregar estoque: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

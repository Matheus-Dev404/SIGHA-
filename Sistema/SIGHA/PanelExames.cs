using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SIGHA.Models;
using SIGHA.Services;

namespace SIGHA
{
    public partial class PanelExames : Form
    {
        public PanelExames()
        {
            InitializeComponent();
            SIGHA.Services.ThemeManager.ApplyTheme(this);
            this.Load += PanelExames_Load;

            if (this.btnSolicitarExame != null)
                this.btnSolicitarExame.Click += BtnSolicitarExame_Click;
            if (this.btnAtualizarLista != null)
                this.btnAtualizarLista.Click += (s, e) => CarregarExames();
        }

        private void PanelExames_Load(object sender, EventArgs e) => CarregarExames();

        private void CarregarExames()
        {
            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    string q = @"
                        SELECT e.Id, e.DataSolicitacao AS Data,
                               p.Nome     AS Paciente,
                               p.Cpf,
                               e.DescricaoExame AS Exame,
                               e.Status
                        FROM   Exames e
                        JOIN   Pacientes p ON e.PacienteCpf = p.Cpf
                        ORDER  BY e.DataSolicitacao DESC
                        LIMIT 200";

                    using (var cmd = new MySqlCommand(q, conn))
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        adapter.Fill(dt);
                        if (DataGridViewPacientesSolicitarExame != null)
                        {
                            DataGridViewPacientesSolicitarExame.DataSource = dt;
                            DataGridViewPacientesSolicitarExame.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }
                }
            }
            catch { /* silencioso se banco vazio */ }
        }

        private void BtnSolicitarExame_Click(object sender, EventArgs e)
        {
            if (clbExames == null || clbExames.CheckedItems.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos um exame da lista.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int medicoId = SessaoTracker.UsuarioLogado?.Id ?? 0;
            if (medicoId == 0)
            {
                MessageBox.Show("Sessão de médico não identificada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string cpf = BoxNomePacienteSolicitarExame?.Text.Trim() ?? "";
            if (string.IsNullOrWhiteSpace(cpf))
            {
                MessageBox.Show("Informe o CPF do paciente no campo acima.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();

                    // Verificar se paciente existe
                    using (var check = new MySqlCommand("SELECT Id FROM Pacientes WHERE Cpf=@Cpf", conn))
                    {
                        check.Parameters.AddWithValue("@Cpf", cpf);
                        if (check.ExecuteScalar() == null)
                        {
                            MessageBox.Show("Paciente não encontrado. Verifique o CPF.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    foreach (object item in clbExames.CheckedItems)
                    {
                        string ins = "INSERT INTO Exames (PacienteCpf, MedicoId, DescricaoExame) VALUES (@Cpf, @Med, @Desc)";
                        using (var cmd = new MySqlCommand(ins, conn))
                        {
                            cmd.Parameters.AddWithValue("@Cpf",  cpf);
                            cmd.Parameters.AddWithValue("@Med",  medicoId);
                            cmd.Parameters.AddWithValue("@Desc", item.ToString());
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show($"✅ {clbExames.CheckedItems.Count} exame(s) solicitado(s) com sucesso!", "Exames", MessageBoxButtons.OK, MessageBoxIcon.Information);

                for (int i = 0; i < clbExames.Items.Count; i++)
                    clbExames.SetItemChecked(i, false);

                CarregarExames();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao solicitar exames: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SIGHA.Models;
using SIGHA.Services;

namespace SIGHA
{
    public partial class PanelFilaEspera : Form
    {
        public PanelFilaEspera()
        {
            InitializeComponent();
            SIGHA.Services.ThemeManager.ApplyTheme(this);
            this.Load += (s, e) => CarregarFila();

            if (this.btnChamarPaciente != null)
                this.btnChamarPaciente.Click += BtnChamarPaciente_Click;

            if (this.btnAtualizarLista != null)
                this.btnAtualizarLista.Click += (s, e) => CarregarFila();
        }

        private void CarregarFila()
        {
            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        SELECT r.Id,
                               p.Nome          AS Paciente,
                               p.Cpf,
                               r.SintomasIniciais AS Sintomas,
                               r.StatusAtendimento AS Status,
                               r.DataEntrada   AS Entrada
                        FROM   Recepcoes r
                        JOIN   Pacientes p ON r.PacienteCpf = p.Cpf
                        WHERE  r.StatusAtendimento IN ('Aguardando Medico','Em Triagem')
                        ORDER  BY r.DataEntrada ASC";

                    using (var cmd = new MySqlCommand(query, conn))
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        adapter.Fill(dt);
                        if (DataGridViewFilaDeEspera != null)
                        {
                            DataGridViewFilaDeEspera.DataSource = dt;
                            DataGridViewFilaDeEspera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar fila: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnChamarPaciente_Click(object sender, EventArgs e)
        {
            if (DataGridViewFilaDeEspera == null || DataGridViewFilaDeEspera.Rows.Count == 0)
            {
                MessageBox.Show("A fila de espera está vazia.", "Fila", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Pegar primeira linha da fila
            var row = DataGridViewFilaDeEspera.Rows[0];
            int recId  = Convert.ToInt32(row.Cells["Id"].Value);
            string nome = row.Cells["Paciente"].Value?.ToString() ?? "—";
            string cpf  = row.Cells["Cpf"].Value?.ToString() ?? "";

            // Mostrar nome no campo informativo
            if (BoxNomePacienteASerChamado != null)
                BoxNomePacienteASerChamado.Text = nome;

            // Atualizar status para Em Atendimento
            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    string upd = "UPDATE Recepcoes SET StatusAtendimento = 'Em Atendimento' WHERE Id = @Id";
                    using (var cmd = new MySqlCommand(upd, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", recId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"🔔 Chamando: {nome}\n\nO consultório será aberto com os dados do paciente.",
                                "Próximo Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir PanelConsultorio passando os dados do paciente
                var consultorio = new PanelConsultorio(cpf, recId);

                // Tentar inserir no panel do MenuMedico (form pai)
                Form pai = FindMenuMedico();
                if (pai is MenuMedico menu)
                {
                    menu.AbrirConsultorio(consultorio);
                }
                else
                {
                    consultorio.Show();
                }

                CarregarFila();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao chamar paciente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Form FindMenuMedico()
        {
            foreach (Form f in Application.OpenForms)
                if (f is MenuMedico) return f;
            return null;
        }

        private void label1_Click(object sender, EventArgs e) { }
    }
}

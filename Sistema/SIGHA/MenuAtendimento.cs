using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SIGHA
{
    public partial class MenuAtendimento : Form
    {
        public MenuAtendimento()
        {
            InitializeComponent();
            SIGHA.Services.ThemeManager.ApplyTheme(this);

        }
        private Form formAtivo = null;
        private void AbrirFormNoPainel(Form formFilho)
        {
            if (formAtivo != null)
                formAtivo.Close();

            formAtivo = formFilho;
            formFilho.TopLevel = false;
            formFilho.FormBorderStyle = FormBorderStyle.None;
            formFilho.Dock = DockStyle.Fill;
            panelConteudo.Controls.Clear();
            panelConteudo.Controls.Add(formFilho);
            formFilho.Show();

        }


        private Escolha_Modulos telaAnterior;
        public MenuAtendimento(Escolha_Modulos tela)
        {
            InitializeComponent();
            SIGHA.Services.ThemeManager.ApplyTheme(this);
            telaAnterior = tela;
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            if (telaAnterior != null)
            {
                telaAnterior.Show();
            }
        }
        private void MenuAtendimento_Load(object sender, EventArgs e)
        {
            CarregarFilaELeitos();
        }

        private void CarregarFilaELeitos()
        {
            try
            {
                // Carregar Pacientes Aguardando
                using (var conn = SIGHA.Services.DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    string queryFila = @"SELECT p.Nome, r.StatusAtendimento AS Status, r.DataEntrada 
                                         FROM Recepcoes r 
                                         JOIN Pacientes p ON r.PacienteCpf = p.Cpf 
                                         WHERE r.StatusAtendimento != 'Finalizado' 
                                         ORDER BY r.DataEntrada ASC";
                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(queryFila, conn))
                    {
                        using (var adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd))
                        {
                            DataTable dtFila = new DataTable();
                            adapter.Fill(dtFila);
                            if (dataGridView2 != null) dataGridView2.DataSource = dtFila;
                        }
                    }
                }

                // Gerar Tabela Dinâmica de Leitos (24 Fixos)
                if (dataGridView1 != null)
                {
                    DataTable dtLeitos = new DataTable();
                    dtLeitos.Columns.Add("Leito", typeof(string));
                    dtLeitos.Columns.Add("Status", typeof(string));
                    
                    for (int i = 1; i <= 24; i++)
                    {
                        // Exemplo visual: Primeiros 3 ocupados, resto livre.
                        string status = (i <= 3) ? "Ocupado" : "Disponível";
                        dtLeitos.Rows.Add($"Leito {i:00}", status);
                    }
                    dataGridView1.DataSource = dtLeitos;
                }
            }
            catch (Exception ex)
            {
                // Ignorar em caso de form designer ou db off
            }
        }

        private void MenuAtendimento_Load_1(object sender, EventArgs e)
        {
            CarregarFilaELeitos();
        }

        private void btnCadastroPacientes_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new PanelCadastroPacientes());
        }

        private void btnAgendamentoConsultas_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new AgendamentoConsulta());
        }

        private void btnRecepcao_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new Recepcao());
        }

        private void btnEncaminhamento_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new Triagem());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (telaAnterior != null)
            {
                {
                    telaAnterior.Show();
                }
                this.Close();
            }
        }

        private void btnConsultaStatus_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SIGHA.Services;

namespace SIGHA
{
    public partial class panelConfiguracoes : Form
    {
        public panelConfiguracoes()
        {
            InitializeComponent();
            SIGHA.Services.ThemeManager.ApplyTheme(this);
            this.Load += PanelConfiguracoes_Load;

            if (this.btnAlterarDadosClinica != null)
                this.btnAlterarDadosClinica.Click += BtnAlterarDadosClinica_Click;

            if (this.btnExportarBackupDb != null)
                this.btnExportarBackupDb.Click += BtnExportarBackupDb_Click;

            if (this.btnSalvarCor != null)
                this.btnSalvarCor.Click += BtnSalvarCor_Click;
        }

        private void PanelConfiguracoes_Load(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    string q = "SELECT NomeClinica, Cnpj, TelefoneContato, CorTema FROM ConfiguracoesClinica WHERE Id = 1";
                    using (var cmd = new MySqlCommand(q, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (BoxNomeClinica     != null) BoxNomeClinica.Text     = reader["NomeClinica"].ToString();
                            if (BoxCNPJ            != null) BoxCNPJ.Text            = reader["Cnpj"].ToString();
                            if (BoxTelefoneContato != null) BoxTelefoneContato.Text = reader["TelefoneContato"].ToString();
                            
                            string cor = reader["CorTema"].ToString();
                            if (comboBox1 != null && !string.IsNullOrEmpty(cor))
                            {
                                int idx = comboBox1.FindStringExact(cor);
                                if (idx != -1) comboBox1.SelectedIndex = idx;
                            }
                        }
                    }
                }
            }
            catch { /* silencioso */ }
        }

        private void BtnAlterarDadosClinica_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    string q = @"UPDATE ConfiguracoesClinica
                                 SET NomeClinica = @Nome, Cnpj = @Cnpj, TelefoneContato = @Tel
                                 WHERE Id = 1";
                    using (var cmd = new MySqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", BoxNomeClinica?.Text     ?? "");
                        cmd.Parameters.AddWithValue("@Cnpj", BoxCNPJ?.Text            ?? "");
                        cmd.Parameters.AddWithValue("@Tel",  BoxTelefoneContato?.Text ?? "");
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("✅ Dados da clínica salvos com sucesso!", "Configurações", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSalvarCor_Click(object sender, EventArgs e)
        {
            string corSelecionada = comboBox1?.SelectedItem?.ToString() ?? "";
            Color novaCor = corSelecionada switch
            {
                "Azul"      => Color.FromArgb(25, 118, 210),
                "Vermelho"  => Color.FromArgb(183, 28, 28),
                "Verde"     => Color.FromArgb(27, 94, 32),
                "Roxo"      => Color.FromArgb(106, 27, 154),
                "Rosa"      => Color.FromArgb(194, 24, 91),
                "Branco"    => Color.FromArgb(38, 50, 56),   // Cinza escuro "neutro"
                _           => Color.FromArgb(0, 131, 143),  // Teal padrão
            };

            ThemeManager.PrimaryColor = novaCor;

            // Salvar no Banco
            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand("UPDATE ConfiguracoesClinica SET CorTema=@Cor WHERE Id=1", conn))
                    {
                        cmd.Parameters.AddWithValue("@Cor", corSelecionada);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch { /* Silencioso se falhar persistência */ }

            // Re-aplicar em todos os forms abertos
            foreach (Form f in Application.OpenForms)
                ThemeManager.ApplyTheme(f);

            MessageBox.Show($"✅ Cor do sistema alterada para: {corSelecionada}!\nEsta preferência foi salva e será aplicada em todos os módulos.",
                            "Tema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnExportarBackupDb_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter   = "Arquivo SQL|*.sql";
                sfd.FileName = "backup_sigha_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".sql";
                sfd.Title    = "Salvar Backup do Banco de Dados";

                if (sfd.ShowDialog() != DialogResult.OK) return;

                string dumpPath = @"C:\xampp\mysql\bin\mysqldump.exe";
                if (!File.Exists(dumpPath))
                {
                    MessageBox.Show($"mysqldump.exe não encontrado em:\n{dumpPath}\n\nVerifique se o XAMPP está instalado corretamente.",
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    string args = $"-u root -h 127.0.0.1 -P 3307 --databases sigha_db --result-file=\"{sfd.FileName}\"";
                    var psi = new ProcessStartInfo
                    {
                        FileName       = dumpPath,
                        Arguments      = args,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    using (var proc = Process.Start(psi))
                    {
                        proc.WaitForExit();
                        if (proc.ExitCode == 0)
                            MessageBox.Show("✅ Backup gerado com sucesso!\n\n" + sfd.FileName, "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("❌ Falha ao criar backup. Verifique se o MySQL está rodando na porta 3307.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao executar backup: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e) { }
    }
}

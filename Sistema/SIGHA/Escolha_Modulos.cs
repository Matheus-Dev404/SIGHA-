using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace SIGHA
{
    public partial class Escolha_Modulos : Form
    {
        private Tela_Login loginForm;
        private Form formAtivo = null;
        private bool saindoParaLogin = false;

        public Escolha_Modulos(Tela_Login login)
        {
            InitializeComponent();
            SIGHA.Services.ThemeManager.ApplyTheme(this);
            loginForm = login;
            ConfigurarPermissoes();
        }
        public Escolha_Modulos()
        {
            InitializeComponent();
            SIGHA.Services.ThemeManager.ApplyTheme(this);
            ConfigurarPermissoes();
        }

        private void ConfigurarPermissoes()
        {
            if (SIGHA.Models.SessaoTracker.UsuarioLogado == null) return;
        
            btnAtendimento.Enabled = false;
            btnSistemaMedico.Enabled = false;
            btnEstoqueFarmacia.Enabled = false;
            btnAdministrativo.Enabled = false;
            btnRelatorios.Enabled = false;

            if (SIGHA.Models.SessaoTracker.IsAdmin)
            {
                btnAtendimento.Enabled = true;
                btnSistemaMedico.Enabled = true;
                btnEstoqueFarmacia.Enabled = true;
                btnAdministrativo.Enabled = true;
                btnRelatorios.Enabled = true;
            }
            else if (SIGHA.Models.SessaoTracker.IsMedico)
            {
                btnSistemaMedico.Enabled = true;
                btnRelatorios.Enabled = true;
            }
            else if (SIGHA.Models.SessaoTracker.IsEnfermeiro)
            {
                btnAtendimento.Enabled = true;
                btnSistemaMedico.Enabled = true;
                btnEstoqueFarmacia.Enabled = true;
            }
            else if (SIGHA.Models.SessaoTracker.IsAtendente)
            {
                btnAtendimento.Enabled = true;
            }
        }

        private void btnAtendimento_Click(object sender, EventArgs e)
        {
            MenuAtendimento tela = new MenuAtendimento(this);
            tela.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                    "Deseja realmente sair do sistema?",
                    "ConfirmaÃ§Ã£o",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (resultado == DialogResult.Yes)
            {
                loginForm.LimparCamposLogin();
                loginForm.Show();
                this.Close();
            }
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void btnSistemaMedico_Click(object sender, EventArgs e)
        {
            MenuMedico tela = new MenuMedico();
            tela.Show();
            this.Hide();
        }

        private void btnEstoqueFarmacia_Click(object sender, EventArgs e)
        {
            MenuEstoque_e_Farmacia tela = new MenuEstoque_e_Farmacia();
            tela.Show();
            this.Hide();
        }

        private void btnAdministrativo_Click(object sender, EventArgs e)
        {
            MenuAdmnistrativo tela = new MenuAdmnistrativo(this);
            tela.Show();
            this.Hide();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            MenuRelatorios tela = new MenuRelatorios(this);
            tela.Show();
            this.Hide();
        }
    }
}

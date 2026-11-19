using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SIGHA
{
    public partial class MenuEstoque_e_Farmacia : Form
    {
        public MenuEstoque_e_Farmacia()
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
        public MenuEstoque_e_Farmacia(Escolha_Modulos tela)
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Escolha_Modulos menu = new Escolha_Modulos();
            menu.Show();
            this.Close();
        }

        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new panelCadastrarProduto());
        }

        private void btnRequisicoes_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new panelRequisicoes());
        }

        private void btnMovimentacoes_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new panelMovimentacaoEstoque());
        }

        private void btnEstoqueAtual_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new panelEstoqueAtual());
        }
    }
}

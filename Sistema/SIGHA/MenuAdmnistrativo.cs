using System;
using System.Drawing;
using System.Windows.Forms;

namespace SIGHA
{
    public partial class MenuAdmnistrativo : Form
    {
        private Form formAtivo = null;
        private Escolha_Modulos telaAnterior;

        public MenuAdmnistrativo(Escolha_Modulos tela)
        {
            InitializeComponent();
            SIGHA.Services.ThemeManager.ApplyTheme(this);
            telaAnterior = tela;
            this.Load += MenuAdmnistrativo_Load;
        }

        private void MenuAdmnistrativo_Load(object sender, EventArgs e)
        {
            // Adicionar dinamicamente o botão Configurações na mesma sidebar (panel1)
            var btnConfig = new Button
            {
                Text = "Configurações",
                Location = new Point(0, btnCadastroUsuario.Bottom + 8),
                Size = new Size(103, 37),
                Name = "btnConfiguracoes",
                Cursor = Cursors.Hand,
                UseVisualStyleBackColor = true
            };
            btnConfig.Click += (s, ev) => AbrirFormNoPainel(new panelConfiguracoes());
            panel1.Controls.Add(btnConfig);
            SIGHA.Services.ThemeManager.ApplyTheme(btnConfig);

            // Abrir painel de usuários por padrão
            AbrirFormNoPainel(new panelCadastroUsuario());
        }

        private void AbrirFormNoPainel(Form formFilho)
        {
            if (formAtivo != null)
            {
                formAtivo.Close();
                formAtivo = null;
            }

            formAtivo = formFilho;
            formFilho.TopLevel = false;
            formFilho.FormBorderStyle = FormBorderStyle.None;
            formFilho.Dock = DockStyle.Fill;
            panelConteudo.Controls.Clear();
            panelConteudo.Controls.Add(formFilho);
            formFilho.Show();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            telaAnterior?.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            telaAnterior?.Show();
            this.Close();
        }

        private void btnCadastroUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel(new panelCadastroUsuario());
        }
    }
}

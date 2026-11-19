using System;
using System.Windows.Forms;

namespace SIGHA
{
    public partial class MenuRelatorios : Form
    {
        private Form telaAnterior;

        public MenuRelatorios(Form anterior)
        {
            InitializeComponent();
            SIGHA.Services.ThemeManager.ApplyTheme(this);
            this.telaAnterior = anterior;

            // panel3 será o conteudo — abrimos panelRelatorio dentro dele
            this.btnRelatorios.Click += BtnRelatorios_Click;
        }

        private Form formAtivo = null;

        private void AbrirNoPainel(Form formFilho)
        {
            formAtivo?.Close();
            formAtivo = formFilho;
            formFilho.TopLevel = false;
            formFilho.FormBorderStyle = FormBorderStyle.None;
            formFilho.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(formFilho);
            formFilho.Show();
        }

        private void BtnRelatorios_Click(object sender, EventArgs e)
        {
            AbrirNoPainel(new panelRelatorio());
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            telaAnterior?.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Escolha_Modulos menu = new Escolha_Modulos();
            menu.Show();
            this.Close();
        }
    }
}

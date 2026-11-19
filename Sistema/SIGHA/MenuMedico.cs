using System;
using System.Windows.Forms;

namespace SIGHA
{
    public partial class MenuMedico : Form
    {
        public MenuMedico()
        {
            InitializeComponent();
            SIGHA.Services.ThemeManager.ApplyTheme(this);
        }

        private void AbrirFormNoPainel(Form formFilho)
        {
            if (this.panel4.Controls.Count > 0)
                this.panel4.Controls.Clear();

            formFilho.TopLevel = false;
            formFilho.FormBorderStyle = FormBorderStyle.None;
            formFilho.Dock = DockStyle.Fill;
            this.panel4.Controls.Add(formFilho);
            this.panel4.Tag = formFilho;
            formFilho.Show();
        }

        public void AbrirConsultorio(PanelConsultorio consultorio)
        {
            AbrirFormNoPainel(consultorio);
        }

        // Eventos de Clique
        private void btnFilaEspera_Click(object sender, EventArgs e) => AbrirFormNoPainel(new PanelFilaEspera());
        private void btnConsultorio_Click(object sender, EventArgs e) => AbrirFormNoPainel(new PanelConsultorio());
        private void btnExames_Click(object sender, EventArgs e) => AbrirFormNoPainel(new PanelExames());
        private void btnHistoricoPaciente_Click(object sender, EventArgs e) => AbrirFormNoPainel(new PanelHistoricoPaciente());

        private void btnSair_Click(object sender, EventArgs e)
        {
            Escolha_Modulos menu = new Escolha_Modulos();
            menu.Show();
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

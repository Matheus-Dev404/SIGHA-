using System;
using System.Drawing;
using System.Windows.Forms;
using SIGHA.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SIGHA
{
	public partial class Tela_Login : Form
	{
		public Tela_Login()
		{
			InitializeComponent();
            SIGHA.Services.ThemeManager.ApplyTheme(this);
			btnLogin.BackColor = Color.Red;
			btnLogin.ForeColor = Color.White;
			btnLogin.Visible = true;
			btnLogin.BringToFront();
		}
		public void LimparCamposLogin()
		{
			Box_Usuario.Text = "";
			Box_Senha.Text = "";
			Box_Usuario.Focus();
		}
		private void btnLogin_MouseEnter(object sender, EventArgs e)
		{
			btnLogin.BackColor = Color.FromArgb(0, 150, 120);
		}

		private void btnLogin_MouseLeave(object sender, EventArgs e)
		{
			btnLogin.BackColor = Color.FromArgb(0, 180, 140);
		}
		private void btnLogin_Click(object sender, EventArgs e)
		{
			string userDigitado = Box_Usuario.Text;
			string senhaDigitado = Box_Senha.Text;

			if (string.IsNullOrWhiteSpace(userDigitado) || string.IsNullOrWhiteSpace(senhaDigitado))
			{
				MessageBox.Show("Por favor, preencha o usuÃ¡rio e a senha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (AuthService.Autenticar(userDigitado, senhaDigitado))
			{
				Escolha_Modulos menuescolha = new Escolha_Modulos(this);
				menuescolha.Show();
				this.Hide();
			}
			else
			{
				// Trata o caso em que a autenticaÃ§Ã£o falha e o serviÃ§o jÃ¡ pode ter exibido erro de banco.
				// Se nÃ£o foi erro de banco, Ã© sÃ³ usuÃ¡rio invÃ¡lido.
				if (SIGHA.Models.SessaoTracker.UsuarioLogado == null)
				{
				    // Apenas exibir se nÃ£o for um problema de conexÃ£o (que jÃ¡ tratou com messagebox no AuthService).
				}
			}
		}
	}
}

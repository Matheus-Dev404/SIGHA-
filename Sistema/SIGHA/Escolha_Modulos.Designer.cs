namespace SIGHA
{
	partial class Escolha_Modulos
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for para descartar recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Escolha_Modulos));
            btnAtendimento = new Button();
            btnSistemaMedico = new Button();
            btnEstoqueFarmacia = new Button();
            btnRelatorios = new Button();
            btnAdministrativo = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // btnAtendimento
            // 
            btnAtendimento.BackColor = Color.Transparent;
            btnAtendimento.FlatStyle = FlatStyle.Flat;
            btnAtendimento.Location = new Point(745, 153);
            btnAtendimento.Margin = new Padding(3, 4, 3, 4);
            btnAtendimento.Name = "btnAtendimento";
            btnAtendimento.Size = new Size(152, 77);
            btnAtendimento.TabIndex = 0;
            btnAtendimento.Text = "ATENDIMENTO";
            btnAtendimento.UseVisualStyleBackColor = false;
            btnAtendimento.Click += btnAtendimento_Click;
            // 
            // btnSistemaMedico
            // 
            btnSistemaMedico.BackColor = Color.Transparent;
            btnSistemaMedico.FlatStyle = FlatStyle.Flat;
            btnSistemaMedico.Location = new Point(950, 153);
            btnSistemaMedico.Margin = new Padding(3, 4, 3, 4);
            btnSistemaMedico.Name = "btnSistemaMedico";
            btnSistemaMedico.Size = new Size(152, 77);
            btnSistemaMedico.TabIndex = 1;
            btnSistemaMedico.Text = "SISTEMA MÉDICO";
            btnSistemaMedico.UseVisualStyleBackColor = false;
            btnSistemaMedico.Click += btnSistemaMedico_Click;
            // 
            // btnEstoqueFarmacia
            // 
            btnEstoqueFarmacia.BackColor = Color.Transparent;
            btnEstoqueFarmacia.FlatStyle = FlatStyle.Flat;
            btnEstoqueFarmacia.Location = new Point(745, 250);
            btnEstoqueFarmacia.Margin = new Padding(3, 4, 3, 4);
            btnEstoqueFarmacia.Name = "btnEstoqueFarmacia";
            btnEstoqueFarmacia.Size = new Size(152, 77);
            btnEstoqueFarmacia.TabIndex = 3;
            btnEstoqueFarmacia.Text = "ESTOQUE E FARMÁCIA";
            btnEstoqueFarmacia.UseVisualStyleBackColor = false;
            btnEstoqueFarmacia.Click += btnEstoqueFarmacia_Click;
            // 
            // btnRelatorios
            // 
            btnRelatorios.BackColor = Color.Transparent;
            btnRelatorios.FlatStyle = FlatStyle.Flat;
            btnRelatorios.Location = new Point(745, 346);
            btnRelatorios.Margin = new Padding(3, 4, 3, 4);
            btnRelatorios.Name = "btnRelatorios";
            btnRelatorios.Size = new Size(152, 77);
            btnRelatorios.TabIndex = 8;
            btnRelatorios.Text = "RELATÓRIOS E INDICADORES";
            btnRelatorios.UseVisualStyleBackColor = false;
            btnRelatorios.Click += btnRelatorios_Click;
            // 
            // btnAdministrativo
            // 
            btnAdministrativo.BackColor = Color.Transparent;
            btnAdministrativo.FlatStyle = FlatStyle.Flat;
            btnAdministrativo.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdministrativo.Location = new Point(950, 250);
            btnAdministrativo.Margin = new Padding(3, 4, 3, 4);
            btnAdministrativo.Name = "btnAdministrativo";
            btnAdministrativo.Size = new Size(152, 77);
            btnAdministrativo.TabIndex = 9;
            btnAdministrativo.Text = "ADMINISTRATIVO";
            btnAdministrativo.TextAlign = ContentAlignment.MiddleLeft;
            btnAdministrativo.UseVisualStyleBackColor = false;
            btnAdministrativo.Click += btnAdministrativo_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(431, 583);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(86, 31);
            btnSair.TabIndex = 10;
            btnSair.Text = "sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // Escolha_Modulos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1256, 785);
            Controls.Add(btnSair);
            Controls.Add(btnAdministrativo);
            Controls.Add(btnRelatorios);
            Controls.Add(btnEstoqueFarmacia);
            Controls.Add(btnSistemaMedico);
            Controls.Add(btnAtendimento);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Escolha_Modulos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Escolha_Modulos";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAtendimento;
		private Button btnSistemaMedico;
		private Button btnEstoqueFarmacia;
		private Button btnRelatorios;
		private Button btnAdministrativo;
		private Button btnSair;
	}
}
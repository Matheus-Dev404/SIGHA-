namespace SIGHA
{
	partial class PanelFilaEspera
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelFilaEspera));
            label1 = new Label();
            DataGridViewFilaDeEspera = new DataGridView();
            btnChamarPaciente = new Button();
            BoxNomePacienteASerChamado = new TextBox();
            label2 = new Label();
            btnAtualizarLista = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewFilaDeEspera).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 20);
            label1.Name = "label1";
            label1.Size = new Size(208, 15);
            label1.TabIndex = 0;
            label1.Text = "Fila de Espera - Pacientes Aguardando";
            label1.Click += label1_Click;
            // 
            // DataGridViewFilaDeEspera
            // 
            DataGridViewFilaDeEspera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewFilaDeEspera.Location = new Point(45, 119);
            DataGridViewFilaDeEspera.Name = "DataGridViewFilaDeEspera";
            DataGridViewFilaDeEspera.Size = new Size(728, 310);
            DataGridViewFilaDeEspera.TabIndex = 1;
            // 
            // btnChamarPaciente
            // 
            btnChamarPaciente.Location = new Point(460, 56);
            btnChamarPaciente.Name = "btnChamarPaciente";
            btnChamarPaciente.Size = new Size(119, 23);
            btnChamarPaciente.TabIndex = 2;
            btnChamarPaciente.Text = "Chamar Paciente";
            btnChamarPaciente.UseVisualStyleBackColor = true;
            // 
            // BoxNomePacienteASerChamado
            // 
            BoxNomePacienteASerChamado.Location = new Point(277, 56);
            BoxNomePacienteASerChamado.Name = "BoxNomePacienteASerChamado";
            BoxNomePacienteASerChamado.Size = new Size(168, 23);
            BoxNomePacienteASerChamado.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 64);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome do Paciente:";
            // 
            // btnAtualizarLista
            // 
            btnAtualizarLista.Location = new Point(687, 78);
            btnAtualizarLista.Name = "btnAtualizarLista";
            btnAtualizarLista.Size = new Size(101, 24);
            btnAtualizarLista.TabIndex = 6;
            btnAtualizarLista.Text = "Atualizar Lista";
            btnAtualizarLista.UseVisualStyleBackColor = true;
            // 
            // PanelFilaEspera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtualizarLista);
            Controls.Add(label2);
            Controls.Add(BoxNomePacienteASerChamado);
            Controls.Add(btnChamarPaciente);
            Controls.Add(DataGridViewFilaDeEspera);
            Controls.Add(label1);
            Name = "PanelFilaEspera";
            Text = "PanelFilaEspera";
            ((System.ComponentModel.ISupportInitialize)DataGridViewFilaDeEspera).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
		private DataGridView DataGridViewFilaDeEspera;
		private Button btnChamarPaciente;
        private TextBox BoxNomePacienteASerChamado;
        private Label label2;
        private Button btnAtualizarLista;
    }
}
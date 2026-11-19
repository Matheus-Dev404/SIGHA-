namespace SIGHA
{
	partial class PanelExames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelExames));
            label1 = new Label();
            grpNovoExame = new GroupBox();
            clbExames = new CheckedListBox();
            btnSolicitarExame = new Button();
            grpResultados = new GroupBox();
            DataGridViewPacientesSolicitarExame = new DataGridView();
            BoxNomePacienteSolicitarExame = new TextBox();
            label2 = new Label();
            btnAtualizarLista = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewPacientesSolicitarExame).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 28);
            label1.Name = "label1";
            label1.Size = new Size(201, 15);
            label1.TabIndex = 0;
            label1.Text = "Solicitação e Resultados de Exames";
            label1.Click += label1_Click;
            // 
            // grpNovoExame
            // 
            grpNovoExame.Location = new Point(369, 83);
            grpNovoExame.Name = "grpNovoExame";
            grpNovoExame.Size = new Size(219, 223);
            grpNovoExame.TabIndex = 1;
            grpNovoExame.TabStop = false;
            grpNovoExame.Text = "Novo Exame";
            grpNovoExame.Enter += groupBox1_Enter;
            // 
            // clbExames
            // 
            clbExames.CheckOnClick = true;
            clbExames.FormattingEnabled = true;
            clbExames.Items.AddRange(new object[] { "Hemograma, ", "Raio-X, ", "Tomografia", "Urina", "Glicemia" });
            clbExames.Location = new Point(369, 324);
            clbExames.Name = "clbExames";
            clbExames.Size = new Size(177, 58);
            clbExames.TabIndex = 2;
            clbExames.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // btnSolicitarExame
            // 
            btnSolicitarExame.Location = new Point(538, 399);
            btnSolicitarExame.Name = "btnSolicitarExame";
            btnSolicitarExame.Size = new Size(99, 23);
            btnSolicitarExame.TabIndex = 3;
            btnSolicitarExame.Text = "Solicitar Exame";
            btnSolicitarExame.UseVisualStyleBackColor = true;
            // 
            // grpResultados
            // 
            grpResultados.Location = new Point(606, 92);
            grpResultados.Name = "grpResultados";
            grpResultados.Size = new Size(197, 250);
            grpResultados.TabIndex = 4;
            grpResultados.TabStop = false;
            grpResultados.Text = "Resultados";
            // 
            // DataGridViewPacientesSolicitarExame
            // 
            DataGridViewPacientesSolicitarExame.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewPacientesSolicitarExame.Location = new Point(1, 92);
            DataGridViewPacientesSolicitarExame.Name = "DataGridViewPacientesSolicitarExame";
            DataGridViewPacientesSolicitarExame.Size = new Size(346, 214);
            DataGridViewPacientesSolicitarExame.TabIndex = 5;
            // 
            // BoxNomePacienteSolicitarExame
            // 
            BoxNomePacienteSolicitarExame.Location = new Point(193, 359);
            BoxNomePacienteSolicitarExame.Name = "BoxNomePacienteSolicitarExame";
            BoxNomePacienteSolicitarExame.Size = new Size(154, 23);
            BoxNomePacienteSolicitarExame.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 367);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 7;
            label2.Text = "Nome do Paciente:";
            // 
            // btnAtualizarLista
            // 
            btnAtualizarLista.Location = new Point(246, 312);
            btnAtualizarLista.Name = "btnAtualizarLista";
            btnAtualizarLista.Size = new Size(101, 24);
            btnAtualizarLista.TabIndex = 8;
            btnAtualizarLista.Text = "Atualizar Lista";
            btnAtualizarLista.UseVisualStyleBackColor = true;
            // 
            // PanelExames
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtualizarLista);
            Controls.Add(label2);
            Controls.Add(BoxNomePacienteSolicitarExame);
            Controls.Add(DataGridViewPacientesSolicitarExame);
            Controls.Add(grpResultados);
            Controls.Add(btnSolicitarExame);
            Controls.Add(clbExames);
            Controls.Add(grpNovoExame);
            Controls.Add(label1);
            Name = "PanelExames";
            Text = "PanelExames";
            Load += PanelExames_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewPacientesSolicitarExame).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
		private GroupBox grpNovoExame;
		private CheckedListBox clbExames;
		private Button btnSolicitarExame;
		private GroupBox grpResultados;
		private DataGridView DataGridViewPacientesSolicitarExame;
        private TextBox BoxNomePacienteSolicitarExame;
        private Label label2;
        private Button btnAtualizarLista;
    }
}
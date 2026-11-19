namespace SIGHA
{
	partial class PanelConsultorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelConsultorio));
            BoxRelatorio = new RichTextBox();
            dataGridView1 = new DataGridView();
            dataGridViewDadosPaciente = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridViewMedicacaoEmEstoque = new DataGridView();
            label4 = new Label();
            BoxNomeMedicação = new TextBox();
            btnBuscarMedicacao = new Button();
            label5 = new Label();
            BoxQuantidadeDesejada = new TextBox();
            btnSolicitar = new Button();
            btnConcluirAtendimento = new Button();
            btnGerarRelatorioAtendimentoConsultorio = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDadosPaciente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedicacaoEmEstoque).BeginInit();
            SuspendLayout();
            // 
            // BoxRelatorio
            // 
            BoxRelatorio.Location = new Point(331, 210);
            BoxRelatorio.Name = "BoxRelatorio";
            BoxRelatorio.Size = new Size(411, 111);
            BoxRelatorio.TabIndex = 4;
            BoxRelatorio.Text = "";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Left;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 537);
            dataGridView1.TabIndex = 5;
            // 
            // dataGridViewDadosPaciente
            // 
            dataGridViewDadosPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDadosPaciente.Location = new Point(331, 77);
            dataGridViewDadosPaciente.Name = "dataGridViewDadosPaciente";
            dataGridViewDadosPaciente.Size = new Size(411, 100);
            dataGridViewDadosPaciente.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 59);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 7;
            label1.Text = "Dados do Paciente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(331, 192);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 8;
            label2.Text = "Relatório:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(331, 333);
            label3.Name = "label3";
            label3.Size = new Size(187, 15);
            label3.TabIndex = 9;
            label3.Text = "Consultar Medicação em Estoque:";
            // 
            // dataGridViewMedicacaoEmEstoque
            // 
            dataGridViewMedicacaoEmEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMedicacaoEmEstoque.Location = new Point(331, 384);
            dataGridViewMedicacaoEmEstoque.Name = "dataGridViewMedicacaoEmEstoque";
            dataGridViewMedicacaoEmEstoque.Size = new Size(411, 43);
            dataGridViewMedicacaoEmEstoque.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(331, 366);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 11;
            label4.Text = "Nome da Medicação:";
            // 
            // BoxNomeMedicação
            // 
            BoxNomeMedicação.Location = new Point(457, 358);
            BoxNomeMedicação.Name = "BoxNomeMedicação";
            BoxNomeMedicação.Size = new Size(204, 23);
            BoxNomeMedicação.TabIndex = 12;
            // 
            // btnBuscarMedicacao
            // 
            btnBuscarMedicacao.Location = new Point(667, 357);
            btnBuscarMedicacao.Name = "btnBuscarMedicacao";
            btnBuscarMedicacao.Size = new Size(75, 23);
            btnBuscarMedicacao.TabIndex = 13;
            btnBuscarMedicacao.Text = "Buscar";
            btnBuscarMedicacao.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(331, 442);
            label5.Name = "label5";
            label5.Size = new Size(121, 15);
            label5.TabIndex = 14;
            label5.Text = "Quantidade desejada:";
            // 
            // BoxQuantidadeDesejada
            // 
            BoxQuantidadeDesejada.Location = new Point(457, 434);
            BoxQuantidadeDesejada.Name = "BoxQuantidadeDesejada";
            BoxQuantidadeDesejada.Size = new Size(100, 23);
            BoxQuantidadeDesejada.TabIndex = 15;
            // 
            // btnSolicitar
            // 
            btnSolicitar.Location = new Point(563, 434);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(75, 23);
            btnSolicitar.TabIndex = 16;
            btnSolicitar.Text = "Solicitar";
            btnSolicitar.UseVisualStyleBackColor = true;
            // 
            // btnConcluirAtendimento
            // 
            btnConcluirAtendimento.Location = new Point(667, 476);
            btnConcluirAtendimento.Name = "btnConcluirAtendimento";
            btnConcluirAtendimento.Size = new Size(108, 49);
            btnConcluirAtendimento.TabIndex = 17;
            btnConcluirAtendimento.Text = "Concluir Atendimento";
            btnConcluirAtendimento.UseVisualStyleBackColor = true;
            // 
            // btnGerarRelatorioAtendimentoConsultorio
            // 
            btnGerarRelatorioAtendimentoConsultorio.Location = new Point(331, 476);
            btnGerarRelatorioAtendimentoConsultorio.Name = "btnGerarRelatorioAtendimentoConsultorio";
            btnGerarRelatorioAtendimentoConsultorio.Size = new Size(108, 49);
            btnGerarRelatorioAtendimentoConsultorio.TabIndex = 18;
            btnGerarRelatorioAtendimentoConsultorio.Text = "Gerar Relatório";
            btnGerarRelatorioAtendimentoConsultorio.UseVisualStyleBackColor = true;
            // 
            // PanelConsultorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 537);
            Controls.Add(btnGerarRelatorioAtendimentoConsultorio);
            Controls.Add(btnConcluirAtendimento);
            Controls.Add(btnSolicitar);
            Controls.Add(BoxQuantidadeDesejada);
            Controls.Add(label5);
            Controls.Add(btnBuscarMedicacao);
            Controls.Add(BoxNomeMedicação);
            Controls.Add(label4);
            Controls.Add(dataGridViewMedicacaoEmEstoque);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewDadosPaciente);
            Controls.Add(dataGridView1);
            Controls.Add(BoxRelatorio);
            Name = "PanelConsultorio";
            Text = "PanelConsultorio";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDadosPaciente).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedicacaoEmEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox BoxRelatorio;
		private DataGridView dataGridView1;
        private DataGridView dataGridViewDadosPaciente;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridViewMedicacaoEmEstoque;
        private Label label4;
        private TextBox BoxNomeMedicação;
        private Button btnBuscarMedicacao;
        private Label label5;
        private TextBox BoxQuantidadeDesejada;
        private Button btnSolicitar;
        private Button btnConcluirAtendimento;
        private Button btnGerarRelatorioAtendimentoConsultorio;
    }
}
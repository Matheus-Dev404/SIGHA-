namespace SIGHA
{
	partial class MenuAtendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAtendimento));
            panel1 = new Panel();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btnSair = new Button();
            btnEncaminhamento = new Button();
            btnRecepcao = new Button();
            btnAgendamentoConsultas = new Button();
            btnCadastroPacientes = new Button();
            Label_Atendimento = new Label();
            btnMInimizarSidebar = new Button();
            panelConteudo = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnEncaminhamento);
            panel1.Controls.Add(btnRecepcao);
            panel1.Controls.Add(btnAgendamentoConsultas);
            panel1.Controls.Add(btnCadastroPacientes);
            panel1.Controls.Add(Label_Atendimento);
            panel1.Controls.Add(btnMInimizarSidebar);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(222, 632);
            panel1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 293);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(216, 97);
            dataGridView2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 399);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 13;
            label2.Text = "Leitos disponíveis:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 417);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(216, 155);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 264);
            label1.Name = "label1";
            label1.Size = new Size(126, 26);
            label1.TabIndex = 11;
            label1.Text = "Pacientes Aguardando \nAtendimento:";
            label1.Click += label1_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Transparent;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Image = (Image)resources.GetObject("btnSair.Image");
            btnSair.Location = new Point(112, 578);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(47, 42);
            btnSair.TabIndex = 0;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnEncaminhamento
            // 
            btnEncaminhamento.Location = new Point(0, 218);
            btnEncaminhamento.Name = "btnEncaminhamento";
            btnEncaminhamento.Size = new Size(222, 43);
            btnEncaminhamento.TabIndex = 10;
            btnEncaminhamento.Text = "Triagem";
            btnEncaminhamento.UseVisualStyleBackColor = true;
            btnEncaminhamento.Click += btnEncaminhamento_Click;
            // 
            // btnRecepcao
            // 
            btnRecepcao.Location = new Point(0, 178);
            btnRecepcao.Name = "btnRecepcao";
            btnRecepcao.Size = new Size(222, 43);
            btnRecepcao.TabIndex = 6;
            btnRecepcao.Text = "Recepção";
            btnRecepcao.UseVisualStyleBackColor = true;
            btnRecepcao.Click += btnRecepcao_Click;
            // 
            // btnAgendamentoConsultas
            // 
            btnAgendamentoConsultas.Location = new Point(0, 139);
            btnAgendamentoConsultas.Name = "btnAgendamentoConsultas";
            btnAgendamentoConsultas.Size = new Size(222, 42);
            btnAgendamentoConsultas.TabIndex = 4;
            btnAgendamentoConsultas.Text = "Agendamento de Consultas";
            btnAgendamentoConsultas.UseVisualStyleBackColor = true;
            btnAgendamentoConsultas.Click += btnAgendamentoConsultas_Click;
            // 
            // btnCadastroPacientes
            // 
            btnCadastroPacientes.Location = new Point(0, 98);
            btnCadastroPacientes.Name = "btnCadastroPacientes";
            btnCadastroPacientes.Size = new Size(222, 43);
            btnCadastroPacientes.TabIndex = 3;
            btnCadastroPacientes.Text = "Cadastro de Pacientes";
            btnCadastroPacientes.UseVisualStyleBackColor = true;
            btnCadastroPacientes.Click += btnCadastroPacientes_Click;
            // 
            // Label_Atendimento
            // 
            Label_Atendimento.AutoSize = true;
            Label_Atendimento.FlatStyle = FlatStyle.Popup;
            Label_Atendimento.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Atendimento.Image = (Image)resources.GetObject("Label_Atendimento.Image");
            Label_Atendimento.ImageAlign = ContentAlignment.MiddleLeft;
            Label_Atendimento.Location = new Point(12, 55);
            Label_Atendimento.Name = "Label_Atendimento";
            Label_Atendimento.Size = new Size(164, 30);
            Label_Atendimento.TabIndex = 2;
            Label_Atendimento.Text = "     Atendimento";
            Label_Atendimento.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMInimizarSidebar
            // 
            btnMInimizarSidebar.BackColor = Color.Transparent;
            btnMInimizarSidebar.FlatStyle = FlatStyle.Flat;
            btnMInimizarSidebar.Image = (Image)resources.GetObject("btnMInimizarSidebar.Image");
            btnMInimizarSidebar.ImageAlign = ContentAlignment.MiddleRight;
            btnMInimizarSidebar.Location = new Point(0, 0);
            btnMInimizarSidebar.Name = "btnMInimizarSidebar";
            btnMInimizarSidebar.Size = new Size(222, 38);
            btnMInimizarSidebar.TabIndex = 1;
            btnMInimizarSidebar.UseVisualStyleBackColor = false;
            // 
            // panelConteudo
            // 
            panelConteudo.BackgroundImage = (Image)resources.GetObject("panelConteudo.BackgroundImage");
            panelConteudo.BackgroundImageLayout = ImageLayout.Stretch;
            panelConteudo.Dock = DockStyle.Fill;
            panelConteudo.Location = new Point(222, 0);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(1010, 632);
            panelConteudo.TabIndex = 2;
            // 
            // MenuAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 632);
            Controls.Add(panelConteudo);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MenuAtendimento";
            Text = "MenuAtendimento";
            WindowState = FormWindowState.Maximized;
            Load += MenuAtendimento_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
		private Button btnMInimizarSidebar;
		private Label Label_Atendimento;
		private Panel panelConteudo;
		private Button btnCadastroPacientes;
		private Button btnRecepcao;
		private Button btnAgendamentoConsultas;
		private Button btnEncaminhamento;
		private Button btnSair;
		private Label label1;
		private Label label2;
		private DataGridView dataGridView1;
		private DataGridView dataGridView2;
	}
}
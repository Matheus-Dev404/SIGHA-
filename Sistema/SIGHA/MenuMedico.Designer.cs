namespace SIGHA
{
	partial class MenuMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuMedico));
            panel1 = new Panel();
            btnSair = new Button();
            btnExames = new Button();
            btnHistoricoPaciente = new Button();
            btnConsultorio = new Button();
            btnFilaEspera = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnExames);
            panel1.Controls.Add(btnHistoricoPaciente);
            panel1.Controls.Add(btnConsultorio);
            panel1.Controls.Add(btnFilaEspera);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 0;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(12, 392);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(176, 46);
            btnSair.TabIndex = 4;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnExames
            // 
            btnExames.Location = new Point(12, 212);
            btnExames.Name = "btnExames";
            btnExames.Size = new Size(176, 46);
            btnExames.TabIndex = 3;
            btnExames.Text = "Exames";
            btnExames.UseVisualStyleBackColor = true;
            btnExames.Click += btnExames_Click;
            // 
            // btnHistoricoPaciente
            // 
            btnHistoricoPaciente.Location = new Point(12, 279);
            btnHistoricoPaciente.Name = "btnHistoricoPaciente";
            btnHistoricoPaciente.Size = new Size(176, 46);
            btnHistoricoPaciente.TabIndex = 2;
            btnHistoricoPaciente.Text = "Histórico de Paciente";
            btnHistoricoPaciente.UseVisualStyleBackColor = true;
            btnHistoricoPaciente.Click += btnHistoricoPaciente_Click;
            // 
            // btnConsultorio
            // 
            btnConsultorio.Location = new Point(12, 85);
            btnConsultorio.Name = "btnConsultorio";
            btnConsultorio.Size = new Size(176, 46);
            btnConsultorio.TabIndex = 1;
            btnConsultorio.Text = "Consultorio";
            btnConsultorio.UseVisualStyleBackColor = true;
            btnConsultorio.Click += btnConsultorio_Click;
            // 
            // btnFilaEspera
            // 
            btnFilaEspera.Location = new Point(12, 146);
            btnFilaEspera.Name = "btnFilaEspera";
            btnFilaEspera.Size = new Size(176, 46);
            btnFilaEspera.TabIndex = 0;
            btnFilaEspera.Text = "Fila De Espera";
            btnFilaEspera.UseVisualStyleBackColor = true;
            btnFilaEspera.Click += btnFilaEspera_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientInactiveCaption;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(200, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(600, 100);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(200, 100);
            panel4.Name = "panel4";
            panel4.Size = new Size(600, 350);
            panel4.TabIndex = 2;
            panel4.Paint += panel4_Paint;
            // 
            // MenuMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuMedico";
            Text = "Menu Médico - SIGHA";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
		private Panel panel3;
		private Button btnSair;
		private Button btnExames;
		private Button btnHistoricoPaciente;
		private Button btnConsultorio;
		private Button btnFilaEspera;
		private Panel panel4;
	}
}
namespace SIGHA
{
	partial class PanelHistoricoPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelHistoricoPaciente));
            label1 = new Label();
            txtBuscaHistoricoPacienteCPF = new TextBox();
            btnBuscar = new Button();
            DataGridViewHistoricoPaciente = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DataGridViewHistoricoPaciente).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 307);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 0;
            label1.Text = "Buscar Paciente (CPF):";
            // 
            // txtBuscaHistoricoPacienteCPF
            // 
            txtBuscaHistoricoPacienteCPF.Location = new Point(383, 304);
            txtBuscaHistoricoPacienteCPF.Name = "txtBuscaHistoricoPacienteCPF";
            txtBuscaHistoricoPacienteCPF.Size = new Size(100, 23);
            txtBuscaHistoricoPacienteCPF.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(408, 333);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Pesquisar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // DataGridViewHistoricoPaciente
            // 
            DataGridViewHistoricoPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewHistoricoPaciente.Location = new Point(38, 35);
            DataGridViewHistoricoPaciente.Name = "DataGridViewHistoricoPaciente";
            DataGridViewHistoricoPaciente.Size = new Size(699, 254);
            DataGridViewHistoricoPaciente.TabIndex = 4;
            // 
            // PanelHistoricoPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(DataGridViewHistoricoPaciente);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscaHistoricoPacienteCPF);
            Controls.Add(label1);
            Name = "PanelHistoricoPaciente";
            Text = "PanelHistoricoPaciente";
            Load += PanelHistoricoPaciente_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewHistoricoPaciente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
		private TextBox txtBuscaHistoricoPacienteCPF;
		private Button btnBuscar;
		private DataGridView DataGridViewHistoricoPaciente;
	}
}
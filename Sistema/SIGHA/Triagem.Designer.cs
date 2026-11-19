namespace SIGHA
{
	partial class Triagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Triagem));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnProxPaciente = new Button();
            btnSalvar = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(326, 9);
            label1.Name = "label1";
            label1.Size = new Size(142, 45);
            label1.TabIndex = 0;
            label1.Text = "Triagem";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 32);
            dataGridView1.TabIndex = 1;
            // 
            // btnProxPaciente
            // 
            btnProxPaciente.Location = new Point(656, 309);
            btnProxPaciente.Name = "btnProxPaciente";
            btnProxPaciente.Size = new Size(132, 23);
            btnProxPaciente.TabIndex = 2;
            btnProxPaciente.Text = "Chamar Próximo";
            btnProxPaciente.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(280, 339);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 123);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 4;
            label2.Text = "Evolução:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 141);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(776, 163);
            textBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Vermelho (Emergência): ", "Laranja (Muito Urgente): ", "Amarelo (Urgente): ", "Verde (Pouco Urgente):", "Azul (Não Urgente):" });
            comboBox1.Location = new Point(132, 310);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(223, 23);
            comboBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 318);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 7;
            label3.Text = "Código Manchester:";
            // 
            // Triagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 580);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(btnSalvar);
            Controls.Add(btnProxPaciente);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Triagem";
            Text = "Triagem";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
		private DataGridView dataGridView1;
		private Button btnProxPaciente;
		private Button btnSalvar;
		private Label label2;
		private TextBox textBox1;
		private ComboBox comboBox1;
		private Label label3;
	}
}
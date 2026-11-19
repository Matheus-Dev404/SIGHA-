namespace SIGHA
{
	partial class Recepcao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recepcao));
            label1 = new Label();
            label2 = new Label();
            BoxNomePaciente = new TextBox();
            BoxCpfPaciente = new TextBox();
            label3 = new Label();
            BoxSintomasIniciais = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnEnviarParaTriagem = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(319, 9);
            label1.Name = "label1";
            label1.Size = new Size(161, 45);
            label1.TabIndex = 0;
            label1.Text = "Recepção";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 109);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome do Paciente:";
            // 
            // BoxNomePaciente
            // 
            BoxNomePaciente.Location = new Point(20, 127);
            BoxNomePaciente.Name = "BoxNomePaciente";
            BoxNomePaciente.Size = new Size(207, 23);
            BoxNomePaciente.TabIndex = 2;
            // 
            // BoxCpfPaciente
            // 
            BoxCpfPaciente.Location = new Point(248, 127);
            BoxCpfPaciente.Name = "BoxCpfPaciente";
            BoxCpfPaciente.Size = new Size(158, 23);
            BoxCpfPaciente.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(248, 109);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 3;
            label3.Text = "CPF do Paciente:";
            label3.Click += label3_Click;
            // 
            // BoxSintomasIniciais
            // 
            BoxSintomasIniciais.Location = new Point(28, 199);
            BoxSintomasIniciais.Multiline = true;
            BoxSintomasIniciais.Name = "BoxSintomasIniciais";
            BoxSintomasIniciais.Size = new Size(467, 89);
            BoxSintomasIniciais.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 181);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 5;
            label4.Text = "Sintomas Iniciais:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(421, 109);
            label5.Name = "label5";
            label5.Size = new Size(115, 15);
            label5.TabIndex = 7;
            label5.Text = "Data de nascimento:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(421, 127);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // btnEnviarParaTriagem
            // 
            btnEnviarParaTriagem.Location = new Point(546, 318);
            btnEnviarParaTriagem.Name = "btnEnviarParaTriagem";
            btnEnviarParaTriagem.Size = new Size(75, 23);
            btnEnviarParaTriagem.TabIndex = 9;
            btnEnviarParaTriagem.Text = "Enviar";
            btnEnviarParaTriagem.UseVisualStyleBackColor = true;
            // 
            // Recepcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 460);
            Controls.Add(btnEnviarParaTriagem);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(BoxSintomasIniciais);
            Controls.Add(label4);
            Controls.Add(BoxCpfPaciente);
            Controls.Add(label3);
            Controls.Add(BoxNomePaciente);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Recepcao";
            Text = "Recepcao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
		private Label label2;
		private TextBox BoxNomePaciente;
		private TextBox BoxCpfPaciente;
		private Label label3;
		private TextBox BoxSintomasIniciais;
		private Label label4;
		private Label label5;
		private DateTimePicker dateTimePicker1;
		private Button btnEnviarParaTriagem;
	}
}
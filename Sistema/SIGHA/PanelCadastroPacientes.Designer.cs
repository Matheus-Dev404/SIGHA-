namespace SIGHA
{
	partial class PanelCadastroPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelCadastroPacientes));
            Label_Titulo = new Label();
            Label_Nome = new Label();
            textBox1 = new TextBox();
            Label_Nascimento = new Label();
            dateTimePicker1 = new DateTimePicker();
            Label_Sexo = new Label();
            comboBox_Sexo = new ComboBox();
            Label_Email = new Label();
            Box_Email = new TextBox();
            Box_Cpf = new TextBox();
            Label_Cpf = new Label();
            btnSalvar = new Button();
            btnNovo = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            btnBuscar = new Button();
            dataGridView1 = new DataGridView();
            Box_Pesquisar = new TextBox();
            Label_Pesquisar = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Label_Titulo
            // 
            Label_Titulo.AutoSize = true;
            Label_Titulo.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_Titulo.Location = new Point(368, 8);
            Label_Titulo.Name = "Label_Titulo";
            Label_Titulo.Size = new Size(318, 40);
            Label_Titulo.TabIndex = 0;
            Label_Titulo.Text = "Cadastro de Pacientes";
            // 
            // Label_Nome
            // 
            Label_Nome.AutoSize = true;
            Label_Nome.Location = new Point(65, 90);
            Label_Nome.Name = "Label_Nome";
            Label_Nome.Size = new Size(43, 15);
            Label_Nome.TabIndex = 1;
            Label_Nome.Text = "Nome:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(415, 23);
            textBox1.TabIndex = 2;
            // 
            // Label_Nascimento
            // 
            Label_Nascimento.AutoSize = true;
            Label_Nascimento.Location = new Point(65, 126);
            Label_Nascimento.Name = "Label_Nascimento";
            Label_Nascimento.Size = new Size(74, 15);
            Label_Nascimento.TabIndex = 3;
            Label_Nascimento.Text = "Nascimento:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(145, 120);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(140, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // Label_Sexo
            // 
            Label_Sexo.AutoSize = true;
            Label_Sexo.Location = new Point(347, 126);
            Label_Sexo.Name = "Label_Sexo";
            Label_Sexo.Size = new Size(35, 15);
            Label_Sexo.TabIndex = 5;
            Label_Sexo.Text = "Sexo:";
            // 
            // comboBox_Sexo
            // 
            comboBox_Sexo.FormattingEnabled = true;
            comboBox_Sexo.Items.AddRange(new object[] { "Feminino", "Masculino", "Outros" });
            comboBox_Sexo.Location = new Point(400, 118);
            comboBox_Sexo.Name = "comboBox_Sexo";
            comboBox_Sexo.Size = new Size(121, 23);
            comboBox_Sexo.TabIndex = 6;
            // 
            // Label_Email
            // 
            Label_Email.AutoSize = true;
            Label_Email.Location = new Point(65, 170);
            Label_Email.Name = "Label_Email";
            Label_Email.Size = new Size(39, 15);
            Label_Email.TabIndex = 7;
            Label_Email.Text = "Email:";
            // 
            // Box_Email
            // 
            Box_Email.Location = new Point(110, 162);
            Box_Email.Name = "Box_Email";
            Box_Email.Size = new Size(287, 23);
            Box_Email.TabIndex = 8;
            // 
            // Box_Cpf
            // 
            Box_Cpf.Location = new Point(110, 191);
            Box_Cpf.Name = "Box_Cpf";
            Box_Cpf.Size = new Size(287, 23);
            Box_Cpf.TabIndex = 10;
            // 
            // Label_Cpf
            // 
            Label_Cpf.AutoSize = true;
            Label_Cpf.Location = new Point(65, 199);
            Label_Cpf.Name = "Label_Cpf";
            Label_Cpf.Size = new Size(31, 15);
            Label_Cpf.TabIndex = 9;
            Label_Cpf.Text = "CPF:";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(145, 267);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(262, 267);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 12;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(Label_Titulo);
            panel1.Controls.Add(btnNovo);
            panel1.Controls.Add(Label_Nome);
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(Box_Cpf);
            panel1.Controls.Add(Label_Nascimento);
            panel1.Controls.Add(Label_Cpf);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(Box_Email);
            panel1.Controls.Add(Label_Sexo);
            panel1.Controls.Add(Label_Email);
            panel1.Controls.Add(comboBox_Sexo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1043, 331);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(Box_Pesquisar);
            panel2.Controls.Add(Label_Pesquisar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 351);
            panel2.Name = "panel2";
            panel2.Size = new Size(1043, 211);
            panel2.TabIndex = 14;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(331, 6);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1019, 160);
            dataGridView1.TabIndex = 2;
            // 
            // Box_Pesquisar
            // 
            Box_Pesquisar.Location = new Point(77, 6);
            Box_Pesquisar.Name = "Box_Pesquisar";
            Box_Pesquisar.Size = new Size(219, 23);
            Box_Pesquisar.TabIndex = 1;
            // 
            // Label_Pesquisar
            // 
            Label_Pesquisar.AutoSize = true;
            Label_Pesquisar.Location = new Point(11, 9);
            Label_Pesquisar.Name = "Label_Pesquisar";
            Label_Pesquisar.Size = new Size(60, 15);
            Label_Pesquisar.TabIndex = 0;
            Label_Pesquisar.Text = "Pesquisar:";
            // 
            // PanelCadastroPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1043, 562);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "PanelCadastroPacientes";
            Text = "PanelCadastroPacientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label Label_Titulo;
		private Label Label_Nome;
		private TextBox textBox1;
		private Label Label_Nascimento;
		private DateTimePicker dateTimePicker1;
		private Label Label_Sexo;
		private ComboBox comboBox_Sexo;
		private Label Label_Email;
		private TextBox Box_Email;
		private TextBox Box_Cpf;
		private Label Label_Cpf;
		private Button btnSalvar;
		private Button btnNovo;
		private Panel panel1;
		private Panel panel2;
		private Button btnBuscar;
		private DataGridView dataGridView1;
		private TextBox Box_Pesquisar;
		private Label Label_Pesquisar;
	}
}
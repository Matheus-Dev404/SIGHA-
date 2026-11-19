namespace SIGHA
{
    partial class panelConfiguracoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panelConfiguracoes));
            label1 = new Label();
            label2 = new Label();
            BoxNomeClinica = new TextBox();
            BoxCNPJ = new TextBox();
            label3 = new Label();
            BoxTelefoneContato = new TextBox();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            btnAlterarDadosClinica = new Button();
            btnExportarBackupDb = new Button();
            btnSalvarCor = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(279, 9);
            label1.Name = "label1";
            label1.Size = new Size(235, 45);
            label1.TabIndex = 0;
            label1.Text = "Configurações";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(147, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome da Clínica/Hospital:";
            label2.Click += label2_Click;
            // 
            // BoxNomeClinica
            // 
            BoxNomeClinica.Location = new Point(12, 88);
            BoxNomeClinica.Name = "BoxNomeClinica";
            BoxNomeClinica.Size = new Size(190, 23);
            BoxNomeClinica.TabIndex = 2;
            // 
            // BoxCNPJ
            // 
            BoxCNPJ.Location = new Point(220, 88);
            BoxCNPJ.Name = "BoxCNPJ";
            BoxCNPJ.Size = new Size(190, 23);
            BoxCNPJ.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(220, 70);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 3;
            label3.Text = "CNPJ:";
            // 
            // BoxTelefoneContato
            // 
            BoxTelefoneContato.Location = new Point(428, 88);
            BoxTelefoneContato.Name = "BoxTelefoneContato";
            BoxTelefoneContato.Size = new Size(190, 23);
            BoxTelefoneContato.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(428, 70);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 5;
            label4.Text = "Telefone de Contato:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(12, 154);
            label5.Name = "label5";
            label5.Size = new Size(150, 15);
            label5.TabIndex = 7;
            label5.Text = "Cor dos botões do sistema:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Branco", "Azul", "Vermelho", "Verde", "Roxo", "Rosa" });
            comboBox1.Location = new Point(161, 146);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(108, 23);
            comboBox1.TabIndex = 8;
            // 
            // btnAlterarDadosClinica
            // 
            btnAlterarDadosClinica.Location = new Point(644, 88);
            btnAlterarDadosClinica.Name = "btnAlterarDadosClinica";
            btnAlterarDadosClinica.Size = new Size(97, 23);
            btnAlterarDadosClinica.TabIndex = 9;
            btnAlterarDadosClinica.Text = "Salvar";
            btnAlterarDadosClinica.UseVisualStyleBackColor = true;
            // 
            // btnExportarBackupDb
            // 
            btnExportarBackupDb.Location = new Point(575, 154);
            btnExportarBackupDb.Name = "btnExportarBackupDb";
            btnExportarBackupDb.Size = new Size(166, 40);
            btnExportarBackupDb.TabIndex = 10;
            btnExportarBackupDb.Text = "Exportar Backup do Banco De Dados";
            btnExportarBackupDb.UseVisualStyleBackColor = true;
            // 
            // btnSalvarCor
            // 
            btnSalvarCor.Location = new Point(279, 146);
            btnSalvarCor.Name = "btnSalvarCor";
            btnSalvarCor.Size = new Size(75, 23);
            btnSalvarCor.TabIndex = 11;
            btnSalvarCor.Text = "Salvar";
            btnSalvarCor.UseVisualStyleBackColor = true;
            // 
            // panelConfiguracoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvarCor);
            Controls.Add(btnExportarBackupDb);
            Controls.Add(btnAlterarDadosClinica);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(BoxTelefoneContato);
            Controls.Add(label4);
            Controls.Add(BoxCNPJ);
            Controls.Add(label3);
            Controls.Add(BoxNomeClinica);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "panelConfiguracoes";
            Text = "panelConfiguracoes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox BoxNomeClinica;
        private TextBox BoxCNPJ;
        private Label label3;
        private TextBox BoxTelefoneContato;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private Button btnAlterarDadosClinica;
        private Button btnExportarBackupDb;
        private Button btnSalvarCor;
    }
}
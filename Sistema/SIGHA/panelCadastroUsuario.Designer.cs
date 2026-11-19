namespace SIGHA
{
    partial class panelCadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panelCadastroUsuario));
            label1 = new Label();
            label2 = new Label();
            BoxNomeUsuario = new TextBox();
            BoxLoginUsuario = new TextBox();
            label3 = new Label();
            BoxSenhaUsuario = new TextBox();
            label4 = new Label();
            label5 = new Label();
            comboBoxSetor = new ComboBox();
            btnCadastroUsuario = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(205, 9);
            label1.Name = "label1";
            label1.Size = new Size(422, 54);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Usuários";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(37, 89);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BoxNomeUsuario
            // 
            BoxNomeUsuario.Location = new Point(37, 113);
            BoxNomeUsuario.Name = "BoxNomeUsuario";
            BoxNomeUsuario.Size = new Size(125, 27);
            BoxNomeUsuario.TabIndex = 2;
            // 
            // BoxLoginUsuario
            // 
            BoxLoginUsuario.Location = new Point(186, 113);
            BoxLoginUsuario.Name = "BoxLoginUsuario";
            BoxLoginUsuario.Size = new Size(125, 27);
            BoxLoginUsuario.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(186, 89);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 3;
            label3.Text = "Login:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BoxSenhaUsuario
            // 
            BoxSenhaUsuario.Location = new Point(338, 113);
            BoxSenhaUsuario.Name = "BoxSenhaUsuario";
            BoxSenhaUsuario.Size = new Size(125, 27);
            BoxSenhaUsuario.TabIndex = 6;
            BoxSenhaUsuario.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(338, 89);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 5;
            label4.Text = "Senha:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(486, 89);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 7;
            label5.Text = "Setor:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxSetor
            // 
            comboBoxSetor.FormattingEnabled = true;
            comboBoxSetor.Items.AddRange(new object[] { "Atendimento", "Admin", "GestaoRh", "Enfermagem", "Farmacia", "Medicina" });
            comboBoxSetor.Location = new Point(486, 112);
            comboBoxSetor.Name = "comboBoxSetor";
            comboBoxSetor.Size = new Size(126, 28);
            comboBoxSetor.TabIndex = 8;
            // 
            // btnCadastroUsuario
            // 
            btnCadastroUsuario.Location = new Point(475, 161);
            btnCadastroUsuario.Name = "btnCadastroUsuario";
            btnCadastroUsuario.Size = new Size(137, 31);
            btnCadastroUsuario.TabIndex = 9;
            btnCadastroUsuario.Text = "Cadastrar Usuário";
            btnCadastroUsuario.UseVisualStyleBackColor = true;
            // 
            // panelCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastroUsuario);
            Controls.Add(comboBoxSetor);
            Controls.Add(label5);
            Controls.Add(BoxSenhaUsuario);
            Controls.Add(label4);
            Controls.Add(BoxLoginUsuario);
            Controls.Add(label3);
            Controls.Add(BoxNomeUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "panelCadastroUsuario";
            Text = "panelCadastroUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox BoxNomeUsuario;
        private TextBox BoxLoginUsuario;
        private Label label3;
        private TextBox BoxSenhaUsuario;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxSetor;
        private Button btnCadastroUsuario;
    }
}
namespace SIGHA
{
    partial class MenuAdmnistrativo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdmnistrativo));
            panel1 = new Panel();
            btnSair = new Button();
            label1 = new Label();
            btnCadastroUsuario = new Button();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panelConteudo = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCadastroUsuario);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(103, 338);
            panel1.TabIndex = 0;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(10, 300);
            btnSair.Margin = new Padding(3, 2, 3, 2);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 60);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Admnistrativo";
            // 
            // btnCadastroUsuario
            // 
            btnCadastroUsuario.Location = new Point(0, 88);
            btnCadastroUsuario.Margin = new Padding(3, 2, 3, 2);
            btnCadastroUsuario.Name = "btnCadastroUsuario";
            btnCadastroUsuario.Size = new Size(103, 37);
            btnCadastroUsuario.TabIndex = 0;
            btnCadastroUsuario.Text = "Cadastrar Usuário";
            btnCadastroUsuario.UseVisualStyleBackColor = true;
            btnCadastroUsuario.Click += btnCadastroUsuario_Click;
            // 
            // panel4
            // 
            panel4.Location = new Point(103, 50);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(174, 82);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Location = new Point(103, 47);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(605, 290);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(103, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(597, 50);
            panel2.TabIndex = 1;
            // 
            // panelConteudo
            // 
            panelConteudo.Dock = DockStyle.Fill;
            panelConteudo.Location = new Point(103, 50);
            panelConteudo.Margin = new Padding(3, 2, 3, 2);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(597, 288);
            panelConteudo.TabIndex = 2;
            // 
            // MenuAdmnistrativo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(panelConteudo);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuAdmnistrativo";
            Text = "MenuAdmnistrativo";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panelConteudo;
        private Label label1;
        private Button btnCadastroUsuario;
        private Button btnSair;
    }
}
namespace SIGHA
{
    partial class MenuEstoque_e_Farmacia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuEstoque_e_Farmacia));
            panel1 = new Panel();
            btnSair = new Button();
            btnEstoqueAtual = new Button();
            btnMovimentacoes = new Button();
            btnRequisicoes = new Button();
            btnCadastroProduto = new Button();
            label1 = new Label();
            panel2 = new Panel();
            panelConteudo = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnEstoqueAtual);
            panel1.Controls.Add(btnMovimentacoes);
            panel1.Controls.Add(btnRequisicoes);
            panel1.Controls.Add(btnCadastroProduto);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(119, 600);
            panel1.TabIndex = 0;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(11, 524);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(94, 29);
            btnSair.TabIndex = 0;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnEstoqueAtual
            // 
            btnEstoqueAtual.Location = new Point(0, 260);
            btnEstoqueAtual.Margin = new Padding(3, 4, 3, 4);
            btnEstoqueAtual.Name = "btnEstoqueAtual";
            btnEstoqueAtual.Size = new Size(119, 51);
            btnEstoqueAtual.TabIndex = 3;
            btnEstoqueAtual.Text = "Estoque Atual";
            btnEstoqueAtual.UseVisualStyleBackColor = true;
            btnEstoqueAtual.Click += btnEstoqueAtual_Click;
            // 
            // btnMovimentacoes
            // 
            btnMovimentacoes.Location = new Point(0, 213);
            btnMovimentacoes.Margin = new Padding(3, 4, 3, 4);
            btnMovimentacoes.Name = "btnMovimentacoes";
            btnMovimentacoes.Size = new Size(119, 51);
            btnMovimentacoes.TabIndex = 2;
            btnMovimentacoes.Text = "Movimentações";
            btnMovimentacoes.UseVisualStyleBackColor = true;
            btnMovimentacoes.Click += btnMovimentacoes_Click;
            // 
            // btnRequisicoes
            // 
            btnRequisicoes.Location = new Point(0, 167);
            btnRequisicoes.Margin = new Padding(3, 4, 3, 4);
            btnRequisicoes.Name = "btnRequisicoes";
            btnRequisicoes.Size = new Size(119, 51);
            btnRequisicoes.TabIndex = 1;
            btnRequisicoes.Text = "Requisições";
            btnRequisicoes.UseVisualStyleBackColor = true;
            btnRequisicoes.Click += btnRequisicoes_Click;
            // 
            // btnCadastroProduto
            // 
            btnCadastroProduto.Location = new Point(0, 120);
            btnCadastroProduto.Margin = new Padding(3, 4, 3, 4);
            btnCadastroProduto.Name = "btnCadastroProduto";
            btnCadastroProduto.Size = new Size(119, 51);
            btnCadastroProduto.TabIndex = 0;
            btnCadastroProduto.Text = "Cadastrar Produto";
            btnCadastroProduto.UseVisualStyleBackColor = true;
            btnCadastroProduto.Click += btnCadastroProduto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 60);
            label1.Name = "label1";
            label1.Size = new Size(110, 56);
            label1.TabIndex = 0;
            label1.Text = "Estoque e \nFarmácia";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(119, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(795, 60);
            panel2.TabIndex = 1;
            // 
            // panelConteudo
            // 
            panelConteudo.BackColor = Color.Transparent;
            panelConteudo.BackgroundImage = (Image)resources.GetObject("panelConteudo.BackgroundImage");
            panelConteudo.BackgroundImageLayout = ImageLayout.Stretch;
            panelConteudo.Dock = DockStyle.Fill;
            panelConteudo.Location = new Point(119, 60);
            panelConteudo.Margin = new Padding(3, 4, 3, 4);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(795, 540);
            panelConteudo.TabIndex = 2;
            // 
            // MenuEstoque_e_Farmacia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(panelConteudo);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "MenuEstoque_e_Farmacia";
            Text = "MenuEstoque_e_Farmacia";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panelConteudo;
        private Label label1;
        private Button btnCadastroProduto;
        private Button btnRequisicoes;
        private Button btnEstoqueAtual;
        private Button btnMovimentacoes;
        private Button btnSair;
    }
}
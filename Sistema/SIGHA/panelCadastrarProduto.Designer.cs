namespace SIGHA
{
    partial class panelCadastrarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panelCadastrarProduto));
            label1 = new Label();
            label2 = new Label();
            BoxNomeProduto = new TextBox();
            BoxUnidadeMedida = new TextBox();
            label3 = new Label();
            BoxQuantidade = new TextBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            btnCadastrar = new Button();
            btnVisualizarProduto = new Button();
            btnEditarProduto = new Button();
            btnExcluirProduto = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(248, 9);
            label1.Name = "label1";
            label1.Size = new Size(346, 45);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Produtos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome do produto:";
            // 
            // BoxNomeProduto
            // 
            BoxNomeProduto.Location = new Point(12, 108);
            BoxNomeProduto.Name = "BoxNomeProduto";
            BoxNomeProduto.Size = new Size(122, 23);
            BoxNomeProduto.TabIndex = 2;
            // 
            // BoxUnidadeMedida
            // 
            BoxUnidadeMedida.Location = new Point(140, 108);
            BoxUnidadeMedida.Name = "BoxUnidadeMedida";
            BoxUnidadeMedida.Size = new Size(122, 23);
            BoxUnidadeMedida.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(140, 90);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 3;
            label3.Text = "Unidade de medida:";
            // 
            // BoxQuantidade
            // 
            BoxQuantidade.Location = new Point(268, 108);
            BoxQuantidade.Name = "BoxQuantidade";
            BoxQuantidade.Size = new Size(122, 23);
            BoxQuantidade.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 90);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 5;
            label4.Text = "Quantidade:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(778, 162);
            dataGridView1.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(396, 107);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnVisualizarProduto
            // 
            btnVisualizarProduto.Location = new Point(12, 320);
            btnVisualizarProduto.Name = "btnVisualizarProduto";
            btnVisualizarProduto.Size = new Size(122, 23);
            btnVisualizarProduto.TabIndex = 9;
            btnVisualizarProduto.Text = "Visualizar Produtos";
            btnVisualizarProduto.UseVisualStyleBackColor = true;
            // 
            // btnEditarProduto
            // 
            btnEditarProduto.Location = new Point(140, 320);
            btnEditarProduto.Name = "btnEditarProduto";
            btnEditarProduto.Size = new Size(122, 23);
            btnEditarProduto.TabIndex = 10;
            btnEditarProduto.Text = "Editar Produto";
            btnEditarProduto.UseVisualStyleBackColor = true;
            // 
            // btnExcluirProduto
            // 
            btnExcluirProduto.Location = new Point(268, 320);
            btnExcluirProduto.Name = "btnExcluirProduto";
            btnExcluirProduto.Size = new Size(122, 23);
            btnExcluirProduto.TabIndex = 11;
            btnExcluirProduto.Text = "Excluir Produto";
            btnExcluirProduto.UseVisualStyleBackColor = true;
            // 
            // panelCadastrarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExcluirProduto);
            Controls.Add(btnEditarProduto);
            Controls.Add(btnVisualizarProduto);
            Controls.Add(btnCadastrar);
            Controls.Add(dataGridView1);
            Controls.Add(BoxQuantidade);
            Controls.Add(label4);
            Controls.Add(BoxUnidadeMedida);
            Controls.Add(label3);
            Controls.Add(BoxNomeProduto);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "panelCadastrarProduto";
            Text = "panelCadastrarProduto";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox BoxNomeProduto;
        private TextBox BoxUnidadeMedida;
        private Label label3;
        private TextBox BoxQuantidade;
        private Label label4;
        private DataGridView dataGridView1;
        private Button btnCadastrar;
        private Button btnVisualizarProduto;
        private Button btnEditarProduto;
        private Button btnExcluirProduto;
    }
}
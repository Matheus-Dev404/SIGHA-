namespace SIGHA
{
    partial class panelMovimentacaoEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panelMovimentacaoEstoque));
            label1 = new Label();
            label2 = new Label();
            dataGridViewEntradaProdutos = new DataGridView();
            dataGridViewSaidaProdutos = new DataGridView();
            label3 = new Label();
            btnAtualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEntradaProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSaidaProdutos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(191, 9);
            label1.Name = "label1";
            label1.Size = new Size(420, 45);
            label1.TabIndex = 0;
            label1.Text = "Movimentação do Estoque";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 1;
            label2.Text = "Entrada de Produtos:";
            // 
            // dataGridViewEntradaProdutos
            // 
            dataGridViewEntradaProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEntradaProdutos.Location = new Point(12, 89);
            dataGridViewEntradaProdutos.Name = "dataGridViewEntradaProdutos";
            dataGridViewEntradaProdutos.Size = new Size(776, 133);
            dataGridViewEntradaProdutos.TabIndex = 2;
            // 
            // dataGridViewSaidaProdutos
            // 
            dataGridViewSaidaProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSaidaProdutos.Location = new Point(12, 268);
            dataGridViewSaidaProdutos.Name = "dataGridViewSaidaProdutos";
            dataGridViewSaidaProdutos.Size = new Size(776, 122);
            dataGridViewSaidaProdutos.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 250);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 3;
            label3.Text = "Entrada de Produtos:";
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(713, 396);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 5;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // panelMovimentacaoEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtualizar);
            Controls.Add(dataGridViewSaidaProdutos);
            Controls.Add(label3);
            Controls.Add(dataGridViewEntradaProdutos);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "panelMovimentacaoEstoque";
            Text = "panelMovimentacaoEstoque";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEntradaProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSaidaProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridViewEntradaProdutos;
        private DataGridView dataGridViewSaidaProdutos;
        private Label label3;
        private Button btnAtualizar;
    }
}
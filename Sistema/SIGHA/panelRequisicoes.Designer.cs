namespace SIGHA
{
    partial class panelRequisicoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panelRequisicoes));
            label1 = new Label();
            dataGridViewRequisicoes = new DataGridView();
            btnAprovarRequisicao = new Button();
            BoxIdRequisicao = new TextBox();
            label2 = new Label();
            btnAtualizarLista = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequisicoes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(303, 9);
            label1.Name = "label1";
            label1.Size = new Size(194, 45);
            label1.TabIndex = 0;
            label1.Text = "Requisições";
            // 
            // dataGridViewRequisicoes
            // 
            dataGridViewRequisicoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRequisicoes.Location = new Point(31, 70);
            dataGridViewRequisicoes.Name = "dataGridViewRequisicoes";
            dataGridViewRequisicoes.Size = new Size(743, 233);
            dataGridViewRequisicoes.TabIndex = 1;
            // 
            // btnAprovarRequisicao
            // 
            btnAprovarRequisicao.Location = new Point(402, 322);
            btnAprovarRequisicao.Name = "btnAprovarRequisicao";
            btnAprovarRequisicao.Size = new Size(95, 31);
            btnAprovarRequisicao.TabIndex = 2;
            btnAprovarRequisicao.Text = "Aprovar";
            btnAprovarRequisicao.UseVisualStyleBackColor = true;
            // 
            // BoxIdRequisicao
            // 
            BoxIdRequisicao.Location = new Point(251, 327);
            BoxIdRequisicao.Name = "BoxIdRequisicao";
            BoxIdRequisicao.Size = new Size(85, 23);
            BoxIdRequisicao.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 335);
            label2.Name = "label2";
            label2.Size = new Size(138, 15);
            label2.TabIndex = 4;
            label2.Text = "Digite o ID da requisição:";
            // 
            // btnAtualizarLista
            // 
            btnAtualizarLista.Location = new Point(673, 309);
            btnAtualizarLista.Name = "btnAtualizarLista";
            btnAtualizarLista.Size = new Size(101, 24);
            btnAtualizarLista.TabIndex = 5;
            btnAtualizarLista.Text = "Atualizar Lista";
            btnAtualizarLista.UseVisualStyleBackColor = true;
            // 
            // panelRequisicoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtualizarLista);
            Controls.Add(label2);
            Controls.Add(BoxIdRequisicao);
            Controls.Add(btnAprovarRequisicao);
            Controls.Add(dataGridViewRequisicoes);
            Controls.Add(label1);
            Name = "panelRequisicoes";
            Text = "panelRequisicoes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequisicoes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewRequisicoes;
        private Button btnAprovarRequisicao;
        private TextBox BoxIdRequisicao;
        private Label label2;
        private Button btnAtualizarLista;
    }
}
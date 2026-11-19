namespace SIGHA
{
    partial class panelRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panelRelatorio));
            label1 = new Label();
            label2 = new Label();
            dataGridViewAtendimentosRealizados = new DataGridView();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            dataGridViewConsumoEstoque = new DataGridView();
            label4 = new Label();
            btnImprimirRelatorio = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAtendimentosRealizados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsumoEstoque).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(308, 9);
            label1.Name = "label1";
            label1.Size = new Size(171, 45);
            label1.TabIndex = 0;
            label1.Text = "Relatórios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 98);
            label2.Name = "label2";
            label2.Size = new Size(140, 15);
            label2.TabIndex = 1;
            label2.Text = "Atendimentos Realizados";
            label2.Click += label2_Click;
            // 
            // dataGridViewAtendimentosRealizados
            // 
            dataGridViewAtendimentosRealizados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAtendimentosRealizados.Location = new Point(12, 116);
            dataGridViewAtendimentosRealizados.Name = "dataGridViewAtendimentosRealizados";
            dataGridViewAtendimentosRealizados.Size = new Size(358, 95);
            dataGridViewAtendimentosRealizados.TabIndex = 2;
            dataGridViewAtendimentosRealizados.CellContentClick += dataGridViewAtendimentosRealizados_CellContentClick;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(396, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(381, 95);
            dataGridView1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(396, 98);
            label3.Name = "label3";
            label3.Size = new Size(140, 15);
            label3.TabIndex = 3;
            label3.Text = "Atendimentos Realizados";
            // 
            // dataGridViewConsumoEstoque
            // 
            dataGridViewConsumoEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConsumoEstoque.Location = new Point(794, 116);
            dataGridViewConsumoEstoque.Name = "dataGridViewConsumoEstoque";
            dataGridViewConsumoEstoque.Size = new Size(396, 95);
            dataGridViewConsumoEstoque.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(794, 98);
            label4.Name = "label4";
            label4.Size = new Size(123, 15);
            label4.TabIndex = 5;
            label4.Text = "Consumo de estoque:";
            // 
            // btnImprimirRelatorio
            // 
            btnImprimirRelatorio.Location = new Point(897, 217);
            btnImprimirRelatorio.Name = "btnImprimirRelatorio";
            btnImprimirRelatorio.Size = new Size(116, 41);
            btnImprimirRelatorio.TabIndex = 7;
            btnImprimirRelatorio.Text = "Imprimir Relatório do dia";
            btnImprimirRelatorio.UseVisualStyleBackColor = true;
            // 
            // panelRelatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1259, 450);
            Controls.Add(btnImprimirRelatorio);
            Controls.Add(dataGridViewConsumoEstoque);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(dataGridViewAtendimentosRealizados);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "panelRelatorio";
            Text = "panelRelatorio";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAtendimentosRealizados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsumoEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridViewAtendimentosRealizados;
        private DataGridView dataGridView1;
        private Label label3;
        private DataGridView dataGridViewConsumoEstoque;
        private Label label4;
        private Button btnImprimirRelatorio;
    }
}
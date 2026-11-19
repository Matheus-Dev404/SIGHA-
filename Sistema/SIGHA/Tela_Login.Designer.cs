namespace SIGHA
{
	partial class Tela_Login
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Login));
            Label_Usuario = new Label();
            Box_Usuario = new TextBox();
            Box_Senha = new TextBox();
            Label_Senha = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // Label_Usuario
            // 
            Label_Usuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Label_Usuario.AutoSize = true;
            Label_Usuario.Location = new Point(295, 296);
            Label_Usuario.Name = "Label_Usuario";
            Label_Usuario.Size = new Size(50, 15);
            Label_Usuario.TabIndex = 0;
            Label_Usuario.Text = "Usuário:";
            // 
            // Box_Usuario
            // 
            Box_Usuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Box_Usuario.Location = new Point(351, 293);
            Box_Usuario.Name = "Box_Usuario";
            Box_Usuario.Size = new Size(100, 23);
            Box_Usuario.TabIndex = 1;
            // 
            // Box_Senha
            // 
            Box_Senha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Box_Senha.Location = new Point(351, 322);
            Box_Senha.Name = "Box_Senha";
            Box_Senha.Size = new Size(100, 23);
            Box_Senha.TabIndex = 3;
            Box_Senha.UseSystemPasswordChar = true;
            // 
            // Label_Senha
            // 
            Label_Senha.AutoSize = true;
            Label_Senha.Location = new Point(295, 325);
            Label_Senha.Name = "Label_Senha";
            Label_Senha.Size = new Size(42, 15);
            Label_Senha.TabIndex = 2;
            Label_Senha.Text = "Senha:";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.FromArgb(0, 180, 140);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.Transparent;
            btnLogin.Location = new Point(386, 351);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(77, 26);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "ENTRAR";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            btnLogin.MouseEnter += btnLogin_MouseEnter;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            // 
            // Tela_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1070, 649);
            Controls.Add(btnLogin);
            Controls.Add(Box_Senha);
            Controls.Add(Label_Senha);
            Controls.Add(Box_Usuario);
            Controls.Add(Label_Usuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Tela_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_Usuario;
		private TextBox Box_Usuario;
		private TextBox Box_Senha;
		private Label Label_Senha;
		private Button btnLogin;
	}
}

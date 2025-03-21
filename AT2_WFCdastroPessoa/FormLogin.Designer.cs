namespace AT2_WFCadastroPessoa
{
    partial class FormLogin
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
            btnAcessar = new Button();
            lblSenha = new Label();
            lblUsuario = new Label();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            SuspendLayout();
            // 
            // btnAcessar
            // 
            btnAcessar.Location = new Point(89, 155);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(75, 23);
            btnAcessar.TabIndex = 9;
            btnAcessar.Text = "Acessar";
            btnAcessar.UseVisualStyleBackColor = true;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.BackColor = Color.Transparent;
            lblSenha.Location = new Point(35, 91);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 8;
            lblSenha.Text = "Senha:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Location = new Point(35, 35);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuário:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(35, 109);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Informe a senha...";
            txtSenha.Size = new Size(112, 23);
            txtSenha.TabIndex = 7;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(35, 53);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Informe o Login...";
            txtUsuario.Size = new Size(112, 23);
            txtUsuario.TabIndex = 5;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(203, 211);
            Controls.Add(btnAcessar);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin2";
            Load += FormLogin2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAcessar;
        private Label lblSenha;
        private Label lblUsuario;
        private TextBox txtSenha;
        private TextBox txtUsuario;
    }
}
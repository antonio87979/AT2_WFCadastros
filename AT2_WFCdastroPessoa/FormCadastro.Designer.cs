namespace AT2_WFCadastroPessoa
{
    partial class FormCadastro
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
            lblCodigo = new Label();
            lblCpf = new Label();
            lblNomeCompleto = new Label();
            lblEmail = new Label();
            lblDdd = new Label();
            lblTipoTelefone = new Label();
            ckbFilhos = new CheckBox();
            BtnSalvar = new Button();
            btnVoltar = new Button();
            gbxTipoTelefone = new GroupBox();
            rdbPessoal = new RadioButton();
            rdbComercial = new RadioButton();
            rdbRecado = new RadioButton();
            mtbDdd = new MaskedTextBox();
            txtEmail = new TextBox();
            txtNomeCompleto = new TextBox();
            txtCodigo = new TextBox();
            mtbCpf = new MaskedTextBox();
            gbxTipoTelefone.SuspendLayout();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(20, 22);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(45, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(160, 22);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(27, 15);
            lblCpf.TabIndex = 1;
            lblCpf.Text = "CPF";
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(20, 81);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(98, 15);
            lblNomeCompleto.TabIndex = 2;
            lblNomeCompleto.Text = "Nome Completo";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(20, 134);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblDdd
            // 
            lblDdd.AutoSize = true;
            lblDdd.Location = new Point(20, 201);
            lblDdd.Name = "lblDdd";
            lblDdd.Size = new Size(77, 15);
            lblDdd.TabIndex = 4;
            lblDdd.Text = "DDD/Celular";
            // 
            // lblTipoTelefone
            // 
            lblTipoTelefone.AutoSize = true;
            lblTipoTelefone.Location = new Point(6, 0);
            lblTipoTelefone.Name = "lblTipoTelefone";
            lblTipoTelefone.Size = new Size(100, 15);
            lblTipoTelefone.TabIndex = 5;
            lblTipoTelefone.Text = "Tipo de Telefone";
            // 
            // ckbFilhos
            // 
            ckbFilhos.AutoSize = true;
            ckbFilhos.Checked = true;
            ckbFilhos.CheckState = CheckState.Indeterminate;
            ckbFilhos.Location = new Point(20, 291);
            ckbFilhos.Name = "ckbFilhos";
            ckbFilhos.RightToLeft = RightToLeft.No;
            ckbFilhos.Size = new Size(99, 19);
            ckbFilhos.TabIndex = 7;
            ckbFilhos.Text = "Possui Filhos?";
            ckbFilhos.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(195, 338);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(85, 35);
            BtnSalvar.TabIndex = 8;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(81, 338);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(88, 35);
            btnVoltar.TabIndex = 9;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // gbxTipoTelefone
            // 
            gbxTipoTelefone.Controls.Add(lblTipoTelefone);
            gbxTipoTelefone.Controls.Add(rdbPessoal);
            gbxTipoTelefone.Controls.Add(rdbComercial);
            gbxTipoTelefone.Controls.Add(rdbRecado);
            gbxTipoTelefone.Location = new Point(202, 201);
            gbxTipoTelefone.Name = "gbxTipoTelefone";
            gbxTipoTelefone.Size = new Size(99, 100);
            gbxTipoTelefone.TabIndex = 6;
            gbxTipoTelefone.TabStop = false;
            // 
            // rdbPessoal
            // 
            rdbPessoal.AutoSize = true;
            rdbPessoal.Location = new Point(6, 25);
            rdbPessoal.Name = "rdbPessoal";
            rdbPessoal.Size = new Size(65, 19);
            rdbPessoal.TabIndex = 0;
            rdbPessoal.TabStop = true;
            rdbPessoal.Text = "Pessoal";
            rdbPessoal.UseVisualStyleBackColor = true;
            // 
            // rdbComercial
            // 
            rdbComercial.AutoSize = true;
            rdbComercial.Location = new Point(6, 50);
            rdbComercial.Name = "rdbComercial";
            rdbComercial.Size = new Size(80, 19);
            rdbComercial.TabIndex = 1;
            rdbComercial.TabStop = true;
            rdbComercial.Text = "Comercial";
            rdbComercial.UseVisualStyleBackColor = true;
            // 
            // rdbRecado
            // 
            rdbRecado.AutoSize = true;
            rdbRecado.Location = new Point(6, 75);
            rdbRecado.Name = "rdbRecado";
            rdbRecado.Size = new Size(66, 19);
            rdbRecado.TabIndex = 2;
            rdbRecado.TabStop = true;
            rdbRecado.Text = "Recado";
            rdbRecado.UseVisualStyleBackColor = true;
            // 
            // mtbDdd
            // 
            mtbDdd.Location = new Point(20, 219);
            mtbDdd.Mask = "(99) 00000-0000";
            mtbDdd.Name = "mtbDdd";
            mtbDdd.Size = new Size(100, 23);
            mtbDdd.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(20, 152);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(260, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(20, 99);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(256, 23);
            txtNomeCompleto.TabIndex = 3;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(20, 40);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(111, 23);
            txtCodigo.TabIndex = 1;
            // 
            // mtbCpf
            // 
            mtbCpf.Location = new Point(160, 40);
            mtbCpf.Mask = "000.000.000-00";
            mtbCpf.Name = "mtbCpf";
            mtbCpf.Size = new Size(116, 23);
            mtbCpf.TabIndex = 2;
            mtbCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 406);
            Controls.Add(mtbCpf);
            Controls.Add(txtCodigo);
            Controls.Add(txtNomeCompleto);
            Controls.Add(txtEmail);
            Controls.Add(mtbDdd);
            Controls.Add(gbxTipoTelefone);
            Controls.Add(btnVoltar);
            Controls.Add(BtnSalvar);
            Controls.Add(ckbFilhos);
            Controls.Add(lblDdd);
            Controls.Add(lblEmail);
            Controls.Add(lblNomeCompleto);
            Controls.Add(lblCpf);
            Controls.Add(lblCodigo);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            gbxTipoTelefone.ResumeLayout(false);
            gbxTipoTelefone.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblCpf;
        private Label lblNomeCompleto;
        private Label lblEmail;
        private Label lblDdd;
        private Label lblTipoTelefone;
        private CheckBox ckbFilhos;
        private Button BtnSalvar;
        private Button btnVoltar;
        private GroupBox gbxTipoTelefone;
        private RadioButton rdbPessoal;
        private RadioButton rdbComercial;
        private RadioButton rdbRecado;
        private MaskedTextBox mtbDdd;
        private TextBox txtEmail;
        private TextBox txtNomeCompleto;
        private TextBox txtCodigo;
        private MaskedTextBox mtbCpf;
    }
}
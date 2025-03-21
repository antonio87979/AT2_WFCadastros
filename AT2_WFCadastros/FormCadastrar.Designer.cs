namespace AT2_WFCadastros
{
    partial class FormCadastrar
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
            lblNomeCategoria = new Label();
            lblObservacao = new Label();
            lblStatus = new Label();
            txtCodigo = new TextBox();
            txtNomeCategoria = new TextBox();
            txtObservacao = new TextBox();
            lblDataCadastro = new Label();
            dtpDataCadastro = new DateTimePicker();
            rdbAtivo = new RadioButton();
            rdbInativo = new RadioButton();
            gbxStatus = new GroupBox();
            btnSalvar = new Button();
            gbxStatus.SuspendLayout();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(213, 43);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(48, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código:";
            // 
            // lblNomeCategoria
            // 
            lblNomeCategoria.AutoSize = true;
            lblNomeCategoria.Location = new Point(33, 43);
            lblNomeCategoria.Name = "lblNomeCategoria";
            lblNomeCategoria.Size = new Size(116, 15);
            lblNomeCategoria.TabIndex = 1;
            lblNomeCategoria.Text = "Nome da Categoria:";
            // 
            // lblObservacao
            // 
            lblObservacao.AutoSize = true;
            lblObservacao.Location = new Point(33, 161);
            lblObservacao.Name = "lblObservacao";
            lblObservacao.Size = new Size(75, 15);
            lblObservacao.TabIndex = 2;
            lblObservacao.Text = "Observação:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(6, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(45, 15);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(213, 61);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 4;
            // 
            // txtNomeCategoria
            // 
            txtNomeCategoria.Location = new Point(33, 61);
            txtNomeCategoria.Name = "txtNomeCategoria";
            txtNomeCategoria.Size = new Size(151, 23);
            txtNomeCategoria.TabIndex = 5;
            // 
            // txtObservacao
            // 
            txtObservacao.Location = new Point(33, 179);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(290, 91);
            txtObservacao.TabIndex = 6;
            // 
            // lblDataCadastro
            // 
            lblDataCadastro.AutoSize = true;
            lblDataCadastro.Location = new Point(33, 100);
            lblDataCadastro.Name = "lblDataCadastro";
            lblDataCadastro.Size = new Size(104, 15);
            lblDataCadastro.TabIndex = 7;
            lblDataCadastro.Text = "Data de Cadastro:";
            // 
            // dtpDataCadastro
            // 
            dtpDataCadastro.Format = DateTimePickerFormat.Short;
            dtpDataCadastro.Location = new Point(33, 118);
            dtpDataCadastro.Name = "dtpDataCadastro";
            dtpDataCadastro.Size = new Size(100, 23);
            dtpDataCadastro.TabIndex = 8;
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(6, 12);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(55, 19);
            rdbAtivo.TabIndex = 9;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(75, 12);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(64, 19);
            rdbInativo.TabIndex = 10;
            rdbInativo.TabStop = true;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // gbxStatus
            // 
            gbxStatus.Controls.Add(lblStatus);
            gbxStatus.Controls.Add(rdbAtivo);
            gbxStatus.Controls.Add(rdbInativo);
            gbxStatus.Location = new Point(181, 110);
            gbxStatus.Name = "gbxStatus";
            gbxStatus.Size = new Size(145, 31);
            gbxStatus.TabIndex = 11;
            gbxStatus.TabStop = false;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(213, 287);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(110, 30);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 329);
            Controls.Add(btnSalvar);
            Controls.Add(gbxStatus);
            Controls.Add(dtpDataCadastro);
            Controls.Add(lblDataCadastro);
            Controls.Add(txtObservacao);
            Controls.Add(txtNomeCategoria);
            Controls.Add(txtCodigo);
            Controls.Add(lblObservacao);
            Controls.Add(lblNomeCategoria);
            Controls.Add(lblCodigo);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            gbxStatus.ResumeLayout(false);
            gbxStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblNomeCategoria;
        private Label lblObservacao;
        private Label lblStatus;
        private TextBox txtCodigo;
        private TextBox txtNomeCategoria;
        private TextBox txtObservacao;
        private Label lblDataCadastro;
        private DateTimePicker dtpDataCadastro;
        private RadioButton rdbAtivo;
        private RadioButton rdbInativo;
        private GroupBox gbxStatus;
        private Button btnSalvar;
    }
}
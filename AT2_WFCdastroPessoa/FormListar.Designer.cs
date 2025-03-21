namespace AT2_WFCadastroPessoa
{
    partial class FormListar
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
            dgvListar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListar).BeginInit();
            SuspendLayout();
            // 
            // dgvListar
            // 
            dgvListar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListar.Dock = DockStyle.Fill;
            dgvListar.Location = new Point(0, 0);
            dgvListar.Name = "dgvListar";
            dgvListar.Size = new Size(464, 282);
            dgvListar.TabIndex = 0;
            // 
            // FormListar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 282);
            Controls.Add(dgvListar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormListar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLista";
            Load += FormListar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListar;
    }
}
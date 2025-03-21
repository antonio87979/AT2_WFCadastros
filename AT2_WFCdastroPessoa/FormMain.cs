using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT2_WFCadastroPessoa
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void mnsListar_Click(object sender, EventArgs e)
        {
            FormListar form = new FormListar();
            form.ShowDialog();
        }

        private void mnsSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Você deseja realmente sair?",
                "Atenção",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                this.Close();
            }          
            
        }

        private void mnsCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastro form = new FormCadastro();
            form.ShowDialog();


        }

        
    }
}

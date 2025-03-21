using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT2_WFCadastros
{
    public partial class FormCadastrar : Form
    {
        public FormCadastrar()
        {
            InitializeComponent();
        }
   
        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Sucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LimparFormulario()
        {
            txtNomeCategoria.Clear();
            txtCodigo.Clear();
            dtpDataCadastro.Value = DateTime.Now;
            rdbAtivo.Checked = false;
            rdbInativo.Checked = false;
            txtObservacao.Clear();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            //Verifica se nome = vazio
            if (string.IsNullOrEmpty(txtNomeCategoria.Text))
            {
                Erro("Campo 'categoria' não pode estar Vazio!");
                return;
            }

            //Verifica se codigo = vazio
            else if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                Erro("Campo 'Código' não pode estar Vazio!");
                return;
            }

            //Verifica se data = vazio
            else if (string.IsNullOrEmpty(dtpDataCadastro.Text))
            {
                Erro("Campo 'Data' não pode estar Vazio!");
                return;
            }

            //Verifica se observação = vazio
            else if (string.IsNullOrEmpty(txtObservacao.Text))
            {
                Erro("Campo 'Observação' não pode estar Vazio!");
                return;
            }

            EStatus Status;
            //Se todos os radios estão desmarcados
            if (!rdbAtivo.Checked && !rdbInativo.Checked)
            {
                Erro("Deve-se marcar se a categoria está ativa!");
                return;
            }
            else
            {
                if (rdbAtivo.Checked)
                    Status = EStatus.Ativo;              
                else
                    Status = EStatus.Inativo;
            }

           

            Categoria cat = new Categoria();
            cat.Codigo = Convert.ToInt32(txtCodigo.Text);
            cat.Nome = txtNomeCategoria.Text;
            cat.DataCadastro = dtpDataCadastro.Text;
            cat.Status = Status;
            cat.Observacao = txtObservacao.Text;

            Categoria.ListaCategorias.Add(cat);
            Sucesso("Categoria Cadastrada com sucesso!");

            LimparFormulario();

        }
    }
}

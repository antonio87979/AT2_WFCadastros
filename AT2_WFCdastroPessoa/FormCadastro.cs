using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT2_WFCadastroPessoa
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
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
            txtCodigo.Clear();
            mtbCpf.Clear();
            txtNomeCompleto.Clear();
            txtEmail.Clear();
            rdbComercial.Checked = false;
            rdbPessoal.Checked = false;
            rdbRecado.Checked = false;
            ckbFilhos.CheckState = CheckState.Indeterminate;

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string semMaskTelefone = mtbDdd.Text
                .Replace("(", "")
                .Replace(")", "")
                .Replace(" ", "")
                .Replace("-", "");           

            //Verifica
            if (string.IsNullOrEmpty(mtbCpf.Text))
            {
                Erro("Campo CPF não pode estar Vazio!");
                return;
            }

            //Verifica
            else if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                Erro("Campo Codigo não pode estar Vazio!");
                return;
            }

            //Verifica
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                Erro("Campo Email não pode estar Vazio!");
                return;
            }
            
            //Verifica
            else if (string.IsNullOrEmpty(txtNomeCompleto.Text))
            {
                Erro("Campo Nome Completo não pode estar Vazio!");
                return;
            }                        

            else if (string.IsNullOrEmpty(semMaskTelefone))
            {
                Erro("Campo DDD/Celular não pode estar Vazio!");
                return;
            }

                ETipoTelefone tipoTelefone;
            //Se todos os radios estão desmarcados
            if (!rdbComercial.Checked && !rdbPessoal.Checked && !rdbRecado.Checked)
            {
                Erro("Deve-se marcar uma opção de Tipo de Telefone!");
                return;
            }
            else
            {
                if (rdbComercial.Checked)
                    tipoTelefone = ETipoTelefone.Comercial;
                else if (rdbPessoal.Checked)
                    tipoTelefone = ETipoTelefone.Pessoal;
                else
                    tipoTelefone = ETipoTelefone.Recado;
            }

            foreach (Pessoas pr in Pessoas.ListaPessoas)
            {
                if (txtCodigo.Text == pr.Codigo.ToString())
                {
                    {
                        Erro("Código já cadastrado!");
                        txtCodigo.Clear();
                        return;
                    }
                }
            }

            Pessoas p1 = new Pessoas();
            p1.Codigo = Convert.ToInt32(txtCodigo.Text);
            p1.NomeCompleto = txtNomeCompleto.Text;
            p1.Cpf = mtbCpf.Text;
            p1.Email = txtEmail.Text;
            p1.TipoTelefone = tipoTelefone;
            p1.Ddd = semMaskTelefone.Substring(0, 2);
            p1.Celular = semMaskTelefone.Substring(2);

            if (ckbFilhos.CheckState == CheckState.Checked)
            {
                p1.PossuiFilhos = true;
            }
            else if (ckbFilhos.CheckState == CheckState.Unchecked)
            {
                p1.PossuiFilhos = false;
            }
            else
            {
                MessageBox.Show("Faltou marcar se tem filhos");
                return;
            }

            Sucesso("Cadastrado com sucesso!");

            Pessoas.ListaPessoas.Add(p1);


        }
    }
}

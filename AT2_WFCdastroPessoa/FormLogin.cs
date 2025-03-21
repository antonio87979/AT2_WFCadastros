using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFCadastroProduto;

namespace AT2_WFCadastroPessoa
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                Erro("Campo usuário não pode estar Vazio!");
                return;
            }
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                Erro("Campo senha não pode estar Vazio!");
                return;
            }
            Usuarios TelaUsuario = new Usuarios();

            foreach (Usuarios user in Usuarios.ListaUsuarios)
            {
                if (user.Login == txtUsuario.Text)
                {
                    if (user.Senha == txtSenha.Text)
                    {
                        MessageBox.Show(
                            "Bem-vindo " + (txtUsuario.Text) + "!",
                            "Sucesso!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );

                        FormPrincipal form = new FormPrincipal();
                        form.ShowDialog();
                        LimparFormulario();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Usuario Não Autenticado!",
                    "Erro!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    LimparFormulario();
                    return;
                }
            }
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
            txtUsuario.Clear();
            txtSenha.Clear();
        }
        private void FormLogin2_Load(object sender, EventArgs e)
        {
             Usuarios us = new Usuarios();
            {
                us.Codigo = 1001;
                us.Login = "sistema";
                us.Senha = "123456";
            }
            Usuarios.ListaUsuarios.Add(us);
        }
    }
}

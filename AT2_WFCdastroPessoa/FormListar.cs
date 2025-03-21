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
    public partial class FormListar : Form
    {
        public FormListar()
        {
            InitializeComponent();
        }

        private void FormListar_Load(object sender, EventArgs e)
        {
            dgvListar.DataSource = Pessoas.ListaPessoas;
        }
    }
}

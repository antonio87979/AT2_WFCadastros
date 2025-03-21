namespace AT2_WFCadastros
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void mnsCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastrar form = new FormCadastrar();
            form.ShowDialog();
        }

        private void mnsListar_Click(object sender, EventArgs e)
        {
            FormListar form = new FormListar();
            form.ShowDialog();
        }
    }
}

using System;
using System.Windows.Forms;

namespace Formulario
{
    public partial class MenuFormulario : Form
    {
        public MenuFormulario()
        {
            InitializeComponent();
        }

        private void tsmiAluno_Click(object sender, System.EventArgs e)
        {
            if (FormularioFechado("AlunoFormulario"))
            {
                AlunoFormulario formulario = new AlunoFormulario();
                formulario.Show();
            }
        }

        private Boolean FormularioFechado(string nome)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form form in fc)
            {
                if (form.Name == nome)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
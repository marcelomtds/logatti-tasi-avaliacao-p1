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

        private void tsmiAluno_Click(object sender, EventArgs e)
        {
            if (FormularioFechado("AlunoFormulario"))
            {
                AlunoFormulario formulario = new AlunoFormulario();
                formulario.Show();
            }
        }

        private void tsmiProfessor_Click(object sender, EventArgs e)
        {
            if (FormularioFechado("ProfessorFormulario"))
            {
                ProfessorFormulario formulario = new ProfessorFormulario();
                formulario.Show();
            }
        }

        private void tsmiCurso_Click(object sender, EventArgs e)
        {
            if (FormularioFechado("CursoFormulario"))
            {
                CursoFormulario formulario = new CursoFormulario();
                formulario.Show();
            }
        }

        private void tsmiCursoProfessor_Click(object sender, EventArgs e)
        {
            if (FormularioFechado("CursoProfessorFormulario"))
            {
                CursoProfessorFormulario formulario = new CursoProfessorFormulario();
                formulario.Show();
            }
        }
    }
}
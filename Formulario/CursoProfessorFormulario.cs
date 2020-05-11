using Dominio;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Formulario
{
    public partial class CursoProfessorFormulario : Form
    {
        private CursoProfessorPersistencia cursoProfessorPersistencia = new CursoProfessorPersistencia();
        private CursoPersistencia cursoPersistencia = new CursoPersistencia();
        private ProfessorPersistencia professorPersistencia = new ProfessorPersistencia();

        private int auxIdCurso = 0, auxIdProfessor = 0;
        public CursoProfessorFormulario()
        {
            InitializeComponent();
            AdicionarBotoesAcao();
            ListarTodos();
            ListarTodosCursos();
            ListarTodosProfessores();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (FormularioInvalido())
            {
                MessageBox.Show("É necessário preencher todos campos obrigatórios.");
            }
            else
            {
                Curso curso = new Curso()
                {
                    Id = int.Parse(cmbCurso.SelectedValue.ToString())
                };
                Professor professor = new Professor()
                {
                    Id = int.Parse(cmbProfessor.SelectedValue.ToString())
                };
                CursoProfessor cursoProfessor = new CursoProfessor()
                {
                    Curso = curso,
                    Professor = professor
                };
                try
                {
                    if (auxIdCurso == 0)
                    {
                        cursoProfessorPersistencia.Inserir(cursoProfessor);
                    }
                    else
                    {

                        Curso cursoAlt = new Curso()
                        {
                            Id = auxIdCurso,
                        };
                        Professor professorAlt = new Professor()
                        {
                            Id = auxIdProfessor,
                        };
                        CursoProfessor cursoProfessorAlt = new CursoProfessor()
                        {
                            Curso = cursoAlt,
                            Professor = professorAlt
                        };

                        cursoProfessorPersistencia.Alterar(cursoProfessorAlt, cursoProfessor);
                    }
                    LimparFormulario();
                    ListarTodos();
                }
                catch (Exception ex)
                {
                    if (ex.ToString().Contains("pk_curso_professor"))
                    {
                        MessageBox.Show($"Já existe um professor ministrando esse curso.");
                    }
                    else
                    {
                        MessageBox.Show($"Ocorreu um erro ao salvar o registro. Erro: {ex.Message}");
                    }
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        private void ListarTodos()
        {
            dgvCursoProfessor.DataSource = null;
            dgvCursoProfessor.DataSource = cursoProfessorPersistencia.ListarTodos();
            dgvCursoProfessor.Columns[2].Width = 350;
            dgvCursoProfessor.Columns[3].Width = 350;
        }

        private void AdicionarBotoesAcao()
        {
            DataGridViewLinkColumn editar = new DataGridViewLinkColumn();
            editar.UseColumnTextForLinkValue = true;
            editar.HeaderText = "Editar";
            editar.LinkBehavior = LinkBehavior.SystemDefault;
            editar.Text = "Editar";
            dgvCursoProfessor.Columns.Add(editar);

            DataGridViewLinkColumn deletar = new DataGridViewLinkColumn();
            deletar.UseColumnTextForLinkValue = true;
            deletar.HeaderText = "Deletar";
            deletar.LinkBehavior = LinkBehavior.SystemDefault;
            deletar.Text = "Deletar";
            dgvCursoProfessor.Columns.Add(deletar);
        }

        private bool FormularioInvalido()
        {
            return cmbProfessor.SelectedItem == null
                || cmbCurso.SelectedItem == null;
        }

        private void LimparFormulario()
        {
            cmbCurso.SelectedItem = null;
            cmbProfessor.SelectedItem = null;
            auxIdCurso = 0;
            auxIdProfessor = 0;
        }

        private void ListarTodosCursos()
        {
            List<Curso> cursos = cursoPersistencia.ListarTodos();
            cursos.ForEach(it =>
            {
                it.Nome = it.ToString();
            });
            cmbCurso.DataSource = cursos;
            cmbCurso.DisplayMember = "Nome";
            cmbCurso.ValueMember = "Id";
            cmbCurso.SelectedItem = null;
        }

        private void ListarTodosProfessores()
        {
            List<Professor> professores = professorPersistencia.ListarTodos();
            professores.ForEach(it =>
            {
                it.Nome = it.ToString();
            });
            cmbProfessor.DataSource = professores;
            cmbProfessor.DisplayMember = "Nome";
            cmbProfessor.ValueMember = "Id";
            cmbProfessor.SelectedItem = null;
        }

        private void dgvCursoProfessor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = (CursoProfessor)dgvCursoProfessor.Rows[e.RowIndex].DataBoundItem;
                if (e.ColumnIndex == 0)
                {
                    CursoProfessor cursoProfessor = cursoProfessorPersistencia.BuscarPorId(row.Curso.Id, row.Professor.Id);
                    cmbCurso.SelectedValue = cursoProfessor.Curso.Id;
                    cmbProfessor.SelectedValue = cursoProfessor.Professor.Id;
                    auxIdCurso = cursoProfessor.Curso.Id;
                    auxIdProfessor = cursoProfessor.Professor.Id;

                }
                else if (e.ColumnIndex == 1)
                {
                    try
                    {
                        cursoProfessorPersistencia.Remover(row.Curso.Id, row.Professor.Id);
                        LimparFormulario();
                        ListarTodos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocorreu um erro ao salvar o registro. Erro: {ex.Message}");

                    }
                }
            }
        }
    }
}

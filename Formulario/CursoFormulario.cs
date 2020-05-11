using Dominio;
using Persistencia;
using System;
using System.Windows.Forms;

namespace Formulario
{
    public partial class CursoFormulario : Form
    {
        private CursoPersistencia cursoPersistencia = new CursoPersistencia();
        public CursoFormulario()
        {
            InitializeComponent();
            AdicionarBotoesAcao();
            ListarTodos(); ;
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
                    Nome = txtNome.Text,
                    CargaHoraria = int.Parse(txtCargaHoraria.Text),
                    HoraInicio = txtHorarioInicio.Text,
                    HoraFim = txtHorarioFim.Text,
                    NumeroSala = int.Parse(txtNumSala.Text),
                };
                try
                {
                    if (string.IsNullOrWhiteSpace(txtId.Text))
                    {
                        cursoPersistencia.Inserir(curso);
                    }
                    else
                    {
                        curso.Id = int.Parse(txtId.Text);
                        cursoPersistencia.Alterar(curso);
                    }
                    LimparFormulario();
                    ListarTodos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao salvar o registro. Erro: {ex.Message}");
                }
            }
        }
        private void ListarTodos()
        {
            dvgCursos.DataSource = null;
            dvgCursos.DataSource = cursoPersistencia.ListarTodos();
            dvgCursos.Columns[3].Width = 180;
            dvgCursos.Columns[7].Width = 150;
            dvgCursos.Columns["Id"].HeaderText = "ID";
            dvgCursos.Columns["CargaHoraria"].HeaderText = "Carga Horária";
            dvgCursos.Columns["HoraInicio"].HeaderText = "Horário Inicial";
            dvgCursos.Columns["HoraFim"].HeaderText = "Horário Final";
            dvgCursos.Columns["NumeroSala"].HeaderText = "Número da Sala";
        }

        private void AdicionarBotoesAcao()
        {
            DataGridViewLinkColumn editar = new DataGridViewLinkColumn();
            editar.UseColumnTextForLinkValue = true;
            editar.HeaderText = "Editar";
            editar.LinkBehavior = LinkBehavior.SystemDefault;
            editar.Text = "Editar";
            dvgCursos.Columns.Add(editar);

            DataGridViewLinkColumn deletar = new DataGridViewLinkColumn();
            deletar.UseColumnTextForLinkValue = true;
            deletar.HeaderText = "Deletar";
            deletar.LinkBehavior = LinkBehavior.SystemDefault;
            deletar.Text = "Deletar";
            dvgCursos.Columns.Add(deletar);
        }

        private bool FormularioInvalido()
        {
            return string.IsNullOrWhiteSpace(txtNome.Text)
                || string.IsNullOrWhiteSpace(txtCargaHoraria.Text)
                || string.IsNullOrWhiteSpace(txtHorarioFim.Text)
                || string.IsNullOrWhiteSpace(txtHorarioInicio.Text)
                || string.IsNullOrWhiteSpace(txtNumSala.Text);
        }

        private void LimparFormulario()
        {
            txtId.Clear();
            txtNome.Clear();
            txtCargaHoraria.Clear();
            txtHorarioFim.Clear();
            txtHorarioInicio.Clear();
            txtNumSala.Clear();
            txtNome.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        private void dvgCursos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                var row = (Curso)dvgCursos.Rows[e.RowIndex].DataBoundItem;
                if (e.ColumnIndex == 0)
                {
                    Curso curso = cursoPersistencia.BuscarPorId(row.Id);
                    txtId.Text = curso.Id.ToString();
                    txtNome.Text = curso.Nome;
                    txtCargaHoraria.Text = curso.CargaHoraria.ToString();
                    txtHorarioInicio.Text = curso.HoraInicio;
                    txtHorarioFim.Text = curso.HoraFim.ToString();
                    txtNumSala.Text = curso.NumeroSala.ToString();

                }
                else if (e.ColumnIndex == 1)
                {
                    try
                    {
                        cursoPersistencia.Remover(row.Id);
                        LimparFormulario();
                        ListarTodos();
                    }
                    catch (Exception ex)
                    {
                        if (ex.ToString().Contains("fk_aluno_curso"))
                        {
                            MessageBox.Show($"Impossível deletar, pois existem alunos ligados a este curso.");
                        }
                        else
                        {
                            MessageBox.Show($"Ocorreu um erro ao remover o registro. Erro: {ex.Message}");
                        }
                    }
                }
            }
        }
    }
}

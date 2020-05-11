using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dominio;
using Persistencia;

namespace Formulario
{
    public partial class AlunoFormulario : Form
    {
        private CursoPersistencia cursoPersistencia = new CursoPersistencia();
        private AlunoPersistencia alunoPersistencia = new AlunoPersistencia();
        public AlunoFormulario()
        {
            InitializeComponent();
            AdicionarBotoesAcao();
            ListarTodos();
            ListarTodosCursos();
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
                Endereco endereco = new Endereco()
                {
                    Logradouro = txtLogradouro.Text,
                    Numero = int.Parse(txtNumero.Text),
                    Cep = txtCep.Text,
                    Bairro = txtBairro.Text,
                    Complemento = txtComplemento.Text,
                    Localidade = txtLocalidade.Text,
                    Uf = txtUf.Text,
                };
                Aluno aluno = new Aluno()
                {
                    Nome = txtNome.Text,
                    Cpf = txtCpf.Text,
                    Telefone = txtTelefone.Text,
                    Ra = txtRa.Text,
                    Email = txtEmail.Text,
                    Endereco = endereco,
                    Curso = curso
                };
                try
                {
                    if (string.IsNullOrWhiteSpace(txtId.Text))
                    {
                        alunoPersistencia.Inserir(aluno);
                    }
                    else
                    {
                        aluno.Id = int.Parse(txtId.Text);
                        aluno.Endereco.Id = int.Parse(txtIdEndereco.Text);
                        alunoPersistencia.Alterar(aluno);
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        private void ListarTodos()
        {
            dgvAlunos.DataSource = null;
            dgvAlunos.DataSource = alunoPersistencia.ListarTodos();
            dgvAlunos.Columns[4].DisplayIndex = 2;
            dgvAlunos.Columns[3].DisplayIndex = 9;
            dgvAlunos.Columns[8].Width = 180;
            dgvAlunos.Columns[9].Width = 350;
            dgvAlunos.Columns[6].Width = 180;
            dgvAlunos.Columns[3].Width = 350;
            dgvAlunos.Columns["Id"].HeaderText = "ID";
            dgvAlunos.Columns["Ra"].HeaderText = "RA";
            dgvAlunos.Columns["Cpf"].HeaderText = "CPF";
            dgvAlunos.Columns["Email"].HeaderText = "E-mail";
            dgvAlunos.Columns["Endereco"].HeaderText = "Endereço";
        }

        private void AdicionarBotoesAcao()
        {
            DataGridViewLinkColumn editar = new DataGridViewLinkColumn();
            editar.UseColumnTextForLinkValue = true;
            editar.HeaderText = "Editar";
            editar.LinkBehavior = LinkBehavior.SystemDefault;
            editar.Text = "Editar";
            dgvAlunos.Columns.Add(editar);

            DataGridViewLinkColumn deletar = new DataGridViewLinkColumn();
            deletar.UseColumnTextForLinkValue = true;
            deletar.HeaderText = "Deletar";
            deletar.LinkBehavior = LinkBehavior.SystemDefault;
            deletar.Text = "Deletar";
            dgvAlunos.Columns.Add(deletar);
        }

        private bool FormularioInvalido()
        {
            return string.IsNullOrWhiteSpace(txtNome.Text)
                || string.IsNullOrWhiteSpace(txtCpf.Text)
                || string.IsNullOrWhiteSpace(txtTelefone.Text)
                || string.IsNullOrWhiteSpace(txtRa.Text)
                || string.IsNullOrWhiteSpace(txtEmail.Text)
                || string.IsNullOrWhiteSpace(txtNumero.Text)
                || string.IsNullOrWhiteSpace(txtCep.Text)
                || string.IsNullOrWhiteSpace(txtBairro.Text)
                || string.IsNullOrWhiteSpace(txtLocalidade.Text)
                || string.IsNullOrWhiteSpace(txtUf.Text)
                || cmbCurso.SelectedItem == null;
        }

        private void LimparFormulario()
        {
            txtId.Clear();
            txtNome.Clear();
            txtCpf.Clear();
            txtTelefone.Clear();
            txtRa.Clear();
            txtEmail.Clear();
            txtIdEndereco.Clear();
            txtNumero.Clear();
            txtCep.Clear();
            txtLogradouro.Clear();
            txtBairro.Clear();
            txtComplemento.Clear();
            txtLocalidade.Clear();
            txtUf.Clear();
            cmbCurso.SelectedItem = null;
            txtNome.Focus();
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

        private void dgvAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = (Aluno)dgvAlunos.Rows[e.RowIndex].DataBoundItem;
                if (e.ColumnIndex == 0)
                {
                    Aluno aluno = alunoPersistencia.BuscarPorId(row.Id);
                    txtId.Text = aluno.Id.ToString();
                    txtNome.Text = aluno.Nome;
                    txtCpf.Text = aluno.Cpf;
                    txtTelefone.Text = aluno.Telefone;
                    txtRa.Text = aluno.Ra;
                    txtEmail.Text = aluno.Email;
                    txtIdEndereco.Text = aluno.Endereco.Id.ToString();
                    txtLogradouro.Text = aluno.Endereco.Logradouro;
                    txtNumero.Text = aluno.Endereco.Numero.ToString();
                    txtCep.Text = aluno.Endereco.Cep;
                    txtBairro.Text = aluno.Endereco.Bairro;
                    txtComplemento.Text = aluno.Endereco.Complemento;
                    txtLocalidade.Text = aluno.Endereco.Localidade;
                    txtUf.Text = aluno.Endereco.Uf;
                    cmbCurso.SelectedValue = aluno.Curso.Id;
                }
                else if (e.ColumnIndex == 1)
                {
                    alunoPersistencia.Remover(row.Id, row.Endereco.Id);
                    LimparFormulario();
                    ListarTodos();
                }
            }
        }
    }
}
using Dominio;
using Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class ProfessorFormulario : Form
    {
        private ProfessorPersistencia professorPersistencia = new ProfessorPersistencia();
        private CursoPersistencia cursoPersistencia = new CursoPersistencia();
        
        public ProfessorFormulario()
        {
            InitializeComponent();
            AdicionarBotoesAcao();
            ListarTodos();;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (FormularioInvalido())
            {
                MessageBox.Show("É necessário preencher todos campos obrigatórios.");
            }
            else
            {
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
                Professor professor = new Professor()
                {
                    Nome = txtNome.Text,
                    Cpf = txtCpf.Text,
                    Telefone = txtTelefone.Text,
                    Salario = decimal.Parse(txtSalario.Text),
                    Email = txtEmail.Text,
                    Endereco = endereco,
                };
                try
                {
                    if (string.IsNullOrWhiteSpace(txtId.Text))
                    {
                        professorPersistencia.Inserir(professor);
                    }
                    else
                    {
                        professor.Id = int.Parse(txtId.Text);
                        professor.Endereco.Id = int.Parse(txtIdEndereco.Text);
                        professorPersistencia.Alterar(professor);
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
            dgvProfessores.DataSource = null;
            dgvProfessores.DataSource = professorPersistencia.ListarTodos();

            dgvProfessores.Columns[7].Width = 350;
            dgvProfessores.Columns[8].Width = 350;

        }

        private void AdicionarBotoesAcao()
        {
            DataGridViewLinkColumn editar = new DataGridViewLinkColumn();
            editar.UseColumnTextForLinkValue = true;
            editar.HeaderText = "Editar";
            editar.LinkBehavior = LinkBehavior.SystemDefault;
            editar.Text = "Editar";
            dgvProfessores.Columns.Add(editar);

            DataGridViewLinkColumn deletar = new DataGridViewLinkColumn();
            deletar.UseColumnTextForLinkValue = true;
            deletar.HeaderText = "Deletar";
            deletar.LinkBehavior = LinkBehavior.SystemDefault;
            deletar.Text = "Deletar";
            dgvProfessores.Columns.Add(deletar);
        }

        private bool FormularioInvalido()
        {
            return string.IsNullOrWhiteSpace(txtNome.Text)
                || string.IsNullOrWhiteSpace(txtCpf.Text)
                || string.IsNullOrWhiteSpace(txtTelefone.Text)
                || string.IsNullOrWhiteSpace(txtSalario.Text)
                || string.IsNullOrWhiteSpace(txtEmail.Text)
                || string.IsNullOrWhiteSpace(txtNumero.Text)
                || string.IsNullOrWhiteSpace(txtCep.Text)
                || string.IsNullOrWhiteSpace(txtBairro.Text)
                || string.IsNullOrWhiteSpace(txtLocalidade.Text)
                || string.IsNullOrWhiteSpace(txtUf.Text);
        }

        private void LimparFormulario()
        {
            txtId.Clear();
            txtNome.Clear();
            txtCpf.Clear();
            txtTelefone.Clear();
            txtSalario.Clear();
            txtEmail.Clear();
            txtIdEndereco.Clear();
            txtNumero.Clear();
            txtCep.Clear();
            txtLogradouro.Clear();
            txtBairro.Clear();
            txtComplemento.Clear();
            txtLocalidade.Clear();
            txtUf.Clear();
            txtNome.Focus();
        }

        private void dgvProfessores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = (Professor)dgvProfessores.Rows[e.RowIndex].DataBoundItem;
                if (e.ColumnIndex == 0)
                {
                    Professor professor = professorPersistencia.BuscarPorId(row.Id);
                    txtId.Text = professor.Id.ToString();
                    txtNome.Text = professor.Nome;
                    txtCpf.Text = professor.Cpf;
                    txtTelefone.Text = professor.Telefone;
                    txtSalario.Text = professor.Salario.ToString();
                    txtEmail.Text = professor.Email;
                    txtIdEndereco.Text = professor.Endereco.Id.ToString();
                    txtLogradouro.Text = professor.Endereco.Logradouro;
                    txtNumero.Text = professor.Endereco.Numero.ToString();
                    txtCep.Text = professor.Endereco.Cep;
                    txtBairro.Text = professor.Endereco.Bairro;
                    txtComplemento.Text = professor.Endereco.Complemento;
                    txtLocalidade.Text = professor.Endereco.Localidade;
                    txtUf.Text = professor.Endereco.Uf;
                }
                else if (e.ColumnIndex == 1)
                {
                    professorPersistencia.Remover(row.Id, row.Endereco.Id);
                    LimparFormulario();
                    ListarTodos();
                }
            }
        }
    }
}

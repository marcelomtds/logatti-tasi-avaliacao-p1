using System.Collections.Generic;
using System.Data.SqlClient;
using Conexao;
using Dominio;

namespace Persistencia
{
    public class AlunoPersistencia
    {
        private SQLServer conexao;
        private EnderecoPersistencia enderecoPersistencia = new EnderecoPersistencia();

        public void Remover(int id, int idEndereco)
        {
            using (conexao = new SQLServer())
            {
                var query = $"DELETE FROM aluno WHERE id = {id}";
                conexao.ExecutarComando(query, false);
            }
            enderecoPersistencia.Remover(idEndereco);
        }
        public void Inserir(Aluno aluno)
        {
            int enderecoId = enderecoPersistencia.Inserir(aluno.Endereco);
            string query = "INSERT INTO aluno (cpf, nome, telefone, email, ra, id_curso, id_endereco) " +
                           $"VALUES ('{aluno.Cpf}', '{aluno.Nome}', '{aluno.Telefone}', '{aluno.Email}', '{aluno.Ra}', {aluno.Curso.Id}, {enderecoId});";
            using (conexao = new SQLServer())
            {
                conexao.ExecutarComando(query, false);
            }
        }

        public void Alterar(Aluno aluno)
        {
            enderecoPersistencia.Alterar(aluno.Endereco);
            string query = "UPDATE aluno " +
                           $"SET cpf = '{aluno.Cpf}', nome = '{aluno.Nome}', telefone = '{aluno.Telefone}', email = '{aluno.Email}', ra = '{aluno.Ra}', id_curso = {aluno.Curso.Id} " +
                           $"WHERE id = {aluno.Id};";
            using (conexao = new SQLServer())
            {
                conexao.ExecutarComando(query, false);
            }
        }

        public Aluno BuscarPorId(int id)
        {
            using (conexao = new SQLServer())
            {
                var sql = "SELECT " +
                             "a.id AS id_aluno, " +
                             "a.cpf AS cpf_aluno, " +
                             "a.nome AS nome_aluno, " +
                             "a.telefone AS telefone_aluno, " +
                             "a.email AS email_aluno, " +
                             "a.ra AS ra_aluno, " +
                             "e.id AS id_endereco, " +
                             "e.logradouro AS logradouro_endereco, " +
                             "e.numero AS numero_endereco, " +
                             "e.cep AS cep_endereco, " +
                             "e.bairro AS bairro_endereco, " +
                             "e.complemento AS complemento_endereco, " +
                             "e.localidade AS localiadade_endereco, " +
                             "e.uf AS uf_endereco, " +
                             "c.id AS id_curso, " +
                             "c.nome AS nome_curso, " +
                             "c.carga_horaria AS carga_horaria_curso, " +
                             "c.horario_inicio AS horario_inicio_curso, " +
                             "c.horario_fim AS horario_fim_curso, " +
                             "c.numero_sala AS numero_sala_curso " +
                          "FROM aluno AS a " +
                             "INNER JOIN endereco AS e ON e.id = a.id_endereco " +
                             "INNER JOIN curso AS c ON c.id = a.id_curso " +
                          $"WHERE a.id = {id};";
                var retorno = conexao.ExecutarComandoComRetorno(sql);
                return CarregarLista(retorno)[0];
            }
        }
        public List<Aluno> ListarTodos()
        {
            using (conexao = new SQLServer())
            {
                var sql = "SELECT " +
                             "a.id AS id_aluno, " +
                             "a.cpf AS cpf_aluno, " +
                             "a.nome AS nome_aluno, " +
                             "a.telefone AS telefone_aluno, " +
                             "a.email AS email_aluno, " +
                             "a.ra AS ra_aluno, " +
                             "e.id AS id_endereco, " +
                             "e.logradouro AS logradouro_endereco, " +
                             "e.numero AS numero_endereco, " +
                             "e.cep AS cep_endereco, " +
                             "e.bairro AS bairro_endereco, " +
                             "e.complemento AS complemento_endereco, " +
                             "e.localidade AS localiadade_endereco, " +
                             "e.uf AS uf_endereco, " +
                             "c.id AS id_curso, " +
                             "c.nome AS nome_curso, " +
                             "c.carga_horaria AS carga_horaria_curso, " +
                             "c.horario_inicio AS horario_inicio_curso, " +
                             "c.horario_fim AS horario_fim_curso, " +
                             "c.numero_sala AS numero_sala_curso " +
                          "FROM aluno AS a " +
                             "INNER JOIN endereco AS e ON e.id = a.id_endereco " +
                             "INNER JOIN curso AS c ON c.id = a.id_curso " +
                          "ORDER BY a.nome ASC;";
                var retorno = conexao.ExecutarComandoComRetorno(sql);
                return CarregarLista(retorno);
            }
        }
        private List<Aluno> CarregarLista(SqlDataReader retorno)
        {
            List<Aluno> cursos = new List<Aluno>();
            while (retorno.Read())
            {
                Curso curso = new Curso()
                {
                    Id = int.Parse(retorno["id_curso"].ToString()),
                    Nome = retorno["nome_curso"].ToString(),
                    CargaHoraria = int.Parse(retorno["carga_horaria_curso"].ToString()),
                    HoraInicio = retorno["horario_inicio_curso"].ToString(),
                    HoraFim = retorno["horario_fim_curso"].ToString(),
                    NumeroSala = int.Parse(retorno["numero_sala_curso"].ToString())
                };
                Endereco endereco = new Endereco()
                {
                    Id = int.Parse(retorno["id_endereco"].ToString()),
                    Logradouro = retorno["logradouro_endereco"].ToString(),
                    Numero = int.Parse(retorno["numero_endereco"].ToString()),
                    Cep = retorno["cep_endereco"].ToString(),
                    Bairro = retorno["bairro_endereco"].ToString(),
                    Complemento = retorno["complemento_endereco"].ToString(),
                    Localidade = retorno["localiadade_endereco"].ToString(),
                    Uf = retorno["uf_endereco"].ToString(),
                };
                Aluno aluno = new Aluno()
                {
                    Id = int.Parse(retorno["id_aluno"].ToString()),
                    Cpf = retorno["cpf_aluno"].ToString(),
                    Nome = retorno["nome_aluno"].ToString(),
                    Telefone = retorno["telefone_aluno"].ToString(),
                    Email = retorno["email_aluno"].ToString(),
                    Ra = retorno["ra_aluno"].ToString(),
                    Endereco = endereco,
                    Curso = curso
                };
                cursos.Add(aluno);
            }
            return cursos;
        }
    }
}

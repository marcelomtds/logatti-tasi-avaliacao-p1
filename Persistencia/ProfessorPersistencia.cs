using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using Conexao;
using Dominio;


namespace Persistencia
{
    public class ProfessorPersistencia
    {
        private SQLServer conexao;
        private EnderecoPersistencia enderecoPersistencia = new EnderecoPersistencia();

        public void Remover(int id, int idEndereco)
        {
            using (conexao = new SQLServer())
            {
                var query = $"DELETE FROM professor WHERE id = {id}";
                conexao.ExecutarComando(query, false);
            }
            enderecoPersistencia.Remover(idEndereco);
        }
        public void Inserir(Professor professor)
        {
            int enderecoId = enderecoPersistencia.Inserir(professor.Endereco);
            string query = "INSERT INTO professor (cpf, nome, telefone, email, salario, id_endereco) " +
                           $"VALUES ('{professor.Cpf}', '{professor.Nome}', '{professor.Telefone}', '{professor.Email}', '{professor.Salario.ToString(CultureInfo.CreateSpecificCulture("en-US"))}', {enderecoId});";
            using (conexao = new SQLServer())
            {
                conexao.ExecutarComando(query, false);
            }
        }

        public void Alterar(Professor professor)
        {
            enderecoPersistencia.Alterar(professor.Endereco);


            string query = "UPDATE professor " +
                           $"SET cpf = '{professor.Cpf}', nome = '{professor.Nome}', telefone = '{professor.Telefone}', email = '{professor.Email}', salario = {professor.Salario.ToString(CultureInfo.CreateSpecificCulture("en-US"))} " +
                           $"WHERE id = {professor.Id};";
            using (conexao = new SQLServer())
            {
                conexao.ExecutarComando(query, false);
            }
        }   

        public Professor BuscarPorId(int id)
        {
            using (conexao = new SQLServer())
            {
                var sql = "SELECT " +
                             "p.id AS id_professor, " +
                             "p.cpf AS cpf_professor, " +
                             "p.nome AS nome_professor, " +
                             "p.telefone AS telefone_professor, " +
                             "p.email AS email_professor, " +
                             "p.salario AS salario_professor, " +
                             "e.id AS id_endereco, " +
                             "e.logradouro AS logradouro_endereco, " +
                             "e.numero AS numero_endereco, " +
                             "e.cep AS cep_endereco, " +
                             "e.bairro AS bairro_endereco, " +
                             "e.complemento AS complemento_endereco, " +
                             "e.localidade AS localiadade_endereco, " +
                             "e.uf AS uf_endereco " +
                          "FROM professor AS p " +
                             "INNER JOIN endereco AS e ON e.id = p.id_endereco " +
                          $"WHERE p.id = {id};";

                var retorno = conexao.ExecutarComandoComRetorno(sql);
                return CarregarLista(retorno)[0];
            }
        }
        public List<Professor> ListarTodos()
        {
            using (conexao = new SQLServer())
            {
                var sql = "SELECT " +
                             "p.id AS id_professor, " +
                             "p.cpf AS cpf_professor, " +
                             "p.nome AS nome_professor, " +
                             "p.telefone AS telefone_professor, " +
                             "p.email AS email_professor, " +
                             "p.salario AS salario_professor, " +
                             "e.id AS id_endereco, " +
                             "e.logradouro AS logradouro_endereco, " +
                             "e.numero AS numero_endereco, " +
                             "e.cep AS cep_endereco, " +
                             "e.bairro AS bairro_endereco, " +
                             "e.complemento AS complemento_endereco, " +
                             "e.localidade AS localiadade_endereco, " +
                             "e.uf AS uf_endereco " +
                          "FROM professor AS p " +
                             "INNER JOIN endereco AS e ON e.id = p.id_endereco " +
                          "ORDER BY p.nome ASC;";
                var retorno = conexao.ExecutarComandoComRetorno(sql);
                return CarregarLista(retorno);
            }
        }
        private List<Professor> CarregarLista(SqlDataReader retorno)
        {
            List<Professor> professores = new List<Professor>();
            while (retorno.Read())
            {
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
                Professor professor = new Professor()
                {
                    Id = int.Parse(retorno["id_professor"].ToString()),
                    Cpf = retorno["cpf_professor"].ToString(),
                    Nome = retorno["nome_professor"].ToString(),
                    Telefone = retorno["telefone_professor"].ToString(),
                    Email = retorno["email_professor"].ToString(),
                    Salario = decimal.Parse(retorno["salario_professor"].ToString()), 
                    Endereco = endereco,
                };
                professores.Add(professor);
            }
            return professores;
        }
    }

}

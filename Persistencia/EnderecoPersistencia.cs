using Conexao;
using Dominio;

namespace Persistencia
{
    public class EnderecoPersistencia
    {
        private SQLServer conexao;

        public void Remover(int id)
        {
            using (conexao = new SQLServer())
            {
                var query = $"DELETE FROM endereco WHERE id = {id};";
                conexao.ExecutarComando(query, false);
            }
        }
        public int Inserir(Endereco endereco)
        {
            string query = "INSERT INTO endereco (logradouro, numero, cep, bairro, complemento, localidade, uf) " +
                           $"VALUES ('{endereco.Logradouro}', {endereco.Numero}, '{endereco.Cep}', '{endereco.Bairro}', '{endereco.Complemento}', '{endereco.Localidade}', '{endereco.Uf}');";
            using (conexao = new SQLServer())
            {
                return conexao.ExecutarComando(query, true);
            }
        }
        public int Alterar(Endereco endereco)
        {
            string query = "UPDATE endereco " +
                           $"SET logradouro = '{endereco.Logradouro}', numero = {endereco.Numero}, cep = '{endereco.Cep}', bairro = '{endereco.Bairro}', complemento = '{endereco.Complemento}', localidade = '{endereco.Localidade}', uf = '{endereco.Uf}' " +
                           $"WHERE id = {endereco.Id};";
            using (conexao = new SQLServer())
            {
                return conexao.ExecutarComando(query, false);
            }
        }
    }
}
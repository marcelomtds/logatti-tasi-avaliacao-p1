using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Conexao
{
    public class SQLServer : IDisposable
    {
        private SqlConnection conexao;
        public SQLServer()
        {
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServerConnection"].ConnectionString);
            conexao.Open();
        }

        public int ExecutarComando(string query, bool retornarIdPersistido)
        {
            if (retornarIdPersistido)
            {
                query += " SELECT SCOPE_IDENTITY();";
            }
            var cmd = new SqlCommand
            {
                CommandText = query,
                CommandType = CommandType.Text,
                Connection = conexao
            };
            var retorno = cmd.ExecuteScalar();
            if (retornarIdPersistido)
            {
                return int.Parse(retorno.ToString());
            }
            else
            {
                return 0;
            }
        }

        public SqlDataReader ExecutarComandoComRetorno(string query)
        {
            return new SqlCommand(query, conexao).ExecuteReader();
        }

        public void Dispose()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
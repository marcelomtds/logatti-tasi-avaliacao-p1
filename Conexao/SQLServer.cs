using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Conexao
{
    class SQLServer : IDisposable
    {
        private SqlConnection conexao;
        public SQLServer()
        {
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLServerConnection"].ConnectionString);
            conexao.Open();
        }

        public void ExecutarComando(string query)
        {
            var cmd = new SqlCommand
            {
                CommandText = query,
                CommandType = CommandType.Text,
                Connection = conexao
            };
            cmd.ExecuteNonQuery();
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
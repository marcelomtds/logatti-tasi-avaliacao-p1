using System.Collections.Generic;
using System.Data.SqlClient;
using Conexao;
using Dominio;

namespace Persistencia
{
    public class CursoPersistencia
    {
        private SQLServer conexao;
        public List<Curso> ListarTodos()
        {
            using (conexao = new SQLServer())
            {
                var sql = "SELECT " +
                             "id, " +
                             "nome, " +
                             "carga_horaria, " +
                             "horario_inicio, " +
                             "horario_fim, " +
                             "numero_sala " +
                          "FROM curso " +
                          "ORDER BY nome ASC;";
                var retorno = conexao.ExecutarComandoComRetorno(sql);
                return CarregarLista(retorno);
            }
        }
        private List<Curso> CarregarLista(SqlDataReader retorno)
        {
            List<Curso> cursos = new List<Curso>();
            while (retorno.Read())
            {
                Curso curso = new Curso()
                {
                    Id = int.Parse(retorno["id"].ToString()),
                    Nome = retorno["nome"].ToString(),
                    CargaHoraria = int.Parse(retorno["carga_horaria"].ToString()),
                    HoraInicio = retorno["horario_inicio"].ToString(),
                    HoraFim = retorno["horario_fim"].ToString(),
                    NumeroSala = int.Parse(retorno["numero_sala"].ToString())
                };
                cursos.Add(curso);
            }
            return cursos;
        }
    }
}
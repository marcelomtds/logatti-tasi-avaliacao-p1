using System.Collections.Generic;
using System.Data.SqlClient;
using Conexao;
using Dominio;

namespace Persistencia
{
    public class CursoPersistencia
    {
        private SQLServer conexao;

        public void Remover(int id)
        {
            using (conexao = new SQLServer())
            {
                var query = $"DELETE FROM curso WHERE id = {id}";
                conexao.ExecutarComando(query, false);
            }
        }
        public void Inserir(Curso curso)
        {
            string query = "INSERT INTO curso (nome, carga_horaria, horario_inicio, horario_fim, numero_sala) " +
                           $"VALUES ('{curso.Nome}', '{curso.CargaHoraria}', '{curso.HoraInicio}', '{curso.HoraFim}', {curso.NumeroSala});";
            using (conexao = new SQLServer())
            {
                conexao.ExecutarComando(query, false);
            }
        }

        public void Alterar(Curso curso)
        {
            string query = "UPDATE curso " +
                           $"SET nome = '{curso.Nome}', carga_horaria = '{curso.CargaHoraria}', horario_inicio = '{curso.HoraInicio}', horario_fim = '{curso.HoraFim}', numero_sala = {curso.NumeroSala} " +
                           $"WHERE id = {curso.Id};";
            using (conexao = new SQLServer())
            {
                conexao.ExecutarComando(query, false);
            }
        }

        public Curso BuscarPorId(int id)
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
                          $"WHERE id = {id};";

                var retorno = conexao.ExecutarComandoComRetorno(sql);
                return CarregarLista(retorno)[0];
            }
        }

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
using Conexao;
using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class CursoProfessorPersistencia
    {
        private SQLServer conexao;

        public void Remover(int idCurso, int idProfessor)
        {
            using (conexao = new SQLServer())
            {
                var query = $"DELETE FROM curso_professor WHERE id_curso = {idCurso} and id_professor = {idProfessor}";
                conexao.ExecutarComando(query, false);
            }
        }
        public void Inserir(CursoProfessor cursoProfessor)
        {
            string query = "INSERT INTO curso_professor (id_curso, id_professor) " +
                           $"VALUES ('{cursoProfessor.Curso.Id}', '{cursoProfessor.Professor.Id}');";
            using (conexao = new SQLServer())
            {
                conexao.ExecutarComando(query, false);
            }
        }

        public void Alterar(CursoProfessor cursoProfessorAlt, CursoProfessor cursoProfessor)
        {
            string query = "UPDATE curso_professor " +
                         $"SET id_curso = '{cursoProfessor.Curso.Id}', id_professor = '{cursoProfessor.Professor.Id}' " +
                         $"WHERE id_curso = {cursoProfessorAlt.Curso.Id} and id_professor = {cursoProfessorAlt.Professor.Id};";
            using (conexao = new SQLServer())
            {
                conexao.ExecutarComando(query, false);
            }
        }

        public CursoProfessor BuscarPorId(int idCurso, int idProfessor)
        {
            using (conexao = new SQLServer())
            {
                var sql = "SELECT " +
                            "cp.id_curso      AS id_curso, " +
                            "cp.id_professor  AS id_professor, " +
                            "c.nome           AS nome_curso, " +
                            "c.carga_horaria  AS carga_horaria_curso, " +
                            "c.horario_inicio AS horario_inicio_curso, " +
                            "c.horario_fim    AS horario_fim_curso, " +
                            "c.numero_sala    AS numero_sala_curso, " +
                            "p.nome           AS nome_professor, " +
                            "p.cpf            AS cpf_professor, " +
                            "p.telefone       AS telefone_professor, " +
                            "p.email          AS email_professor, " +
                            "p.salario        AS salario_professor " +
                          "FROM curso_professor AS cp " +
                             "INNER JOIN professor AS p ON p.id = cp.id_professor " +
                             "INNER JOIN curso AS c ON c.id = cp.id_curso " +
                          $"WHERE cp.id_curso = {idCurso} and cp.id_professor = {idProfessor};";
                var retorno = conexao.ExecutarComandoComRetorno(sql);
                return CarregarLista(retorno)[0];
            }
        }
        public List<CursoProfessor> ListarTodos()
        {
            using (conexao = new SQLServer())
            {
                var sql = "SELECT " +
                            "cp.id_curso      AS id_curso, " +
                            "p.id  AS id_professor, " +
                            "c.nome           AS nome_curso, " +
                            "c.carga_horaria  AS carga_horaria_curso, " +
                            "c.horario_inicio AS horario_inicio_curso, " +
                            "c.horario_fim    AS horario_fim_curso, " +
                            "c.numero_sala    AS numero_sala_curso, " +
                            "p.nome           AS nome_professor, " +
                            "p.cpf            AS cpf_professor, " +
                            "p.telefone       AS telefone_professor, " +
                            "p.email          AS email_professor, " +
                            "p.salario        AS salario_professor " +
                          "FROM curso_professor AS cp " +
                            "INNER JOIN professor AS p ON p.id = cp.id_professor " +
                            "INNER JOIN curso AS c ON c.id = cp.id_curso " +
                          "ORDER BY c.nome, p.nome;";

                var retorno = conexao.ExecutarComandoComRetorno(sql);
                return CarregarLista(retorno);
            }
        }
        private List<CursoProfessor> CarregarLista(SqlDataReader retorno)
        {
            List<CursoProfessor> cursosProfessores = new List<CursoProfessor>();
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

                Professor professor = new Professor()
                {
                    Id = int.Parse(retorno["id_professor"].ToString()),
                    Cpf = retorno["cpf_professor"].ToString(),
                    Nome = retorno["nome_professor"].ToString(),
                    Telefone = retorno["telefone_professor"].ToString(),
                    Email = retorno["email_professor"].ToString(),
                    Salario = decimal.Parse(retorno["salario_professor"].ToString()),
                };

                CursoProfessor cursoProfessor = new CursoProfessor()
                {
                    Curso = curso,
                    Professor = professor,
                };

                cursosProfessores.Add(cursoProfessor);
            }
            return cursosProfessores;
        }
    }
}


namespace Dominio
{
    public class Aluno : Pessoa
    {
        public string Ra { get; set; }
        public Curso curso { get; set; }
    }
}
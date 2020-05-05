namespace Dominio
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }
        public Curso Curso { get; set; }
    }
}
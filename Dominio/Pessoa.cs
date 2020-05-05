namespace Dominio
{
    public abstract class Pessoa
    {
        protected int Id { get; set; }
        protected string Cpf { get; set; }
        protected string Nome { get; set; }
        protected string Telefone { get; set; }
        protected string Email { get; set; }
        protected Endereco Endereco { get; set; }
    }
}
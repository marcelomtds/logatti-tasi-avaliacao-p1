namespace Dominio
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        public override string ToString()
        {
            return $"{Nome} - CPF:{Cpf} - Tel:{Telefone}";
        }
    }
}
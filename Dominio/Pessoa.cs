﻿namespace Dominio
{
    public abstract class Pessoa
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }
    }
}
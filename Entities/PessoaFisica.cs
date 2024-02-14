using Course.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }

        public PessoaFisica(string nome, Telefone telefone, Sexo sexo, string cpf, DateTime dataNascimento) : base(nome, telefone, sexo)
        {
            Cpf = cpf;
            DataNascimento = dataNascimento;
        }

        public override string ToString()
        {
            return $"Name: {Nome}, Telefone: {Telefone}, Sexo: {Sexo}, CPF: {Cpf}, Data de Nascimento: {DataNascimento}";
        }


    }
}

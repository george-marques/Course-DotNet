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
        public Sexo Sexo { get; set; }

        public List<PessoaFisica> Lista { get; set; } = new List<PessoaFisica>();
        public PessoaFisica() { }

        public PessoaFisica(string nome, Telefone telefone, string cpf, DateTime dataNascimento, Sexo sexo) : base(nome, telefone)
        {
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Sexo = sexo;
        }

        public List<PessoaFisica> LerDados()
        {
            Console.Write("\nInforme seu nome: ");
            Nome = Console.ReadLine();

            Telefone = new Telefone();
            Telefone = Telefone.DadosTelefone();

            Console.Write("Selecione o sexo 1- Masculino | 2- Feminino: ");
            Sexo = Enum.Parse<Sexo>(Console.ReadLine());

            Console.Write("Informe o Cpf: ");
            Cpf = Console.ReadLine();

            Console.Write("Informe a data de nascimento: ");
            DataNascimento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("");

            Lista.Add(new PessoaFisica(Nome, Telefone, Cpf, DataNascimento, Sexo));

            return Lista;
        }

        public void ImprimirLista()
        {
            foreach (PessoaFisica item in Lista)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void OrdenarPorNome()
        {
            List<PessoaFisica> resultado = Lista.OrderBy(p => p.Nome).ToList();

            foreach (var item in resultado)
            {
                Console.WriteLine($"{item.ToString()}");
            }

        }

        public override string ToString()
        {
            return $"Name: {Nome}, Telefone: {Telefone}, Sexo: {Sexo}, CPF: {Cpf}, Data de Nascimento: {DataNascimento}";
        }


    }
}

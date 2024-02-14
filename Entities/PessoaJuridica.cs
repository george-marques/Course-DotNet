using Course.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; set; }
        public List<PessoaJuridica> Lista { get; set; } = new List<PessoaJuridica>();

        public PessoaJuridica() { }
        public PessoaJuridica(string nome, Telefone telefone, string cnpj) : base(nome, telefone)
        {
            Cnpj = cnpj;
        }

        public List<PessoaJuridica> LerDados()
        {
            Console.Write("\nInforme a razão social: ");
            Nome = Console.ReadLine();

            Telefone = new Telefone();
            Telefone = Telefone.DadosTelefone();

            Console.Write("Informe o cnpj: ");
            Cnpj = Console.ReadLine();
            Console.WriteLine("");

            Lista.Add(new PessoaJuridica(Nome, Telefone, Cnpj));

            return Lista;
        }

        public void ImprimirLista()
        {
            foreach (PessoaJuridica item in Lista)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", Cnpj: {Cnpj}";
        }

    }
}

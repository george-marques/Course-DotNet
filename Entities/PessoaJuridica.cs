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

        public PessoaJuridica(string nome, Telefone telefone, Sexo sexo, string cnpj) : base(nome, telefone, sexo)
        {
            Cnpj = cnpj;
        }

        public override string ToString()
        {
            return base.ToString() + $", Cnpj: {Cnpj}";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Course.Entities.Enums;

namespace Course.Entities
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public Telefone Telefone { get; set; }

        public Sexo Sexo { get; set; }


        public Pessoa() { }

        public Pessoa(string nome, Telefone telefone, Sexo sexo)
        {
            Nome = nome;
            Telefone = telefone;
            Sexo = sexo;
        }

        public override string ToString()
        {
            return $"Name: {Nome}, Telefone: {Telefone}, Sexo: {Sexo}";
        }


    }
}

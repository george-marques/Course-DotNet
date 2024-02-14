using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal class Telefone
    {
        public int CodigoArea { get; set; }
        public int Numero { get; }
        public Telefone() { }
        public Telefone(int codigoArea, int numero)
        {
            CodigoArea = codigoArea;
            Numero = numero;
        }

        public override string ToString()
        {
            return $"DDD: {CodigoArea}, Número: {Numero}";
        }
    }
}

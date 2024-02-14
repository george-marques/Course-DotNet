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
        public int Numero { get; set; }

        public Telefone() { }
        public Telefone(int codigoArea, int numero)
        {
            CodigoArea = codigoArea;
            Numero = numero;
        }

        public Telefone DadosTelefone()
        {
            Console.Write("Informe o código de área: ");
            CodigoArea = int.Parse(Console.ReadLine());

            Console.Write("Informe o número: ");
            Numero = int.Parse(Console.ReadLine());

            return new Telefone(CodigoArea, Numero);
        }

        public override string ToString()
        {
            return $"DDD: {CodigoArea}, Número: {Numero}";
        }
    }
}

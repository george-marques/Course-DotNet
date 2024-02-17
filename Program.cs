using Course.Entities;

int opc = 0;
PessoaFisica pf = new PessoaFisica();
PessoaJuridica pj = new PessoaJuridica();
List<Pessoa> pessoas = new List<Pessoa>();

do
{
    Console.WriteLine("MENU");
    Console.WriteLine("1- Pessoa Física");
    Console.WriteLine("2- Pessoa Juridica");
    Console.WriteLine("3- Sair");

    Console.Write("Informe a opção: ");
    opc = int.Parse(Console.ReadLine());


    switch (opc)
    {
        case 1:
            Console.WriteLine("\n1- Cadastrar");
            Console.WriteLine("2- Imprimir");
            Console.WriteLine("3- Ordenar");
            Console.Write("Informe a opção: ");
            int opcPf = int.Parse(Console.ReadLine());

            if (opcPf == 1)
            {
                pf.LerDados();
                pessoas.Add(pf);
            }
            else if (opcPf == 2)
            {
                pf.ImprimirLista();
            }
            else
            {
                pf.OrdenarPorNome();
            }

            break;

        case 2:
            Console.WriteLine("\n1- Cadastrar");
            Console.WriteLine("2- Imprimir");
            Console.Write("Informe a opção:");
            int opcPj = int.Parse(Console.ReadLine());

            if (opcPj == 1)
            {
                pj.LerDados();
                pessoas.Add(pj);
            }
            else
            {
                pj.ImprimirLista();
            }

            break;

        case 3:
            foreach (Pessoa item in pessoas)
            {
                Console.WriteLine(item);
            }

            break;

        case 4:
            Console.WriteLine("Saiu.");
            break;

        default:
            Console.WriteLine("Informe um número do Menu.");
            break;
    }

} while (opc != 4);




using System;

namespace Estrutura_condicional_if_else_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("bom dia");
            }
            else if (hora < 18) {
                Console.WriteLine("Boa tarde");
            }
            else
            {
                Console.WriteLine("Boa noite");
            }
        }
    }
}

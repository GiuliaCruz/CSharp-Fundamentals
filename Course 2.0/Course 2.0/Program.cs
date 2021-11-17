using System;
using System.Globalization;

namespace Course_2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade = 27;
            double saldo = 20.35784;
            string nome = "John";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais",nome,idade,saldo);

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais " );
        }
       
    }
}

using System;
using System.Globalization;
namespace Ternary_operator {
    class Program {
        static void Main(string[] args) {

            double preço = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preço < 20.0) ? preço * 0.1 : preço * 0.05;

            Console.WriteLine(desconto);
        }
    }
}

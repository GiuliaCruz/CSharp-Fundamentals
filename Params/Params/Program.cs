using System;

namespace Params {
    class Program {
        static void Main(string[] args) {

            int x = Calculator.Sum( 2, 3 );
            int x2 = Calculator.Sum( 2, 4, 3 );

            Console.WriteLine(x);
            Console.WriteLine(x2);  
        }
    }
}

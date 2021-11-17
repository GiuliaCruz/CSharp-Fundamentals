using System;

namespace Params_ref_e_out {
    class Program {
        static void Main(string[] args) {
            /* ref
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);
            */ 

            /*out*/  
            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);
        }
    }
}

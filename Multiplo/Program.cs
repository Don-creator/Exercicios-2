using System;

namespace Multiplo {
    class Program {
        static void Main (string[] args) {
            int A = 0;

            Console.WriteLine ("Entre com um numero: ");
            A = int.Parse (Console.ReadLine ());

            if (A % 3 == 0) {
                Console.WriteLine ("É multiplo de 3.");
            } else{
                Console.WriteLine("Não é multiplo de 3.");
            }
        }
    }
}    
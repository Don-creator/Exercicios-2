using System;

namespace Valores {
    class Program {
        static void Main (string[] args) {
            int A; 
            int B;
            

            // Seção de Comandos
            Console.WriteLine("Informe o valor da variável A: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da variável B: ");
            B = int.Parse(Console.ReadLine());

            A = A + B;
            B = A - B;
            A = A - B;


            Console.Write("O novo valor de A é: " + (A));
            Console.WriteLine();
            Console.Write("O novo valor de B é: " + (B));
            Console.WriteLine();
            
        }
    }
}
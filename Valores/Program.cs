using System;

namespace Valores {
    class Program {
        static void Main (string[] args) {
            int A = 0; 
            int B = 0;
            // Seção de Comandos
            Console.WriteLine("Informe o valor da variável A: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da variável B: ");
            B = int.Parse(Console.ReadLine());

            Console.Write("O novo valor de A é: " + (B));
            Console.WriteLine();
            Console.Write("O novo valor de B é: " + (A));
            
        }
    }
}
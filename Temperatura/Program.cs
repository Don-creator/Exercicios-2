using System;
namespace Temperatura {
    class Program {
        static void Main (string[] args) {
            int Centigrados = 0;
            int Fahrenheit;
            Console.Write ("Digite a Temperatura em Centígrados: ");
            Centigrados = int.Parse (Console.ReadLine ());
            System.Console.Write ($"A Temperatura em Fahrenheit é: ");
            Console.WriteLine (Fahrenheit = (Centigrados / 5) * 9 + 160);
        }
    }
}
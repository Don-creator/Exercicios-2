using System;
using Zoo.Interfaces;
namespace Zoo.Models {
    class Program {
        static void Main (string[] args) {

            Console.WriteLine("**********************************");
            Console.WriteLine("*************ZOOLOGICO************");
            Console.WriteLine("**********************************");

            int[] Jaula = new int [7];
            int[] Animais = new int[10];
            for (Jaula = 0; Jaula < 7; Jaula++) {
                Console.Write ("Informe o numero da Jaula: ");
                Animais[Jaula] = int.Parse (Console.ReadLine ());
            }
            Array.Sort (Jaula);
            for (Jaula = 0; Jaula >= 0; Jaula--) {
                Console.Write ("\nO " + (Jaula + 1) + "O animal da Jaula é: ");
                Console.Write (Animais[Jaula]);
                Jaula++;
            }
            Console.ReadKey ();
        }
    }
}
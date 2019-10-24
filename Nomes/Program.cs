using System;

namespace Multiplo {
    class Program {
        static void Main (string[] args) {
            string[] Nomes = new string[] {
                "orange",
                "blue",
                "yellow",
                "aqua",
                "red"
            };
            // Chame o método Array.Sort.
            Array.Sort (Nomes);
            foreach(Console.WriteLine (Nomes));
        }
    }
}
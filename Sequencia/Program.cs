using System;

namespace Sequencia {
    class Program {
        static void Main (string[] args) {
            int i;
            int j = 100;
            for (i = 0, Console.WriteLine ($"{i}, {j}"); i < j; i++, j--,
            Console.WriteLine ($"{i}, {j}"));
                }
        }
    }
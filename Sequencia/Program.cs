using System;

namespace Sequencia {
    class Program {
        static void Main (string[] args) {
            int i;
            for (i = 0, Console.WriteLine ($"{i},"); i < 100; i++,
                Console.WriteLine ($"{i}"));
        }
    }
}
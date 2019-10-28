using System;
using System.Collections;

namespace Posições {
    class Program {
        static void Main (string[] args) {
            string[] X = new string[3];
            string[] Y = new string[3];
            string[] R = new string[6];

            for (int i = 0; i < 3; i++) {
                Console.Write ("Digite o valor de X: ", i);
                X[i] = Console.ReadLine ();
                Console.Write ("Digite o valor de Y: ", i);
                Y[i] = Console.ReadLine ();
            }

            for (int y = 0; y < 3; y++) {
                R[y] = X[y];
            }

            int z = 3;
            for (int i = 0; i < 3; i++) {
                R[z] = Y[i];
                z++;
            }

            for (int i = 0; i < 6; i++) {
                Console.WriteLine (R[i]);
            }
            Console.ReadKey ();
        }
    }
}
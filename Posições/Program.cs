using System;

namespace Posições {
    class Program {
        static void Main (string[] args) {
            int[] array = new int[5];

            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;
            array[5] = 6;

            foreach (int valor in array)
            {

                Console.WriteLine (valor.ToString ());

            }

        }
    }
}
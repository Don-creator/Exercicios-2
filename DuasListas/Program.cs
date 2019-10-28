using System;
using System.Collections.Generic;

namespace DuasListas {
    class Program {
        static void Main (string[] args) {
            Random random = new Random ();

            int[] N = new int[10];
            

            for (int i = 1; i < 10; i++) {
                N[i] = random.Next(0, 100);
            }

            List<int> listNumImpar = new List<int>();
            List<int> listNumPar= new List<int>();
            
            foreach (int item in N)
            {
                if (item % 2 != 0)
                {
                    listNumPar.Add(item);
                } else {
                    listNumImpar.Add(item);
                }
        }
        foreach (int item in listNumPar)
        {
            Console.WriteLine($"Esses são os numeros Par. {item}");
        }
        foreach (int item in listNumImpar)
        {
            Console.WriteLine($"Esses são os numeros Impar. {item}");
            }
        }
    }
}
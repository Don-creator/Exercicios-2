using System;

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vetor = new int[5];
            for (int x = 10; x > 0; x--)
            {
                for (int y = 0; y < x; y++){
                    Console.Write($"*");
                }
                Console.ReadLine();
                
            }
        }
    }
}

using System;

namespace Perimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            double Base = 0;
            double Altura = 0;
            double Perimetro = 0;
            double Area = 0; 

            Console.WriteLine("Entre com a Base: ");
            Base = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a Altura: ");
            Altura = double.Parse(Console.ReadLine());
            Console.Clear();
            
            Perimetro = (Altura * 2) + (Base * 2);
            Area = (Altura*Base);
            Console.WriteLine("O Perimetro do retangulo é: " + Perimetro);
            Console.WriteLine("A Area do retangulo é: " + Area);
            
            
        }
    }
}

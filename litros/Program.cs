using System;

namespace litros
{
    class Program
    {
        static void Main(string[] args)
        {
            int Distancia = 0;
            int Tempo = 0;
            int Velocidade = 0;
            int LitrosUsados = 0;
            int Km = 12;



            Console.WriteLine("Qual o Tempo gasto na viagem: ");
            Tempo = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a velocidade media do Veiculo: ");
            Velocidade = int.Parse(Console.ReadLine());

            Distancia = (Tempo * Velocidade);
            LitrosUsados = (Distancia / Km);
            Console.WriteLine("A distancia da viagem é: " + Tempo * Velocidade);
            Console.WriteLine("Os litros usados foram: " + LitrosUsados);
            
        }
    }
}

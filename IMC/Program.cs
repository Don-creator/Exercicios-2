using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double Peso;
            double Altura;
            double Imc;

            Console.WriteLine("Qual seu Peso em kg: ");
            Peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual sua altura em metros: ");
            Altura = double.Parse(Console.ReadLine());

            Imc = Peso/(Altura * Altura);

            Console.WriteLine("O seu Imc é " + Imc);

        
            if(Imc < 20){
                Console.WriteLine("Abaixo do peso");
            } else 
            if((Imc >= 20)&&(Imc<=25)){
                Console.WriteLine("Normal");
            } else 
            if((Imc>= 25)&&(Imc<=30)){
                Console.WriteLine("Excesso de peso");
            } else 
            if((Imc >= 30)&&(Imc<=35)){
                Console.WriteLine("Obesidade");
            } else 
            if((Imc >= 35)){
                Console.WriteLine("Obesidade mórbida");
            }
            

        }
    }
}

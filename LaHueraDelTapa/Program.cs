using System;

namespace LaHueraDelTapa {
    class Program {
        static void Main (string[] args) {

            int Menu;
            int Hora = 0;

            Console.WriteLine ("==============================");
            Console.WriteLine ("        TAPA NA PANTERA!");
            Console.WriteLine ("==============================");

            Console.WriteLine (" 1 - Iniciar o Tapa");
            Console.WriteLine ("0 - Fechar o Tapa");
            Menu = int.Parse (Console.ReadLine ());

            Console.Clear ();


            Console.WriteLine ("Qual é a Hora do tapa: ");
            Hora = int.Parse (Console.ReadLine ());

            Console.Clear ();

            if (Hora == 16) {
                Console.WriteLine ("Está na HORA DO TAPA. ");
            } else {
                Console.WriteLine ("Não está na HORA DO TAPA. ");
            }

            switch (Menu) {
                case 1:
                    Console.WriteLine ();
                    Console.WriteLine ("Aperte 1 para prosseguir");

                    break;

                case 0:
                    Console.WriteLine ();
                    Console.WriteLine ("Aperte 0 para fechar");
                    break;
                default:
                    break;
            }


        }
    }
}
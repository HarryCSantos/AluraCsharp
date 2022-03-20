using System;

namespace P13_Forencadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 13");

            for(int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for(int contadorColuna = 0; contadorColuna <10; contadorColuna++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}

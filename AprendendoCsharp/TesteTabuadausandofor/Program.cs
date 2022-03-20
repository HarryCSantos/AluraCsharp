using System;

namespace TesteTabuadausandofor
{
    class Programs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando - Tabuada");

            for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                for (int contador = 0; contador <= 10; contador++)
                {
                    Console.WriteLine(multiplicador + " * " + contador + " = " + multiplicador * contador);
                }
            }

        }
    }
}

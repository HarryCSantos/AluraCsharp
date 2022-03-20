using System;

namespace P12_CalculaInvestimentoALongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12");

            double fatorRendimento = 1.0036;

            for(int contadorAno = 1; contadorAno <= 5; contadorAno ++)
            {
                fatorRendimento += 0.0010;
            }

            Console.ReadLine();
        }
    }
}

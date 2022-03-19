using System;

namespace CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula Poupança");

            double valorInvestido = 1000;

            //0.36 = 0.0036
            valorInvestido = valorInvestido + valorInvestido * 0.0036;

            Console.ReadLine();
        }
    }
}

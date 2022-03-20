using System;

namespace P_11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 11 - Calculando Poupança");

            double valorInvestido = 1000;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                //valorInvestido = valorInvestido + valorInvestido * 1.0036;
                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$ " + valorInvestido);

            }




            Console.ReadLine();
        }
    }
}

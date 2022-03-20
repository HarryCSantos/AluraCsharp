using System;

namespace CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula Poupança");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$ " + valorInvestido);

                //contadorMes = contadorMes + 1;
                //contadorMes += 1; --> o contadorMes++; incrementa mais um e guarda na variável
                contadorMes++; 
            }
                

            


            Console.ReadLine();
        }
    }
}

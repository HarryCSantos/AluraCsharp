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
                
                //Ao executarmos o código, conseguiremos manter o mesmo comportamento. E agora que só lidamos com valorInvestido e estamos guardando na variável o resultado de uma conta com apenas um operador, podemos substitui-lo por *=. Com isso, o valor da variável será multiplicado por 1.0036 e será guardado novamente em valorInvestido.

                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$ " + valorInvestido);

            }




            Console.ReadLine();
        }
    }
}

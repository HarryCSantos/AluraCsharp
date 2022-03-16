using System;

namespace _9._03_Funcionariopromovido
{
    class Program
    {
        static void Main(string[] args)
        {

            double salario = 4200;

            bool foiPromovido = true;

            Console.WriteLine("Execundo o programa de promoção de funcionários");

            if (salario >=4300)
            {
                Console.WriteLine("Parabésn você foi promovido! O teu salário agora é: " + salario);
            }
            else
            {
                Console.WriteLine("Infelizmente você não foi promovido!");
            }
        }
    }
}

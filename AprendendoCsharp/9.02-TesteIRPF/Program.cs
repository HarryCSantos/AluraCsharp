using System;

namespace _9._02_TesteIRPF
{
    class Program
    {
        static void Main(string[] args)
        {

            double salario = 3300.0;

            if(salario < 2600.0)
            { 
                Console.WriteLine("A sua aliquota é de 15 %");
                Console.WriteLine("Você pode deduzir até R$ 350");
            }

            if (salario < 3750.0)
            {
                Console.WriteLine("A sua aliquota é  de 22,5%");
                Console.WriteLine("Você pode deduzir até R$ 636");
            }
        }
    }
}

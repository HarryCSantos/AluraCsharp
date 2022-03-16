using System;

namespace _9._02_TesteIRPF
{
    class Program
    {
        static void Main(string[] args)
        {

            double salario = 3300.0;

            if(salario < 2600.0)
                Console.WriteLine("A sua aliquota é de 15 %");
            Console.WriteLine("Você pode deduzir até R$ 350");
        }
    }
}

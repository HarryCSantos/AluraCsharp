using System;

namespace _9._05_AliquotaComIfs
{
    class Program
    {
        static void Main(string[] args)
        {
            // De 1900.0 até 2800.0 o IR é de 7.5% e pode deduzir R$ 142
            // De 2800.01 até 3751.0 o IR é de 15% e pode deduzir R$ 350
            // De 3751.01 até 4664.00 o IR é de 22.5% e pode deduzir R$ 636

           double salario = 4665.0;

            if (salario >= 1900.0 && salario <= 2800.0 )
            {
                //double aliquota = 7.5;
                double deducao1 = (salario - 142);
                Console.WriteLine("A sua aliquota é de 7%");
                Console.WriteLine("O valor final do seu salário após deduçao do imposto de renda é = R$ " + deducao1);
            }else
            if (salario >= 2800.01 && salario <= 3751.0)
            {
                double deducao2 = (salario - 350);
                Console.WriteLine("A sua aliquota é de 15%");
                Console.WriteLine("O valor final do seu salário após deduçao do imposto de renda é = R$ " + deducao2);
            }else
            if (salario >= 3751.01 && salario <= 4664.00)
            {
                double deducao3 = (salario - 636);
                Console.WriteLine("A sua aliquota é de 22.5%");
                Console.WriteLine("O valor final do seu salário após deduçao do imposto de renda é = R$ " + deducao3);
            }else
            {
                Console.WriteLine("Agradeça a Deus, você não declara imposto de renda! ");
            }
            Console.WriteLine("O Programa foi finalizado pressione ENTER para sair...");

            Console.ReadLine();
        }
    }
}

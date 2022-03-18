using System;

namespace _9._05_AliquotaComIfs
{
    class Program
    {
        static void Main(string[] args)
        {

           double salario = 3300.0;

            if (salario >= 1900.0 && salario <= 2800.0 )
            {
                //double aliquota = 7.5;
                double deducao1 = (salario - 142);
                Console.WriteLine("A dedução do seu imposto de senda será: " + deducao1);
            }
           

        }
    }
}

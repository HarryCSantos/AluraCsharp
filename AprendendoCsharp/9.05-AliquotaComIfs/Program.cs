﻿using System;

namespace _9._05_AliquotaComIfs
{
    class Program
    {
        static void Main(string[] args)
        {

            double salario = 3300.0;

            if (salario >= 1900.0 && salario <= 2800.0)
            {
                Console.WriteLine("Seu imposto de Renda é de 7.5% e pode deduzir na declaração o valor de R$ 142,00");
            }

            if (salario >=2800.01 && salario <=3751.0)
            {
                Console.WriteLine("Seu imposto de Renda é de 22.5% e pode deduzir na declaração o valor de R$ 350,00");
            }

            if (salario >=3751.01 && salario)
            {

            }
            


            Console.WriteLine("Testando Alíquota com Ifs!");

        }
    }
}

﻿using System;

namespace _9._04_TestaEscopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando condicionais");

            int idade = 20;
            int quantidadePessoas = 3;
            bool acompanhado = true;

            if (quantidadePessoas >= 2)
            {
                 acompanhado = true;
            }
            else
            {
                 acompanhado = false;
            }
            if (idade >=18 || acompanhado)
            {
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
                Console.WriteLine("Infelizmente voce não pode entrar");
            }
        }
    }
}

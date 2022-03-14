using System;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prática Escopo - Testando Condicional2");

            int idade= 18;
            int quantidadePessoas = 1;
            bool acompanhado = quantidadePessoas >=2;
            //Dessa forma, nossa variável booleana terá valor true quando quantidadePessoas for maior ou igual a 2, e terá valor false quando ocorrer o contrário.

            //if (idade >=18 || quantidadePessoas >=2)
            if (idade >=18 && acompanhado)
            {
                Console.WriteLine("Seja bem vindo!");
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode entrar!");
            }

        }
    }
}

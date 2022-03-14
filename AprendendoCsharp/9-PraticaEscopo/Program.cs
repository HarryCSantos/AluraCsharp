using System;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prática Escopo - Testando Condicional2");

            int idade= 16;
            //int quantidadePessoas = 3;
            bool acompanhado = true;
            
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

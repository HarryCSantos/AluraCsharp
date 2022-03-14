using System;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais 2");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18 || quantidadePessoas >= 2)
            {
                Console.WriteLine("João possui mais de 18 anos de idade. Pode entrar.");
            }
            else
            {
                if(quantidadePessoas >= 2)
                {
                    Console.WriteLine("João não possui mais de 18 anos, mas está acompanhado. Pode entrar");

                }
                else
                {
                    Console.WriteLine("João não possui mais de 18 anos e também não está acompanhado, portanto não pode entrar");
                }
            }

            Console.ReadLine();  
        }
    }
}

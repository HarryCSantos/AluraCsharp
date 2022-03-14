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

            if (idadeJoao >= 18 && quantidadePessoas >= 2)
            {
                Console.WriteLine("Pode entrar.");
            }
            

                
                else
                {
                    Console.WriteLine("Não pode entrar");
                }
            }

            Console.ReadLine();  
        }
    }
}

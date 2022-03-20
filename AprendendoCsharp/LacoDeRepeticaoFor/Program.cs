using System;

namespace LacoDeRepeticaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Programa Laço de repetição for");

            for (int linha = 0; linha < 10; linha++)
            {
                for(int coluna = 0; coluna < 10; coluna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(); 
            }

            

        }
    }
}

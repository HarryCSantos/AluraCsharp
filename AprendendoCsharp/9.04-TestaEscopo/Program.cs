using System;

namespace _9._04_TestaEscopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando condicionais");

            int idade = 20;
            int quantidadePessoas = 3;
            //bool acompanhado = true;

            if (quantidadePessoas >= 2)
            {
                bool acompanhado = true;
            }
            else
            {
                bool acompanhado = false;
            }
        }
    }
}

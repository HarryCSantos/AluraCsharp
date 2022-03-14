using System;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Escopo");

            int idadeJoao = 18;
            bool acompanhado = false;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "João está acompanhado!";

            }
            else
            {
                mensagemAdicional = "João não está acompanhado";
            }

            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entrar.");
                    Console.WriteLine(mensagemmAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar");
                    Console.WriteLine(mensagemmAdicional);
            }

            Console.ReadLine();
            
        }
    }
}

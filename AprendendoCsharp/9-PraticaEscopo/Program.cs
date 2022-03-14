using System;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prática Escopo - Testando Condicional2");

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
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar");
                Console.WriteLine(mensagemAdicional);
            }

            Console.ReadLine();

        }
    }
}

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

            string mensagemmAdicional;

            if (acompanhado == true)
            {
                mensagemmAdicional = "João está acompanhado!";

            }
            else
            {
                mensagemmAdicional = "João não está acompanhado";
            }
            
        }
    }
}

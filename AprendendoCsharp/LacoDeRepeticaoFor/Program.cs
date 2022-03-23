using System;

/*class Programa
{
    static void Main(String [] args)
    {
        for (int i = 1; i < 100; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);

            }
        }
    }
}*/

// Ou pode usar a primeira dentre as muitas opções
class Programa
{
    static void Main(String [] args)
    {
        for (int i = 3; i < 100; i += 3)
        {
            Console.WriteLine(i);
        }
    }
}
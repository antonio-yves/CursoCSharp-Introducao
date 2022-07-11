using System;

class Program
{
    static void Main(string[] args)
    {
        // Imprimir os fatoriais de 1 a 10!

        for (int i = 1; i <= 10; i++)
        {
            int fatorial = 1;
            for (int j = 1; j <= i; j++)
            {
                fatorial *= j;
            }
            Console.WriteLine(@"{0}! = {1}", i, fatorial);
        }
    }
}
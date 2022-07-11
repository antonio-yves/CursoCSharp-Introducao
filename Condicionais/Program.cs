using System;

class Program
{
    static void Main(string[] args)
    {
        int Idade = 16;

        if (Idade >= 18)
        {
            Console.WriteLine("Pode entrar!");
        }
        else if ((Idade < 18) && (Idade >= 14))
        {
            Console.WriteLine("Pode entrar acompanhado!");
        }
        else
        {
            Console.WriteLine("Não pode entrar!");
        }
    }
}
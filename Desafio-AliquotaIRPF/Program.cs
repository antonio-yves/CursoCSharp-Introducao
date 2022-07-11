using System;

class Program
{
    static void Main(string[] args)
    {
        double Salario = 3300.0;

        if ((Salario >= 1900.0) && (Salario <= 2800.0))
        {
            Console.WriteLine("A sua aliquota é de 7.5%");
            Console.WriteLine("Você pode deduzir até R$ 142");
        }
        else if ((Salario >= 2800.01) && (Salario <= 3751.0))
        {
            Console.WriteLine("A sua aliquota é de 15%");
            Console.WriteLine("Você pode deduzir até R$ 350");
        }
        else if ((Salario >= 3751.01) && (Salario <= 4664.0))
        {
            Console.WriteLine("A sua aliquota é de 22.5%");
            Console.WriteLine("Você pode deduzir até R$ 636");
        }
    }
}
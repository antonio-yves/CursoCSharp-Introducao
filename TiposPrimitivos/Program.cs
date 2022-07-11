using System;

class Program
{
    static void Main(string[] args)
    {
        // Tipos de dados primitivos

        // Tipo short armazena números inteiros de até 16 bits (2 Bytes)
        short Ano = 1969;

        // Tipo int armazena números inteiros de até 32 bits (4 Bytes)
        int Idade = 10;

        // Tipo long armazena números inteiros de até 64 bits (8 Bytes)
        long IdadeDaTerra = 4543000000000;

        // Tipo float armazena números de ponto flutuante de até 32 bits (4 Bytes)
        float Preco = 10.99f;

        // Tipo double armazena números de ponto flutuante de até 64 bits (8 Bytes)
        double Salario = 1500.99;

        // Tipo decimal armazena números de ponto flutuante de até 128 bits (16 Bytes)
        decimal Pi = 3.14159M;

        // Tipo char armazena caracteres da tabela ASCII utilizando 2 Bytes (16 bits)
        char Letra = 'A';

        // Tipo bool armazena true ou false utilizando 1 Byte (8 bits)
        bool Status = false;

        Console.WriteLine("Tipo short: " + Ano);
        Console.WriteLine("Tipo int: " + Idade);
        Console.WriteLine("Tipo long: " + IdadeDaTerra);
        Console.WriteLine("Tipo float: " + Preco);
        Console.WriteLine("Tipo double: " + Salario);
        Console.WriteLine("Tipo decimal: " + Pi);
        Console.WriteLine("Tipo char: " + Letra);
        Console.WriteLine("Tipo bool: " + Status);
    }
}
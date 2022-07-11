using System;

class Program
{
    static void Main(string[] args)
    {
        string Texto = "Cursos da Alura - 2022";
        string Cursos = @"
- C#;
- Python;
- Java;
- Ruby;
- Go;
- JavaScript;
- TypeScript;
- C++;
";
        Console.WriteLine(Texto + Cursos);
    }
}
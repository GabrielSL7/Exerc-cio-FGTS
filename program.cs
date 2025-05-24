using System;

class Program
{
    static void Main()
    {
        Console.Write("Salário (R$)..: ");
        double salario = double.Parse(Console.ReadLine()!);

        double fgts = salario * 0.08;

        Console.WriteLine($"FGTS: R$ {fgts:F2}");
    }
}

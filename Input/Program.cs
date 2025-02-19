using System;
using lab_9;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значения a:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значения b:");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значения c:");
        double c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значения x:");
        double x = Convert.ToDouble(Console.ReadLine());

        double result = MathFunctions.Result(a, b, c, x);
        Console.WriteLine($"Результат: {result}\n");
    }
}

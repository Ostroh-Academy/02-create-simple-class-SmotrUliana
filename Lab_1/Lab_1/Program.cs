using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        SinFunction sinFunction = new SinFunction();


        Console.Write("Введіть значення параметра a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введіть значення параметра b: ");
        double b = double.Parse(Console.ReadLine());

        sinFunction.SetParameters(a, b);

        Console.Write("Введіть значення x: ");
        double x = double.Parse(Console.ReadLine());

        double functionValue = sinFunction.Compute(x);
        Console.WriteLine($"Значення функції при x={x}: {functionValue}");

        if (sinFunction.IsMaxAtX(x))
        {
            Console.WriteLine($"Функція sin({a}x+{b}) приймає найбільше значення у точці x={x}.");
        }
        else
        {
            Console.WriteLine($"Функція sin({a}x+{b}) не приймає найбільше значення у точці x={x}.");
        }
    }
}
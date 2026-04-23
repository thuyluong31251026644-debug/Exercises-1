using System;

class Program
{
    static void Main()
    {
        double c = 25;
        double f = (c * 9 / 5) + 32;
        Console.WriteLine("Fahrenheit = " + f);

        double c2 = (f - 32) * 5 / 9;
        Console.WriteLine("Celsius = " + c2);
    }
}

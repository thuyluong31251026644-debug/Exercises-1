using System;
class Program
{
    static void Main()
    {
        int a = 3, b = 4;
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine("a = " + a + ", b = " + b);
    }
}
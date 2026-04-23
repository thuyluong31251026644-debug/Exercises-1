using System;

class Program
{
    static void Main()
    {
        int days = 500;

        int years = days / 365;
        int weeks = (days % 365) / 7;
        int remainingDays = (days % 365) % 7;

        Console.WriteLine("Years: " + years);
        Console.WriteLine("Weeks: " + weeks);
        Console.WriteLine("Days: " + remainingDays);
    }
}

using System;

class Introduction_to_CSharp
{
    public static void Main() {
        int minutes;
        int seconds;
        Console.WriteLine("enter the minutes");
        Int32.TryParse(Console.ReadLine(), out minutes);
        Console.WriteLine("enter the seconds");
        Int32.TryParse(Console.ReadLine(), out seconds);
        Console.WriteLine("speed (m/s)= " + Math.Round(10000.0f / (minutes * 60 + seconds), 2));
        Console.WriteLine("speed (mph)= " + Math.Round(6.21371f * 60 / (minutes + (seconds) / 60)));


        int integer;
        int tableRows;
        Console.WriteLine("enter an integer");
        Int32.TryParse(Console.ReadLine(), out integer);
        Console.WriteLine("enter the table rows");
        Int32.TryParse(Console.ReadLine(), out tableRows);
        Console.WriteLine($"Multiplication table for {integer} up to multiple {tableRows}:");
        for (int i = 1; i <= tableRows; i++)
        {
            Console.WriteLine(integer * i);
        }

        int radius;
        Console.WriteLine("enter radius");
        Int32.TryParse(Console.ReadLine(), out radius);
        Console.WriteLine($"area is {Math.Round(Math.Pow(radius, 2) * Math.PI, 2)} and circumference is {Math.Round(radius * 2 * Math.PI, 2)}");
    }
}
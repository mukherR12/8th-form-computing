using System;

class Introduction_to_CSharp
{
    public static void Main() {
        RunnerSpeed();
        FormatTime();
        MultiplicationTable();
        CircleFacts();
        FindPi();
    }

    private static void RunnerSpeed()
    {
        int minutes;
        int seconds;
        Console.WriteLine("Question 1:");
        Console.WriteLine("enter the minutes taken");
        if  (!Int32.TryParse(Console.ReadLine(), out minutes))
        {
            Console.WriteLine("Could not parse minutes as integer!");
        }
        else
        {
            Console.WriteLine("enter the seconds taken");
            if (!Int32.TryParse(Console.ReadLine(), out seconds))
            {
                Console.WriteLine("Could not parse seconds as integer!");
            }
            else
            {
                Console.WriteLine("speed (m/s)= " + Math.Round(10000.0f / (minutes * 60 + seconds), 2));
                Console.WriteLine("speed (mph)= " + Math.Round(6.21371f * 60 / (minutes + (seconds) / 60)));
            }
        }
    }

    private static void FormatTime()
    {
        Console.WriteLine("Question 2: ");
        Console.WriteLine("enter the seconds");
        int seconds;
        if (!Int32.TryParse(Console.ReadLine(), out seconds))
        {
            Console.WriteLine("Could not parse seconds as integer!");
        }
        else
        {
            TimeSpan timespan = TimeSpan.FromSeconds(seconds);
            Console.WriteLine(timespan.ToString());
        }
    }

    private static void MultiplicationTable()
    {
        Console.WriteLine("Question 3: ");
        int integer;
        int tableRows;
        Console.WriteLine("enter an integer");
        if (!Int32.TryParse(Console.ReadLine(), out integer))
        {
            Console.WriteLine("Could not parse integer as integer!");
        }
        else
        {
            Console.WriteLine("enter the number of table rows");
            if (!Int32.TryParse(Console.ReadLine(), out tableRows))
            {
                Console.WriteLine("Could not parse number of rows as integer!");
            }
            else
            {
                Console.WriteLine($"Multiplication table for {integer} up to multiple {tableRows}:");
                Console.WriteLine(String.Format("| {0,tableRows+1} | {1, integer*tableRows} |", "integer", "multiple"));
                for (int i = 1; i <= tableRows; i++)
                {
                    Console.WriteLine(String.Format("| {0,tableRows+1} | {1, integer*tableRows} |", i, integer*i));
                }
            }
        }
    }

    private static void CircleFacts()
    {
        Console.WriteLine("Question 4: ");
        double solveRadiusfromArea(double area)
        {
            return Math.Sqrt(area / Math.PI);
        }
        double solveRadiusfromCircumference(double circumference)
        {
            return (circumference / Math.PI) / 2;
        }

        double getArea(double radius)
        {
            return radius * radius * Math.PI;
        }

        double getCircumference(double radius)
        {
            return radius * 2 * Math.PI;
        }
        Console.WriteLine("Enter whether you want to input the Area, Circumference or Radius [a/c/r]: ");
        string userChoice = Console.ReadLine();
        Console.WriteLine("enter your data value:");
        if (!double.TryParse(Console.ReadLine(), out double data) && (new []{"a", "b", "c"} ).Contains(userChoice))
        {
            Console.WriteLine("Invalid choice or data!");
        }
        else
        {
            if (userChoice == "a")
            {
                Console.WriteLine($"radius is {solveRadiusfromArea(data)}, circumference is {getCircumference(solveRadiusfromArea(data))}");
            }
            else if (userChoice == "c")
            {
                Console.WriteLine($"radius is {solveRadiusfromCircumference(data)}, area is {getArea(solveRadiusfromCircumference(data))}");
            }
            else
            {
                Console.WriteLine($"area is {getArea(data)}, circumference is {getCircumference(data)}");
            }
        }
    }

    private static void FindPi()
    {
        int numInCircle = 0;
        int numInSquare = 0;
        for (int i=0; i<9999999; i++)
        {
            Random rnd = new Random();
            double[] myNum = {rnd.NextDouble(), rnd.NextDouble()};
            if (myNum[0] * myNum[0] + myNum[1] * myNum[1] <= 1)
            {
                numInCircle++;
            }
            numInSquare++;
            if (i / 1000 == 1)
            {
                Console.WriteLine(i);
            }
        }
        Console.WriteLine(((double)numInCircle / (double)numInSquare)*4);
    }
}
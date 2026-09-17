
class Selection
{
    public static void Main()
    {
        //TriangleType();
        CampEligibility();
    }

    private static void TriangleType()
    {
        double[] lengths = new double[5];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Enter length {i}");
            while (!double.TryParse(Console.ReadLine(), out lengths[i]))
            {
                Console.WriteLine("Could not parse length!");
            }
        }

        float angle1 = MathF.Acos( (float)((Math.Pow(lengths[0], 2) + Math.Pow(lengths[2], 2) - Math.Pow(lengths[1], 2)) / (2*lengths[0]*lengths[2]))) * 180 / MathF.PI;
        float angle2 = MathF.Acos( (float)((Math.Pow(lengths[1], 2) + Math.Pow(lengths[2], 2) - Math.Pow(lengths[0], 2)) / (2*lengths[1]*lengths[2]))) * 180 / MathF.PI;
        float angle3 = 180 - angle2 - angle1;
        angle1 = (float)Math.Round(angle1, 2);
        angle2 = (float)Math.Round(angle2, 2);
        angle3 = (float)Math.Round(angle3, 2);

        float[] angles = new[]{angle1, angle2, angle3};
        Console.WriteLine($"{angle1} {angle2} {angle3}");
        if (angles.Contains(Single.NaN))
        {
            Console.WriteLine("Could not solve triangle!");
        }
        else if (angle1 == angle2 && angle2 == angle3)
        {
            Console.WriteLine("Triangle is equilateral");
        } 
        else if ((angle1 == angle2) || (angle1 == angle3) || (angle2 == angle3))
        {
            Console.WriteLine("Triangle is isosceles");
        }
        else
        {
            Console.WriteLine("Triangle is scalene");
        }
    }

    private static void CampEligibility()
    {
        Console.WriteLine("enter your date of birth[dd/mm/yy]: ");
        DateTime dob;
        while (!DateTime.TryParse(Console.ReadLine(), out dob))
        {
            Console.WriteLine("Could not parse date!");
        }

        DateTime localTime = DateTime.Today;
        int age = localTime.Year - dob.Year;
        if (localTime.Month > dob.Month || (localTime.Month == dob.Month && localTime.Day > dob.Day))
        {
            age--;
        }

        if (13 <= age && age < 16)
        {
            Console.WriteLine("eligible for 13-16 summer camp!");
        } else if (16 <= age && age < 18)
        {
            Console.WriteLine("eligible to volunteer!");
        } else if (age >= 18)
        {
            Console.WriteLine("eligible to get paid!");
        }
    }
}
// Division 
Console.WriteLine(7 / 2); 
Console.WriteLine(7.0 / 2);    

// strongly typed
//int x = 5; 
string y = "hello";

// range 
int big = 2147483647; 
big++;

// float precision
Console.WriteLine(Math.Abs(0.1 + 0.2 - 0.3) < double.Epsilon);
Console.WriteLine(0.1m + 0.2m == 0.3m);
 

// operator overloading
Console.WriteLine('A' + 'B'); 
Console.WriteLine((char)('C' + 1)); 
Console.WriteLine("A" + "B");

// inference 
// int n = 5;
// n = (int)5.5;


// rounding
double x = Math.Round(2.5);

Console.WriteLine((int)x);                 // cast
Console.WriteLine(Math.Round(x));          // Math class
Console.WriteLine(Convert.ToInt32(x));     // Convert class
Console.WriteLine(Math.Round(x, MidpointRounding.AwayFromZero));

// Collatz: halve it if it's even, else triple it and add one.
// Every starting number reaches 1... probably. Nobody has proved it.

int n = 27;              // also try 6, 7, and 97
int steps = 0;

while (n != 1)           // keep going until n reaches 1
{
    if (n % 2 == 0)      // is n even?
    {
        n = n / 2;      // which kind of division do you want here?
    }
    else
    {
        n = 3 * n + 1;
    }

    steps++;             // add one to steps, the C# way
    Console.WriteLine($"{n,6}");
}

Console.WriteLine($"Reached 1 in {steps} steps.");
Console.WriteLine("Hello World");

Console.WriteLine("Integer?");
string input = Console.ReadLine();

double d = 3.1459f;

int value = 0;

++value;

value = value + 10;
value += 25;

Console.WriteLine($"The value: {value}.");

// method one - use the system.convert method and catch if it fails 
try {
  int number = Convert.ToInt32(input);
} catch(Exception ex) {
  Console.WriteLine("That was not a number.");
}

// method 2 - the safer way 
long number2;
if(Int64.TryParse(input, out number2)) {
  Console.WriteLine($"That was a number {number2}");
} else {
  Console.WriteLine("That was not a number.");
}

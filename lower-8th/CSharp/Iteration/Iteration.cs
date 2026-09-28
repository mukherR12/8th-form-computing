using System.Xml.Serialization;

static void Countdown()
{
    Console.WriteLine("enter countdown time: ");
    if (Int32.TryParse(Console.ReadLine(), out int countdown))
    {
        for (int i = countdown; i >= 0; i--)
        {
            Console.WriteLine(i);
        }
    }
}

static void StarTriangle()
{
    int.TryParse(Console.ReadLine(), out int count);
    for(int i=1;i<=count;i++) {Console.WriteLine(new string('*', i));}
}

static void DrawGrid()
{
    int[] gl = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
    for (int i=0;i<=gl[0]*3;i++){Console.WriteLine(string.Concat(Enumerable.Repeat(i%3==0?"+--":"|  ",gl[1]))+(i%3==0?"+":"|")); }
}
static void DrawGrid2()
{
    int[] gl = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
    for(int i=0;i<=gl[0]*3;i++){
        Console.WriteLine((i==0)?$"┌--{string.Concat(Enumerable.Repeat("T--",gl[1]-1))}┌":""+(i%3==0 && i!=gl[0]*3?$"├--{string.Concat(Enumerable.Repeat("+--",gl[1]-1))}+":"")+(i%3!=0?$"|  {string.Concat(Enumerable.Repeat("|  ",gl[1]))}":"")+(i==gl[0]*3?$"L--{string.Concat(Enumerable.Repeat("T--",gl[1]-1))}L":"")) ;
        }
}

static void MeanMedianMode()
{
    Console.WriteLine("enter the numbers separated by commas [n1,n2,n3,etc]: ");
    var nums = Console.ReadLine().Split(",").Select(int.Parse).ToList();
    Console.WriteLine(nums.Sum());
    Console.WriteLine(nums.Average());
    nums.Sort();
    Console.WriteLine(nums[nums.Count()/2]);
    Console.WriteLine();
    int maxnum;
    int maxcount=0;
    int count=0;
    for(int i=0; i<nums.Count();i++) {
        if(nums[i] == nums[i-1]) {
            count++;
            if (count>=maxcount)
            {
                maxcount = count;
                maxnum=nums[i];
            }
        } else
        {
            count=0;
        }
    }
}

static void ISBN()
{
    string input = Console.ReadLine();
    int num;
    int total = 0;
    int multiplier=0;
    for(int i=input.Count();i>0;i--)
    {
        if (int.TryParse(input[i-1].ToString(), out num))
        {
            total += num*i;
        } else if (input[i-1] == '?'){
            multiplier = i;
        } else if (input[i-1] == 'X')
        {
            total += 10*i;
        }
    }
    for(int j=1;j<=10;j++)
    {
        // Console.WriteLine(total+ j*multiplier);
        // Console.WriteLine((total+ j*multiplier) %11);

        if ((total+ j*multiplier) % 11 == 0)
        {
            if (j!=10)
            {
                Console.WriteLine($"Missing Digit: {j}");
            } else
            {
                Console.WriteLine($"Missing Digit: X");
            }
        }
    }
}

static void BinarySearch()
{
    int lowerguess = 0;
    int higherguess = 0;
    int guess = 500;
    bool higherFound = false;
    bool correct = false;

    while (!correct)
    {
        Console.WriteLine("higher or lower than " + guess + " or correct? [h/l/c]:");
        string choice = Console.ReadLine();

        if (choice == "h")
        {
            lowerguess = guess;

            if (!higherFound)
            {
                guess *= 2;
            }
            else
            {
                guess = lowerguess + (higherguess - lowerguess) / 2;
            }
        }
        else if (choice == "l")
        {
            higherguess = guess;
            higherFound = true;

            guess = lowerguess + (higherguess - lowerguess) / 2;
        }
        else if (choice == "c")
        {
            Console.WriteLine("Your number was " + guess);
            correct = true;
        }
    }
}

static void ReverseOrder()
{
    string input = Console.ReadLine();
    List<char> reversed = new List<char> {};
    for(int i=input.Count()-1; i>=0;i--)
    {
        reversed.Add(input[i]);
    }
    string output = string.Join("", reversed);
    Console.WriteLine(output);
}
ReverseOrder();
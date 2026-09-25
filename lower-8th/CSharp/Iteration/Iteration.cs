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
    for (int i=0;i<=gl[0]*3;i++){Console.WriteLine(String.Concat(Enumerable.Repeat(i%3==0?"+--":"|  ",gl[1]))+(i%3==0?"+":"|")); }
}
static void DrawGrid2()
{
    int[] gl = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
    for (int i=0;i<=gl[0]*3;i++){Console.WriteLine((i==0)?"┌":"" + (i%3==0 && i!=gl[0]?"├":"|")) ;}
}

DrawGrid2();
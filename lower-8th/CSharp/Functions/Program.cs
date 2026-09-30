
int SumOfDigits(int startnum)
{
    int sum = 0;
    for (int i = 0; i < startnum.ToString().Length; i++)
    {
        sum += startnum.ToString()[0];
    }

    return sum;
}

int NumSpaces(string startstring)
{
    int spaces = startstring.Count(c => c == ' ' );
    return spaces;
}

void Swap(ref int a, ref int b)
{
    int a1 = a;
    a = b;
    b = a1;
}

string Translate(int input, int nbase)
{
    string baserep = Convert.ToString(input, nbase);
    return baserep;
}

(int, int) DivMod(int a, int b, bool isPython)
{
    if (!isPython || a/b > 0)
    {
        return (a / b, a % b);
    }
    return (a / b - 1, (a % b)/-1);
}

bool TryParseTime(string time, out int h, out int m, out bool am)
{
    am = true;
    m = 0;
    if (!int.TryParse(time.Split(':')[0], out h) || !int.TryParse(time.Split(':')[1], out m))
    {
        return false;
    }
    if (h > 12)
    {
        h -= 12;
        am = false;
    }
    m = int.Parse((time.Split(":")[1]));
    return true;
}

bool IsPrime(int n)
{
    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0)
        {
            return false;
        }
    }
    return true;
}

bool IsPerfect(int n)
{
    int divisorSum = 0;
    for (int i = 1; i < n; i++)
    {
        if (n % i == 0)
        {
            divisorSum++;
        }
    }
    if (divisorSum == n) return true;
    return false;
}

bool IsAbundant(int n)
{
    int divisorSum = 0;
    for (int i = 1; i < n; i++)
    {
        if (n % i == 0)
        {
            divisorSum++;
        }
    }
    if (divisorSum > n) return true;
    return false;
}

bool IsFriendly(int n1, int n2)
{
    int n1divisorSum = 0;
    int n2divisorSum = 0;
    for (int i = 1; i < Math.Max(n1,n2); i++)
    {
        if (i<n1 && i%n1==0)
        {
            n1divisorSum++;
        }
        if (i<n2 && i%n2==0)
        {
            n2divisorSum++;
        }
    }
    if (n1divisorSum/n1 == n2divisorSum/n2) return true;
    return false;
}
int h;
int m;
bool am;
Console.WriteLine(TryParseTime("12:35", out h, out m, out am));
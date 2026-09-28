
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
    if (!int.TryParse(time.Split(':')[0], out h))
    {
        return false;
    }
    am = true;
    if (h > 12)
    {
        h -= 12;
        am = false;
    }
    int.TryParse(time.Split(':')[1], out m);
    
}

Console.WriteLine(DivMod(-7,2,true));
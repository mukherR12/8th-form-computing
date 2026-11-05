using System.Numerics;

void PrintStringCollectionReverseOrder(List<string> strings)
{
    List<string> pstack = strings;
    int index = pstack.Count - 1;

    while (index >= 0)
    {
        Console.WriteLine(pstack[index]);
        pstack.RemoveAt(index);
        index--;
    }
}

void PrintBinaryRepresentationOfPositiveInteger(string intstring)
{
    BigInteger integer = BigInteger.Parse(intstring);
    List<BigInteger> pstack = new List<BigInteger>();

    while (integer != 0)
    {
        pstack.Add(BigInteger.Remainder(integer, 2));
        integer /= 2;
    }
    
    int index = pstack.Count - 1;

    while (index >= 0)
    {
        Console.Write(pstack[index]);
        pstack.RemoveAt(index);
        index--;
    }
    Console.WriteLine();
}

void PerformRequestedOperationStringOnStack(string operations)
{
    List<string> pStack = new List<string>();
    List<string> popped = new List<string>();
    foreach (char operation in operations)
    {
        if (operation.ToString() == "*")
        {
            try
            {
                popped.Add(pStack[^1]);
            }
            catch {
                Console.WriteLine("Cannot pop an empty stack!");
                continue;
            }
            pStack.RemoveAt(pStack.Count - 1);
        }
        else
        {
            pStack.Add(operation.ToString());
        }
    }

    foreach (string pop in popped)
    {
        Console.Write(pop + " ");
    }
}

void PerformRequestedOperationStringOnQueue(string operations)
{
    List<string> pQueue = new List<string>();
    List<string> popped = new List<string>();
    foreach (char operation in operations)
    {
        if (operation.ToString() == "*")
        {
            try
            {
                popped.Add(pQueue[0]);
            }
            catch {
                Console.WriteLine("Cannot pop an empty stack!");
                continue;
            }
            pQueue.RemoveAt(0);
        }
        else
        {
            pQueue.Add(operation.ToString());
        }
    }

    foreach (string pop in popped)
    {
        Console.Write(pop + " ");
    }
}

List<string> strings = new List<string>()
{
    "hello",
    "world",
    "test",
    "test2",
};

void bfs(List<List<int>> grid, int[] sourceXY, int[] targetXY)
{
    List<int[]> visitedAndCost = new List<int[]> {};

    List<int[]> pqeue = new List<int[]>(){ sourceXY };
}

PrintBinaryRepresentationOfPositiveInteger("329397488293749643982764732848729368273963871921376896374223848746987247892364892647238164918382738462896321864872148712648791284127648279648213794683242379146213468921468721463782146382174677893264723891127896423178098019324774138092130894741703892318907637429180483921073279810478329103784921043289147328190738294372819382910783249174832913789210738291032789104783921032710937824910372891043981077398210734821908321749082473190742831904372819047328910347289173482910743289107483291073829103247810437892104327891437829147382910738429107328197328917843291078391027314982074318092741398027139480234798120473928017431298017439028743982103712498037419023471982043721908431879203071829731023784921074382910734892101372480943789012437892103471980243780921473108943710894371029843719028437910809784327489302190873214738921004983271473218900493812747893214379801248930127438901247832901374891047389210437892104103924784738910292308474783921009328748634912065348720108237464653928287364986374921023468777298312942617893467891247683129243761894673189223168794863782192000");

PerformRequestedOperationStringOnQueue("EAS*Y*QUE***ST***IO*N***");


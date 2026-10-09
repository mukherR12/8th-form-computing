List<int> numbers = new List<int>() {-10, 1,2,3,4,5,6,7,8,9};

int thesum(List<int> nums)
{
    int sum = 0;
    for (int i = 0; i < nums.Count; i++)
    {
        sum += nums[i];
    }

    return sum;
}

int themax(List<int> nums)
{
    int max = 0;
    for (int i = 0; i < nums.Count; i++)
    {
        if (nums[i] > max) max = nums[i];
    }

    return max;
}

int themin(List<int> nums)
{
    int min = int.MaxValue;
    for (int i = 0; i < nums.Count; i++)
    {
        if (nums[i] < min) min = nums[i];
    }

    return min;
}

List<int> negatives(List<int> nums)
{
    List<int> negs = new List<int>() { };
    for (int i = 0; i < nums.Count; i++)
    {
        if (nums[i] < 0) negs.Add(nums[i]);
    }

    return negs;
}

void printList<T>(List<T> nums)
{
    string str = "";
    for (int i = 0; i < nums.Count; i++)
    {
        str += nums[i].ToString() + ",";
    }
    Console.WriteLine($"[{str.Substring(0, str.Length - 1)}]");
}

bool areListsEqual<T>(List<T> nums1, List<T> nums2)
{
    if (nums1.Count != nums2.Count) return false;
    for (int i = 0; i < nums1.Count; i++)
    {
        if (nums1[i].Equals(nums2[i])) return false;
    }

    return true;
}

bool isListSameItems<T>(List<T> nums1, List<T> nums2)
{
    HashSet<T> num1set = new HashSet<T>(nums1);
    HashSet<T> num2set = new HashSet<T>(nums2);
    if (num1set.SetEquals(num2set))
    {
        return true;
    }

    return false;
}

List<int> removeNegatives(List<int> nums)
{
    for (int i = 0; i < nums.Count; i++)
    {
        if (nums[i] < 0)
        {
            nums.RemoveAt(i);
            i -= 1;
        }
    }

    return nums;
}
List<int> erastosthenes(int maxnum)
{
    List<bool> isprime = Enumerable.Repeat(true, maxnum + 1).ToList();

    isprime[0] = false;
    isprime[1] = false;

    int lowestCurrentPrime = 2;

    while (lowestCurrentPrime <= maxnum)
    {
        for (int i = lowestCurrentPrime * 2; i <= maxnum; i += lowestCurrentPrime)
        {
            isprime[i] = false;
        }

        lowestCurrentPrime = isprime.FindIndex(lowestCurrentPrime + 1, x => x);

        if (lowestCurrentPrime == -1) break;
    }

    List<int> primes = new List<int>() { };
    for (int i = 0; i < isprime.Count; i++)
    {
        if (isprime[i]) primes.Add(i);
    }
    return primes;
}

// bool searchSortedListNaive<T>(List<T> sorted)
// {
//     
// }

// printIntList(removeNegatives(numbers));

printList(erastosthenes(100));
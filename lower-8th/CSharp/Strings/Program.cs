using System.Text;

void printList<T>(List<T> list)
{
    foreach (var c in list)
    {
        Console.Write(c + " ");
    }
    Console.WriteLine();
}

List<byte> wordToCharCodes(string word)
{
    byte[] output = Encoding.UTF8.GetBytes(word);
    
    return output.ToList();
}

string charCodesToWord(List<byte> charCodes)
{
    return Encoding.UTF8.GetString(charCodes.ToArray());
}

List<string> mexicanWave(string word)
{
    List<string> wave = new List<string>();

    for (int i = 0; i < word.Length; i++)
    {
        if (!word[i].ToString().IsWhiteSpace())
        {
            StringBuilder waveBuilder = new StringBuilder();
            for (int j = 0; j < word.Length; j++)
            {
                if (i != j)
                {
                    waveBuilder.Append(word[j]);
                }
                else
                {
                    waveBuilder.Append(word[j].ToString().ToUpper());
                }
            }
            wave.Add(waveBuilder.ToString());
        }
    }

    return wave;
}

int Anagram(string word, List<string> words)
{
    string sortedWord = new string(word.ToLower().OrderBy(c => c).ToArray());

    int count = 0;

    foreach (string currentWord in words)
    {
        string sortedCurrentWord = new string(currentWord.ToLower().OrderBy(c => c).ToArray());

        if (sortedWord == sortedCurrentWord)
        {
            count++;
        }
    }

    return count;
}

string VarNameHelper(string input, int option)
{
    string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    if (option == 0)
    {
        StringBuilder output = new StringBuilder();

        for (int i = 0; i < words.Length; i++)
        {
            if (i == 0)
            {
                output.Append(words[i].ToLower());
            }
            else
            {
                output.Append(char.ToUpper(words[i][0]));
                output.Append(words[i].Substring(1).ToLower());
            }
        }

        return output.ToString();
    }
    else if (option == 1)
    {
        StringBuilder output = new StringBuilder();

        foreach (string word in words)
        {
            output.Append(char.ToUpper(word[0]));
            output.Append(word.Substring(1).ToLower());
        }

        return output.ToString();
    }
    else if (option == 2)
    {
        return string.Join("_", words.Select(w => w.ToLower()));
    }

    throw new ArgumentException("Invalid option");
}

string pigLatin(string sentence)
{
    string[] words = sentence.Split(' ');
    List<string> output = new List<string>();

    foreach (string word in words)
    {
        if (word.Length == 0)
        {
            output.Add(word);
            continue;
        }

        int punctuationLength = 0;

        while (punctuationLength < word.Length &&
               char.IsPunctuation(word[punctuationLength]))
        {
            punctuationLength++;
        }

        int end = word.Length;

        while (end > punctuationLength &&
               char.IsPunctuation(word[end - 1]))
        {
            end--;
        }

        if (punctuationLength == end)
        {
            output.Add(word);
            continue;
        }

        string punctuationStart = word.Substring(0, punctuationLength);
        string mainWord = word.Substring(punctuationLength, end - punctuationLength);
        string punctuationEnd = word.Substring(end);

        string pigWord = mainWord.Substring(1) + mainWord[0] + "ay";

        output.Add(punctuationStart + pigWord + punctuationEnd);
    }

    return string.Join(" ", output);
}

(int, int) getKeyCoordinates(char key)
{
    string[] keyboard = {
        "abcde",
        "fghij",
        "klmno",
        "pqrst",
        "uvwxy",
        "z_"
    };

    for (int i = 0; i < keyboard.Length; i++)
    {
        for (int j = 0; j < keyboard[i].Length; j++)
        {
            if (keyboard[i][j] == key)
            {
                return (i, j);
            }
        }
    }

    if (key == '<') { return (5, 2); }
    throw new ArgumentException("Invalid key");
}

int keyMovement(char start, char end)
{
    (int startRow, int startCol) = getKeyCoordinates(start);
    (int endRow, int endCol) = getKeyCoordinates(end);

    return Math.Abs(startRow - endRow) + Math.Abs(startCol - endCol);
}

int TVRemote(List<string> words)
{
    int presses = 0;
    char currentKey = 'a';

    foreach (string word in words)
    {
        string currentWord = word.ToLower() + "_";

        foreach (char key in currentWord)
        {
            presses += keyMovement(currentKey, key);
            presses++;

            currentKey = key;
        }

        presses += keyMovement(currentKey, '<');
        presses++;

        currentKey = '<';
    }

    return presses;
}

Console.WriteLine(charCodesToWord(wordToCharCodes("κώδικας")));

printList(mexicanWave("hello world"));

Console.WriteLine(Anagram("star", new List<string> { "rats", "arts", "arc" }));

Console.WriteLine(VarNameHelper("Cost of cakes", 0));

Console.WriteLine(pigLatin("The cat sat on the mat."));

Console.WriteLine(TVRemote(new List<string> { "war", "and", "peace" }));

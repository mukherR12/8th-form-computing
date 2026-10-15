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
Console.WriteLine(charCodesToWord(wordToCharCodes("κώδικας")));

printList(mexicanWave("hello world"));
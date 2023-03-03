using System;

namespace ConsoleNet7.Exercise2;

public static class StringOps
{
    public static void ExecuteSample()
    {
        string str = "Los pollitos dicen pio pio";
        CountSameCharacters(str);

        var input = Console.ReadLine();
        Console.WriteLine("Total amount of vocals: {0}", CountVocals(input));

    }

    private static void CountSameCharacters(string str)
    {
        Dictionary<char, int> charnum = new();
        foreach (var c in str)
        {
            if (charnum.ContainsKey(c))
            {
                charnum[c] = charnum[c] + 1;
            }
            else
            {
                charnum[c] = 1;
            }
        }
        foreach (var cn in charnum)
        {
            Console.WriteLine("{0} => {1}", cn.Key, cn.Value);
        }
    }

    private static int CountVocals(string str)
    {
        int count = 0;
        foreach (var i in str)
        {
            if (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u' || i == 'A' || i == 'E' || i == 'I' || i == 'O' || i == 'U')
            {
                count++;
            }
        }
        return count;
    }
}

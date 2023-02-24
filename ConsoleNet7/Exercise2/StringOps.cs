using System;

namespace ConsoleNet7.Exercise2;

public static class StringOps
{
    public static void ExecuteSample()
    {
        string str = "Los pollitos dicen pio pio";
        CountCharacters(str);
    }

    private static void CountCharacters(string str)
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
}

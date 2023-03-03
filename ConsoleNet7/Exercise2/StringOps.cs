using System;
using System.Text;

namespace ConsoleNet7.Exercise2;

public static class StringOps
{
    public static void ExecuteSample()
    {
        string str = "Los pollitos dicen pio pio";
        CountSameCharacters(str);

        var input = Console.ReadLine();
        Console.WriteLine("Only vocals: {0}", FilterVocals(input, 5));

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

    private static string FilterVocals(string str, int num)
    {
        int count = 0;
        StringBuilder sb = new("");
        foreach (var i in str)
        {
            if (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u' || i == 'A' || i == 'E' || i == 'I' || i == 'O' || i == 'U')
            {
                sb.Append(i);
                count++;
                if (count == num) break;
            }
        }
        return sb.ToString();
    }
}

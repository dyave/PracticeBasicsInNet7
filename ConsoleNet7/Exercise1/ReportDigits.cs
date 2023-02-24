using System;

namespace ConsoleNet7.Exercise1;

public static class ReportDigits
{
    public static void ExecuteSample()
    {
        Random rnd = new();
        int num = rnd.Next(0, 12345678);
        Console.WriteLine(num);

        List<int> digits = new();

        int cociente = num;
        do
        {
            int res = cociente % 10;
            digits.Add(res);
            cociente = cociente / 10;
        }
        while (cociente != 0);

        List<int> counts = new() { 0,0,0,0,0,0,0,0,0,0};

        foreach (var d in digits)
        {
            counts[d] = counts[d] + 1;
        }

        for (int i = 0; i < counts.Count; i++)
        {
            Console.WriteLine("{0} has {1} digits", i, counts[i]);
        }
    }
}




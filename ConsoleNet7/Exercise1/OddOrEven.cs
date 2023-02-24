using System;
namespace ConsoleNet7.Exercise1;

public static class OddOrEven
{
	public static void ExecuteSample()
	{
        Random rnd = new();
		for (int i = 0; i < 10; i++)
		{
            int num = rnd.Next(0, 12345678);
            Console.Write("{0} is {1}", num, IsEven(num) ? "even" : "odd");
            Console.Write(" from which the digits ");
            ShowDigitsSeparately(num);
        }

    }

	public static void ShowDigitsSeparately(int num)
	{
		int cociente = num;
		int res = 0;

		List<int> odds = new();
		List<int> evens = new();
		
		do
		{
			res = cociente % 10;

			if (IsEven(res))
			{
				evens.Add(res);
			}
			else
			{
				odds.Add(res);
			}
			cociente = cociente / 10;
		}
		while (cociente != 0);

		evens.Reverse();
		odds.Reverse();
        evens.ForEach(e => Console.Write(e));
        Console.Write(" are even and ");
		odds.ForEach(o => Console.Write(o));
		Console.WriteLine(" are odd.");
	}

	public static bool IsEven(int num)
	{
		return num % 2 == 0;
	}
}

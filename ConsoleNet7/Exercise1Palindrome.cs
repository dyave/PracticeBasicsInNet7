using System;

namespace ConsoleNet7;

public static class Exercise1
{
	public static void Palindrome()
	{
        Random rnd = new();
        bool isPal = false;

        while (!isPal)
        {
            int num = rnd.Next(0, 9999);
            Console.WriteLine(num);
            isPal = CheckPalindrome(num);
        }

        Console.WriteLine("{0} Palindrome", isPal ? "Is" : "Isn't");
    }


    static bool CheckPalindrome(int num)
    {
        //int[] digits = new int[];
        List<int> digits = new();

        int cociente = num;
        do
        {
            int res = cociente % 10;
            digits.Add(res);
            //Console.WriteLine(res);
            cociente = cociente / 10;
        }
        while (cociente != 0);


        digits.Count();
        int firstDigit = digits.ElementAt(0);
        int size = digits.Count();


        for (int i = 0; i < size - 1; i++)
        {
            if (digits.ElementAt(i) != digits.ElementAt(size - 1 - i))
            {
                return false;
            }
        }

        return true;
    }
}




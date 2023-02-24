using System;
namespace ConsoleNet7.Exercise2;

public static class ListOps
{
    public static void ExecuteSample()
    {
        List<int> alist = new() { 7, 3, 4, 9 };
        List<int> blist = new() { 2, 5, 7, 1 };
        List<int> clist = new();

        clist = OrderAndMerge(alist, blist);
        clist.ForEach(x => Console.Write("{0} ", x));
    }

    private static List<int> OrderAndMerge(List<int> alist, List<int> blist)
    {
        List<int> list1 = alist;
        List<int> list2 = blist;
        List<int> list3 = new();

        while (list1.Count > 0 || list2.Count > 0)
        {

            if (list1.Count > 0 && list2.Count > 0)
            {
                int min1 = list1.Min();
                int min2 = list2.Min();
                if (min1 == min2)
                {
                    list3.AddRange(new int[] { min1, min2 });
                    list1.Remove(min1);
                    list2.Remove(min2);
                }
                else if (min1 < min2)
                {
                    list3.Add(min1);
                    list1.Remove(min1);
                }
                else
                {
                    list3.Add(min2);
                    list2.Remove(min2);
                }
            }
            else
            {
                if (list1.Count > 0)
                {
                    int tmin = list1.Min();
                    list3.Add(tmin);
                    list1.Remove(tmin);
                } else
                {
                    int tmin = list2.Min();
                    list3.Add(tmin);
                    list2.Remove(tmin);
                }
            }
        }
        return list3;
    }
}

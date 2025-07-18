using System.Collections.Generic;
namespace Exercise13;


internal class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();
        for (int i = 1; i <= 10; i++)
        {
            list.Add(i);
        }
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }

        Console.WriteLine();

        for (int i = list.Count - 1; i > 0; i--)
        {
            if (list[i] % 2 == 0)
            {
                list.RemoveAt(i);
            }
        }
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }

        Console.WriteLine();

        List<int> list2 = new List<int>();
        for (int i = 1; i <= 5; i++)
        {
            list2.Add(i);
        }

        for (int i = 0; i < list2.Count; i++)
        {
            if (list2[i] > 0 || list2[i] < 4)
            {
                list2.RemoveAt(i);
            }
        }
        for (int i = 0; i < list2.Count; i++)
        {
            Console.WriteLine(list2[i]);
        }
    }
}
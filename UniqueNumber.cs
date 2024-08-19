using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] num = { 4, 1, 2, 2, 1 };

        int result = Unique(num);

        Console.WriteLine("Unique number is " + result);

        Console.ReadLine();
    }

    static int Unique(int[] num)
    {
        var hm = new Dictionary<int, int>();

        for (int i = 0; i < num.Length; i++)
        {
            if (hm.ContainsKey(num[i]))
            {
                hm[num[i]]++;
            }
            else
            {
                hm[num[i]] = 1;
            }
        }

        for (int i = 0; i < num.Length; i++)
        {
            if (hm[num[i]] == 1)
            {
                return num[i];
            }
        }

        return 0; // return a default value if no unique number is found
    }
}

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] num = { 1, -1, 0 };
        int k = 0;

        int result = SubarraySum(num, k);

        Console.WriteLine("The number of subarrays whose sum equals " + k + " is: " + result);

        Console.ReadLine();
    }

    static int SubarraySum(int[] num, int k)
    {
        int sum = 0;
        int count = 0;
        var hm = new Dictionary<int, int>();

        for (int i = 0; i < num.Length; i++)
        {
            sum += num[i];

            if (sum == k)
            {
                count++;
            }

            if (hm.ContainsKey(sum - k))
            {
                count += hm[sum - k];
            }

            if (hm.ContainsKey(sum))
            {
                hm[sum] = hm[sum] + 1;
            }
            else
            {
                hm[sum] = 1;
            }
        }

        return count;
    }
}

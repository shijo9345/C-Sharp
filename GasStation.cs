using System;

public class Solution
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        int total_left = 0;
        for (int i = 0; i < gas.Length; i++)
        {
            total_left += gas[i] - cost[i];
        }

        if (total_left<0)
        {
            return -1;
        }

        int currentGas = 0;
        int startIndex = 0;

        for (int i = 0; i < gas.Length; i++)
        {
            currentGas += gas[i] - cost[i];
            if (currentGas < 0)
            {
                currentGas = 0;
                startIndex = i + 1;
            }
        }

        return startIndex;
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter number of gas stations:");
        int n = int.Parse(Console.ReadLine());

        int[] gas = new int[n];
        int[] cost = new int[n];

        Console.WriteLine("Enter gas amounts at each station:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Gas at station {i}: ");
            gas[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the cost to travel to the next station:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Cost from station {i} to {((i + 1) % n)}: ");
            cost[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nGas array: [" + string.Join(", ", gas) + "]");
        Console.WriteLine("Cost array: [" + string.Join(", ", cost) + "]");

        Solution solution = new Solution();
        int result = solution.CanCompleteCircuit(gas, cost);
        Console.WriteLine("\nStarting gas station index: " + result);
        Console.ReadLine();
    }
}
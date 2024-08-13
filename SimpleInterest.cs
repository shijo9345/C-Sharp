using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p, r, t, si;
            Console.Write("Enter the principal amount :");
            p =int.Parse (Console.ReadLine());
            Console.Write("Enter the rate :");
            r = int.Parse(Console.ReadLine());
            Console.Write("Enter the time  :");
            t = int.Parse(Console.ReadLine());
            si = (p * r * t) / 100;
            Console.Write($"Enter the time: {si}");
        }
    }
}

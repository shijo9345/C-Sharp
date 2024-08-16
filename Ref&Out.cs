using System;

class Program
{
    static void Main()
    {
        int number = 5;
        Console.WriteLine("Before: " + number);

        // Passing the variable using ref
        Increment(ref number);

        Console.WriteLine("After: " + number);
        Console.ReadLine();
    }

    static void Increment(ref int x)
    {
        x++; // Modifies the original variable
    }
}



///////////////
 
using System;

class Program
{
    static void Main()
    {
        int result;

        // Passing the variable using out
        Initialize(out result);

        Console.WriteLine("Result: " + result);
    }

    static void Initialize(out int x)
    {
        x = 42; // Must assign a value before returning
    }
}

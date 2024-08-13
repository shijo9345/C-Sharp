using System;
using System.Reflection;

class Person
{
    public string Name;
    public int Age;
    public static int Count;


    // Default Constructor
    public Person()
    {
        Name = "Unknown";
        Age = 0;
    }

    // Parameterized Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Copied Constructor
    public Person(Person other)
    {
        Name = other.Name;
        Age = other.Age;
    }

    // Static Constructor
    static Person()
    {
        Count = 0; // Initialize static field
        Console.WriteLine("Static constructor called.");
    }
    public static void Increment()
    {
        Count++;
    }

}

class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person();
        Console.WriteLine($"Person1 - Name: {person1.Name}, Age: {person1.Age}");

        Person person2 = new Person("Alice", 30); 
        Console.WriteLine($"Person2 - Name: {person2.Name}, Age: {person2.Age}");

        Person copied = new Person(person2);
        Console.WriteLine($"Copied - Name: {copied.Name}, Age: {copied.Age}");

        Console.WriteLine($"Initial Count: {Person.Count}");
        Person.Increment();
        Console.WriteLine($"Count after increment: {Person.Count}");
        Console.WriteLine($"Count after increment: {Person.Count}");



        Console.ReadLine(); 
    }
}

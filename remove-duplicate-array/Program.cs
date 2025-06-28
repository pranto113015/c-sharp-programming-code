using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter integers separated by spaces:");
        string input = Console.ReadLine();
        int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

        int[] uniqueNumbers = numbers.Distinct().ToArray();

        Console.WriteLine("Array after removing duplicates:");
        Console.WriteLine(string.Join(" ", uniqueNumbers));
    }
}


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the numbers with spaces :");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');
        int[] numbers = Array.ConvertAll(parts, int.Parse);

        Array.Reverse(numbers);

        Console.WriteLine("Reversed array:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}

using System;
using System.Linq;

class Program
{
static void Main()
{
Console.WriteLine("Enter a number with spaces:");
string input = Console.ReadLine();
int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

int max = numbers.Max();
int min = numbers.Min();

Console.WriteLine($"Maximum number: {max}");
Console.WriteLine($"Minimum number: {min}");
}
}
using System;

namespace letter_grade_calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter student's score (0-100): ");
            int score = Convert.ToInt32(Console.ReadLine());

            if (score >= 90 && score <= 100)
                Console.WriteLine("Grade: A");
            else if (score >= 80)
                Console.WriteLine("Grade: B");
            else if (score >= 70)
                Console.WriteLine("Grade: C");
            else if (score >= 60)
                Console.WriteLine("Grade: D");
            else
                Console.WriteLine("Grade: F");
        }
    }
}
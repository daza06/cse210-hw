using System;
using System.Globalization;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;
        List<int> numbers = new List<int>();

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        double avg = (double)sum / numbers.Count;
        avg = Math.Round(avg, 2);
        Console.WriteLine($"The average is: {avg}");

        int largest = numbers.Max();
        Console.WriteLine($"The largest number is: {largest}");

    }

}
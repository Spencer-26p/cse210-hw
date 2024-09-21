using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int response = -100;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (response != 0)
        {
            Console.Write("Enter number: ");
            string responseString = Console.ReadLine();
            response = int.Parse(responseString);
            if(response != 0)
            {
            numbers.Add(response);
            }
        }
        float sum = 0;
        float average = 0;
        int large = 0;
        int small = 10000;
        numbers.Sort();
        foreach (int number in numbers)
        {
            if (number > 0 && number < small)
            {
                small = number;
            }
            sum =+ number;
        }
        average = sum / numbers.Count;
        large = numbers[numbers.Count - 1];
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest is: {large}");
        Console.WriteLine($"The smallest positive number: {small}");
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine($"{number}");
        }
    }
}
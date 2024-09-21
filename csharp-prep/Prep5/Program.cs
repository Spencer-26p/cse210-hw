using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        double square = SquareNumber(number);
        DisplayResult(name,square);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string numberString = Console.ReadLine();
        int number = int.Parse(numberString);
        return number;
    }

    static double SquareNumber(int number)
    {
        double square = Math.Pow(number,2);
        return square;
    }

    static void DisplayResult(string name, double square)
    {
        Console.WriteLine($"Hello {name}, the square of your number is {square}");
    }
}
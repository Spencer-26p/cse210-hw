using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        while (playAgain == "yes" || playAgain == "y")
        {
            int guessCount = 0;
            Random randomGenerator = new Random();
            int randomNum = randomGenerator.Next(1,100);
            int guess = -1000;
            while (guess != randomNum)
            {
                Console.WriteLine("What is your guess? ");
                string guessString = Console.ReadLine();
                guessCount +=1;
                guess = int.Parse(guessString);
                if (guess == randomNum)
                {
                    Console.WriteLine($"Congratulations! It took you {guessCount} tries! Would you like to try again? (yes or no)? ");
                    playAgain = Console.ReadLine();
                }
                else if (guess < randomNum)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > randomNum)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("I don't understand, try again.");
                    guessCount =-1;
                }
            }
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();
        Console.Clear();
        string userInput = null;
        Console.WriteLine("Hello, and welcome to the scripture memorizer");
        Console.WriteLine("How many different sets of scriptures do you want to memorize?");
        string scriptureNumberText = Console.ReadLine();
        int scriptureNumber = int.Parse(scriptureNumberText);
        for(int i = scriptureNumber; i > 0; i--)
        {
            Console.WriteLine("Give a reference, please (Format: 'Book Chapter:Verse', 'Book Chapter:BeginningVerse-EndingVerse' or 'Book Chapter:firstVerse,secondVerse");
            Reference reference = new Reference(Console.ReadLine());
            Console.WriteLine("Write the verse(s) in full below");
            Scripture scripture = new Scripture(Console.ReadLine(),reference.GetDisplayText());
            scriptures.Add(scripture);
            Console.WriteLine();
        }
        Random random = new Random();
        while (userInput != "quit" && scriptures.Count > 0)
        {
            userInput = null;
            int randomNum = random.Next(scriptures.Count);
            Scripture learningScripture = scriptures[randomNum];
            while (!learningScripture.CheckCompletelyHidden() && userInput != "next" && userInput != "quit")
            {
                Console.Clear();
                learningScripture.Display();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press enter to continue, or type 'quit' to quit. If you type 'next' it will go to the next scripture set.");
                userInput = Console.ReadLine();
                learningScripture.HideWords();
            }
            if (userInput != "quit" && userInput != "next")
            {
            Console.Clear();
            learningScripture.Display();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue, or type 'quit' to quit");
            userInput = Console.ReadLine();
            Console.Clear();
            }
            scriptures.Remove(scriptures[randomNum]);
        }
        return;
    }
}

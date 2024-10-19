using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "500";
        while (userInput != "5")
        {
            Console.Clear();
            if(userInput == "bad")
            {
                Console.WriteLine("Choose a valid option.");
            }
            Console.WriteLine("Menu:\n1. Start breathing activity\n2. Start reflecting activity\n3. Start listing activity\n4. Settings\n5. Quit\nSelect a choice from the menu: ");
            userInput = Console.ReadLine();
            switch(userInput)
            {
                case "1":
                    Console.Clear();
                    Breathing breathing = new Breathing();
                    breathing.StartingMessage();
                    breathing.Display();
                    break;
                case "2":
                    Console.Clear();
                    Reflection reflection = new Reflection();
                    reflection.StartingMessage();
                    reflection.Display();
                    break;
                case "3":
                    Console.Clear();
                    Listing listing = new Listing();
                    listing.StartingMessage();
                    listing.Display();
                    break;
                case "4":
                    string settings = "500";
                    Console.Clear();
                    Console.WriteLine("Settings Menu:\n1. Add Questions to listing activity\n2. Add questions to reflection activity.\n3. Add prompts to reflection activity.\n4. Quit");
                    settings = Console.ReadLine();
                    switch (settings)
                    {
                        case "1":
                            Listing listingAdd = new Listing();
                            listingAdd.AddQuestions();
                            break;
                        case "2":
                            Reflection question = new Reflection();
                            question.AddQuestion();
                            break;
                        case "3":
                            Reflection prompt = new Reflection();
                            prompt.AddPrompt();
                            break;
                        case "4":
                            break;
                    }
                    break;
                case "5":
                    Console.Clear();
                    break;
                default:
                    userInput = "bad";
                    break;
            }
        }
    }
}

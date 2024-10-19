using System.ComponentModel.DataAnnotations;

class Listing : Activity 
{
    private List<string> _prompts = new List<string>();
    private int _count;

    public Listing() : base("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you cna in a certain area.")
    {
        LoadPrompts();
    }
    public void LoadPrompts()
    {
        string[] fileLines = System.IO.File.ReadAllLines("listprompts.txt");
        foreach (string line in fileLines)
        {
            _prompts.Add(line);
        }
    }
    public string GetPrompt()
    {
        Random random = new Random();
        if (_prompts.Count == 0)
        {
            LoadPrompts();
        }
        int randomNum = random.Next(_prompts.Count);
        string returnQuestion = _prompts[randomNum];
        _prompts.Remove(_prompts[randomNum]);
        return returnQuestion;
    }
    public void Display()
    {
        Console.WriteLine("List as many responses as you cna to the following prompt:");
        Console.WriteLine($"-- -- {GetPrompt()} -- --\n");
        Console.Write("You may begin in: ");
        CountDown(5);
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(GetLength());
        Console.WriteLine();
        while ((start < end))
        {
            Console.ReadLine();
            _count +=1;
            start = DateTime.Now;
        }
        Console.WriteLine($"You listed {_count} things!");
        EndingMessage();
    }
    public void AddQuestions()
    {
        using (StreamWriter outputFile = new StreamWriter("listprompts.txt",true))
        {
            string userInput = "";
            while (userInput != "quit")
            {
                Console.WriteLine("Please write a new prompt for listing activity. Type 'quit' to end");
                userInput = Console.ReadLine();
                if (userInput != "quit")
                {
                    outputFile.WriteLine(userInput);
                }
            }
        }
    }
}
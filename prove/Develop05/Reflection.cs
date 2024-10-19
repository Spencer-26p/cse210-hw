class Reflection : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public Reflection() : base("Reflection","This activity will help you reflect on time in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        LoadPrompts();
        LoadQuestions();
    }
    public void LoadPrompts()
    {
        string[] fileLines = System.IO.File.ReadAllLines("prompts.txt");
        foreach (string line in fileLines)
        {
            _prompts.Add(line);
        }
    }
    public void LoadQuestions()
    {
        string[] fileLines = System.IO.File.ReadAllLines("questions.txt");
        foreach (string line in fileLines)
        {
            _questions.Add(line);
        }
    }
    public void Display()
    {
        Console.WriteLine("\n\nConsider the following prompt:\n\n");
        Console.WriteLine($"-- -- {GetRandomPrompt()} -- --\n\n");
        Console.WriteLine("When you have something in mind, press enter to continue.\n\n");
        Console.ReadLine();
        Console.Write("\nNow ponder on each of the following questions as they related to this experience.\nYou may begin in: ");
        CountDown(5);
        Console.Clear();
        while (GetLength() > 0)
        {
            Console.Write($"{GetRandomQuestion()} ");
            if (GetLength() < 15)
            {
                GetAnimation(GetLength());
                SubtractLength(GetLength());
            }
            else
            {
                GetAnimation(15);
                SubtractLength(15);
            }
            Console.WriteLine();
        }
        EndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        if (_prompts.Count == 0)
        {
            LoadPrompts();
        }
        int randomNum = random.Next(_prompts.Count);
        return _prompts[randomNum];
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        if (_questions.Count == 0)
        {
            LoadQuestions();
        }
        int randomNum = random.Next(_questions.Count);
        string returnQuestion = _questions[randomNum];
        _questions.Remove(_questions[randomNum]);
        return returnQuestion;
    }
    public void AddQuestion()
    {
        using (StreamWriter outputFile = new StreamWriter("questions.txt",true))
        {
            string userInput = "";
            while (userInput != "quit")
            {
                Console.WriteLine("Please write a new question for the reflection activity. Type 'quit' to end");
                userInput = Console.ReadLine();
                if (userInput != "quit")
                {
                    outputFile.WriteLine(userInput);
                }
            }
        }
    }
    public void AddPrompt()
    {
        using (StreamWriter outputFile = new StreamWriter("prompts.txt",true))
        {
            string userInput = "";
            while (userInput != "quit")
            {
                Console.WriteLine("Please write a new prompt for the reflection activity. Type 'quit' to end");
                userInput = Console.ReadLine();
                if (userInput != "quit")
                {
                    outputFile.WriteLine(userInput);
                }
            }
        }
    }
}

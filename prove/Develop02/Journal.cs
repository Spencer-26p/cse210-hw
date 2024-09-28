using System.IO;
class Journal
{
    public List<Entry> _entries = new List<Entry>();
    
    public void GetMenu()
    {
        string userInput = "no";
        while (userInput != "Exit")
        {
            Console.WriteLine("Journal Menu");
            Console.WriteLine("_____________________");
            Console.WriteLine("E - Create new entry into Journal.");
            Console.WriteLine("L - Load from file.");
            Console.WriteLine("S - Save to a file.");
            Console.WriteLine("C - See currently loaded entries.");
            Console.WriteLine("Exit - Exit the Journal.");
            userInput = Console.ReadLine();
            Console.WriteLine("");
            if (userInput != "E" && userInput != "L" && userInput != "S" && userInput != "C" && userInput != "Exit")
            {
                Console.WriteLine("User Input Invalid, try again please!");
                Console.WriteLine("");
            }
            else if (userInput == "E")
            {
                PromptEntry();
            }
            else if (userInput == "L")
            {
                LoadFile();
            }
            else if (userInput == "S")
            {
                WriteFile();
            }
            else if (userInput == "C")
            {
                Display();
            }
        }
    }
    public void WriteFile()
    {
        string fileName;
        Console.WriteLine("What is the name of the file?");
        fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            Console.WriteLine("Saving...");
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}!@#{entry._prompt}!@#{entry._entry}");
            }
        }
    }
    public void LoadFile()
    {
        string fileName = "";
        Console.WriteLine("What is the name of the file?");
        fileName = Console.ReadLine();
        string[] fileLines = System.IO.File.ReadAllLines(fileName);
        Console.WriteLine("Loading...");
        foreach (string line in fileLines)
        {
            string[] items = line.Split("!@#");
            Entry loadEntry = new Entry();
            loadEntry._date = items[0];
            loadEntry._prompt = items[1];
            loadEntry._entry = items[2];
            _entries.Add(loadEntry);
        }

    }
    public void PromptEntry()
    {
        Entry entry = new Entry();
        entry.SetDate();
        entry.GetPrompt();
        entry.GetEntry();
        _entries.Add(entry);
    }
    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine("");
        }
    }

}
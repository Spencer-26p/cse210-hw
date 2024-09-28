using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Digital Journal!");
        Journal journal = new Journal();
        journal.GetMenu();
        Console.WriteLine("Goodbye!");
    }
}

/* class Journal 
{
    List<Entry> entites;
    void WriteFile();
    void LoadFile();
    void PromptEntry();

}

class Entry 
{
    string prompt;
    string repsonse;
    DateTime date;

    void SetResponse();

    string GetResponse();

    string setDate();

    string getPrompt();
    
    void Display();

}

class Prompt
{
    List<string> prompts;
    void addPrompt(string prompt);

    string GeneratePrompt();

} */
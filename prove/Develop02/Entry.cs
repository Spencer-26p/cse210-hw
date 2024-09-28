using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _entry;
    public void SetDate()
     {
        DateTime timeStamp = DateTime.Now;
        _date = timeStamp.ToShortDateString();
     }

     public void GetPrompt()
     {
        PromptGenerator prompt = new PromptGenerator();
        _prompt = prompt.GetRandomPrompt();
     }

     public void GetEntry()
     {
        Console.WriteLine($"{_prompt}");
        _entry = Console.ReadLine(); 
     }

     public void Display()
     {
        Console.WriteLine($"Date:{_date}");
        Console.WriteLine($"Prompt:{_prompt}");
        Console.WriteLine($"Entry:{_entry}");
     }

}
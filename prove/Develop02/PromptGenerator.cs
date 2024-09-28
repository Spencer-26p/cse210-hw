using System.ComponentModel.DataAnnotations;

class PromptGenerator
{
    public List<string> _prompts = new List<string>();



    public string GetRandomPrompt()
    {
        _prompts.Add("Explain the most enjoyable thing you did today.");
        _prompts.Add("Give a brief summary of the best converstaion you had today.");
        _prompts.Add("What were you most excited about today?");
        _prompts.Add("Explain a task you completed that you feel good about completing.");
        _prompts.Add("Write the name of a song that describes today's events.");
        Random randomGenerator = new Random();
        int randomNum = randomGenerator.Next(0,_prompts.Count - 1);
        return _prompts[randomNum];
    }
}
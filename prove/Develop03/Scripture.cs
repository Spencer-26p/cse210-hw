using System.ComponentModel.DataAnnotations;

class Scripture
{
    private List<Word> _words = new List<Word>();
    private string _reference;
    private int _notHiddenWords;

    public Scripture(string rawText, string reference)
    {
        _reference = reference;
        string[] splitText = rawText.Split(" ",StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in splitText)
        {
            Word singleWord = new Word(word);
            _words.Add(singleWord);
        }
        _notHiddenWords = _words.Count();
    }
    public void HideWords()
    {
        Random number = new Random();
        int stepCount = 3;
        if (_notHiddenWords < 3)
        {
            stepCount = _notHiddenWords;
        }
        for (int i = stepCount; i > 0; i--)
        {
            Boolean hidden = false;
            while (!hidden)
            {
                int randomNum = number.Next(_words.Count);
                if (!_words[randomNum].GetHidden())
                {
                    _words[randomNum].Hide();
                    hidden = true;
                    _notHiddenWords -=1;
                }
            }
        }
    }
    public Boolean CheckCompletelyHidden() 
    {
        foreach (Word word in _words)
        {
            if (word.GetHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
    public void Display()
    {
        Console.Write($"{_reference} ");
        foreach(Word word in _words)
        {
            Console.Write($"{word.GetFormatedWord()} ");

        }
    }
}


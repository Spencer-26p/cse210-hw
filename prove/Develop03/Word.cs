class Word
{
    private Boolean _hidden = false;
    private string _wordText;
    private string _wordState;


    public Word(string text)
    {
        _wordText = text;
        _wordState = _wordText;
    }
    public void Hide()
    {
        _wordState = "";
        foreach (char letter in _wordText)
        {
            _wordState += "_";
        }
        _hidden = true;

    }
    public string GetFormatedWord() 
    {
        return _wordState;
    }
    public Boolean GetHidden()
    {
        return _hidden;
    }
    public string GetOriginalWord()
    {
        return _wordText;
    }
}

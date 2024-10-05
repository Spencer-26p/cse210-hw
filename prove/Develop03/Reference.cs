using System.Security.Cryptography;

class Reference
{
    private string _book;
    private int _chapter;
    private int _beginVerse;
    private int _endVerse;

    public Reference(string reference)
    {
        char[] splitters = new char[] {' ',':','-'};
        string[] splitReference = reference.Split(splitters,StringSplitOptions.RemoveEmptyEntries);
        _book = splitReference[0];
        _chapter = int.Parse(splitReference[1]);
        _beginVerse = int.Parse(splitReference[2]);
        if (splitReference.Length == 4)
        {
        _endVerse = int.Parse(splitReference[3]);
        }
    }
    public string GetDisplayText()
    {
        if (_endVerse == 0)
        {
            return _book + " " + _chapter + ":" + _beginVerse;
        }
        else
        {
            return _book + " " + _chapter + ":" + _beginVerse + "-" + _endVerse;
        }
    }
}

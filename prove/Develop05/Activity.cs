using System.Runtime.InteropServices;

class Activity
{

    private int _length;
    private string _name;
    private string _description;

    public Activity(string name, string description)
    {
        _length = 30;
        _name = name;
        _description = description;
    }
    public void StartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine(_description);
        SetLength();
        Console.Clear();
        Console.Write("\n\nGet Ready...");
        GetAnimation(5);
    }
    public void SetLength()
    {
        Console.WriteLine("How long would you like for your session to last in seconds?");
        _length = int.Parse(Console.ReadLine());
    }
    public void SubtractLength(int subtraction)
    {
        _length -=subtraction;
    }
    public int GetLength()
    {
        return _length;
    }
    public void EndingMessage()
    {
        Console.WriteLine("\nHopefully, you feel better today!");
        GetAnimation(5);
    }
    public void GetAnimation(int length)
    {
        length *=1000;
        int tick = 0;
        while (length > 0)
        {
            switch(tick % 8)
            {
                case 0:
                    Console.Write("-");
                    break;
                case 1:
                    Console.Write("\\");
                    break;
                case 2:
                    Console.Write("|");
                    break;
                case 3:
                    Console.Write("/");
                    break;
                case 4:
                    Console.Write("-");
                    break;
                case 5:
                    Console.Write("\\");
                    break;
                case 6:
                    Console.Write("|");
                    break;
                case 7:
                    Console.Write("/");
                    break;
                default:
                    break;

            }
            Thread.Sleep(500);
            Console.Write("\b \b");
            length -= 500;
            tick+=1;
        }
    }
    public void CountDown(int length)
    {
        length *=1000;
        while (length > 0)
        {
            Console.Write(length/1000);
            Thread.Sleep(1000);
            length -= 1000;
            Console.Write("\b \b");
        }
    }
}

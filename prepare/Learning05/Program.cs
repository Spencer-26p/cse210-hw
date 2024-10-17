using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        MathAssignment math =  new MathAssignment("Robert Rodriguez","Fractions","7.3","9-13");
        Console.WriteLine($"{math.GetSummary()}\n{math.GetHomeworkList()}\n\n");
        WritingAssignment writing = new WritingAssignment("Mary Waters","European History","The Causes of World War II");
        Console.WriteLine($"{writing.GetSummary()}\n{writing.GetWrtiingInformation()}\n\n");
    }
}
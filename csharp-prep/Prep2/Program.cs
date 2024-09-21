using System;

class Program
{
    static void Main(string[] args)
    {
        string gradeLetter = "Z";
        string gradeModifier = "";
        string response = " ";
        Console.Write("What is your grade percentage (don't include % sign)? ");
        string gradePercent = Console.ReadLine();
        int grade = int.Parse(gradePercent);
        if (grade>=90)
        {
            gradeLetter = "A";
        } 
        else if (grade >= 80 && grade < 90)
        {
            gradeLetter = "B";
        }
        else if (grade >= 70 && grade < 80)
        {
            gradeLetter = "C";
        }
        else if (grade >= 60 && grade < 70)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter ="F";
        }
        int gradeRemainder = grade % 10;
        if (gradeRemainder >= 7 && (gradeLetter != "A" && gradeLetter != "F"))
        {
            gradeModifier = "+";
        }
        else if (gradeRemainder <= 3 && ( gradeLetter != "F"))
        {
            gradeModifier = "-";
        }
        if (grade >= 70)
        {
            response = "Congratulations! You passed";
        }
        else
        {
            response = "I'm sorry you may need to try again. You did not pass";
        }
        Console.WriteLine($"{response} with a {grade}, which is a(n) {gradeLetter}{gradeModifier} .");
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Fraction1");
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetTop());
        Console.WriteLine(fraction1.GetBottom());
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());
        fraction1.SetTop((fraction1.GetTop()*5));
        fraction1.SetBottom((fraction1.GetBottom()*5));
        Console.WriteLine("Change!");
        Console.WriteLine(fraction1.GetTop());
        Console.WriteLine(fraction1.GetBottom());
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine();
        Console.WriteLine("Fraction2");
        Fraction fraction2 = new Fraction(1);
        Console.WriteLine(fraction2.GetTop());
        Console.WriteLine(fraction2.GetBottom());
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());
        fraction2.SetTop((fraction2.GetTop()*5));
        fraction2.SetBottom((fraction2.GetBottom()*5));
        Console.WriteLine("Change!");
        Console.WriteLine(fraction2.GetTop());
        Console.WriteLine(fraction2.GetBottom());
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine();
        Console.WriteLine("Fraction3");
        Fraction fraction3 = new Fraction(5);
        Console.WriteLine(fraction3.GetTop());
        Console.WriteLine(fraction3.GetBottom());
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
        fraction3.SetTop((fraction3.GetTop()*5));
        fraction3.SetBottom((fraction3.GetBottom()*5));
        Console.WriteLine("Change!");
        Console.WriteLine(fraction3.GetTop());
        Console.WriteLine(fraction3.GetBottom());
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
        Console.WriteLine();
        Console.WriteLine("Fraction4");
        Fraction fraction4 = new Fraction(3,4);
        Console.WriteLine(fraction4.GetTop());
        Console.WriteLine(fraction4.GetBottom());
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());
        fraction4.SetTop((fraction4.GetTop()*5));
        fraction4.SetBottom((fraction4.GetBottom()*5));
        Console.WriteLine("Change!");
        Console.WriteLine(fraction4.GetTop());
        Console.WriteLine(fraction4.GetBottom());
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());
        Console.WriteLine();
        Console.WriteLine("Fraction5");
        Fraction fraction5 = new Fraction(1,3);
        Console.WriteLine(fraction5.GetTop());
        Console.WriteLine(fraction5.GetBottom());
        Console.WriteLine(fraction5.GetFractionString());
        Console.WriteLine(fraction5.GetDecimalValue());
        fraction5.SetTop((fraction5.GetTop()*5));
        fraction5.SetBottom((fraction5.GetBottom()*5));
        Console.WriteLine("Change!");
        Console.WriteLine(fraction5.GetTop());
        Console.WriteLine(fraction5.GetBottom());
        Console.WriteLine(fraction5.GetFractionString());
        Console.WriteLine(fraction5.GetDecimalValue());
        Console.WriteLine();
    }
}
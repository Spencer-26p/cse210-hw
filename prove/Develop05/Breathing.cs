using System.ComponentModel.DataAnnotations;

class Breathing : Activity 
{   
    public Breathing() : base("Breathing","This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on breathing.")
    {
    }
    public void Display()
    {
        while (GetLength() > 0)
        {
            int breatheIn = 4;
            int breatheOut = 6;
            if (GetLength() < 10)
            {
                breatheIn= GetLength() / 2;
                breatheOut = GetLength() / 2;
            }
            Console.Write("\n\nBreathe in... ");
            CountDown(breatheIn);
            Console.Write("\nBreathe out... ");
            CountDown(breatheOut);
            SubtractLength(breatheIn + breatheOut);
            if (GetLength() == 1)
            {
                SubtractLength(1);
            }
        }
        EndingMessage();
    }
}
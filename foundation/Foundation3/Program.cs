using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Activity> activities = new List<Activity>();
        Running running1 = new Running("05 Sept 2024",20.0,2.0);
        Running running2 = new Running("06 Sept 2024",31.25,3.56);
        Swimming swimming1 = new Swimming("07 Sept 2024",23.2,11.0);
        Swimming swimming2 = new Swimming("08 Sept 2024",41.52,21.5);
        Cycling cylcing1 = new Cycling("09 Sept 2024",57.23,23.21);
        Cycling cylcing2 = new Cycling("09 Sept 2024",13.5,16.21);
        activities.Add(running1);
        activities.Add(running2);
        activities.Add(swimming1);
        activities.Add(swimming2);
        activities.Add(cylcing1);
        activities.Add(cylcing2);
        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
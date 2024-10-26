using System.Diagnostics.Contracts;
using System.Net.Quic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints;

    public GoalManager()
    {
        _totalPoints = 0;
    }   

    public void Start()
    {
        string userInput = "";
        while (userInput != "quit")
        {
            Console.Clear();
            if (userInput == "invalid")
            {
                Console.WriteLine("Your selection was invalid!\n");
            }
            Console.WriteLine($"You have {_totalPoints} points.\n\nMenu Options:\n   1. Create New Goal \n   2. List Goals\n   3. Save Goals\n   4. Load Goals\n   5. Record Event\n   6. Remove Goal\n   7. Quit\n");
            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    GetGoalInfo();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    RemoveGoal();
                    break;
                case "7":
                    userInput = "quit";
                    break;
                default:
                    userInput = "invalid";
                    break;
            }
        }
    } 
    public void GetGoalInfo()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetGoalInfo());
        }
        Console.WriteLine("Press Enter to return to menu.");
        Console.ReadLine();
    }
    public void CreateGoal()
    {
        string userInput = "";
        while (userInput != "quit")
        {
            if(userInput == "invalid")
            {
                Console.WriteLine("Your selection was invalid!\n");
            }
            Console.WriteLine("Which kind of Goal do you want to create?\n");
            Console.WriteLine("Menu Options:\n   1. Simple Goal\n   2. Eternal Goal\n   3. Checklist Goal\n   4. Daily Goal\n   5. Quit\n");
            Console.Write("");
            Console.Write("Select a choice from the menu: \n");
            userInput = Console.ReadLine();
            if (int.Parse(userInput) > 0 && int.Parse(userInput) < 5)
            {
                string name = "";
                string description = "";
                int points = 0;
                Console.Write("Write the name of your goal: ");
                name = Console.ReadLine();
                Console.Write("\nWrite a short description of the goal: ");
                description = Console.ReadLine();
                Console.Write("\nWrite the amount of points for this goal: ");
                points = int.Parse(Console.ReadLine());
                switch(userInput)
                {
                    case "1":
                        SimpleGoal simpleGoal = new SimpleGoal(points,name,description,false);
                        _goals.Add(simpleGoal);
                        userInput = "quit";
                        break;
                    case "2":
                        EternalGoal eternalGoal = new EternalGoal(points,name,description,0);
                        _goals.Add(eternalGoal);
                        userInput = "quit";
                        break;
                    case "3":
                        int eventTarget = 0;
                        int bonusPoints = 0;
                        Console.Write("\nWrite the target number for this event: ");
                        eventTarget = int.Parse(Console.ReadLine());
                        Console.Write("\nWrite bonus points you get for completion: ");
                        bonusPoints = int.Parse(Console.ReadLine());
                        ChecklistGoal checklistGoal = new ChecklistGoal(points,name,description,eventTarget,bonusPoints,0);
                        _goals.Add(checklistGoal);
                        userInput = "quit";
                        break;
                    case "4":
                        DateTime lastEvent = DateTime.Now.AddDays(-1000);
                        int streak = 0;
                        DailyGoal dailyGoal = new DailyGoal(points,name,description,lastEvent,streak);
                        _goals.Add(dailyGoal);
                        userInput = "quit";
                        break;
                }
            } else if(userInput == "5")
            {
                userInput = "quit";
            } else
            {
                userInput = "invalid";
            }
        }
        ReturnToMenu(5);
    }
    public void RecordEvent()
    {
        string userInput = "";
        while (userInput != "quit")
        {
            if (_goals.Any())
            {
                userInput = DisplayGoalsMenu(userInput);
            } else 
            {
                userInput = "quit";
            }
            int count = _goals.Count();
            if(userInput == (count+1).ToString())
            {
                userInput = "quit";
            }
            else if((int.Parse(userInput) > 0 && int.Parse(userInput) < (_goals.Count()+1)) && !(_goals[int.Parse(userInput)-1].IsComplete()))
            {
                _totalPoints += _goals[int.Parse(userInput)-1].RecordEvent();
                Console.WriteLine($"You now have {_totalPoints} points!\n");
                ReturnToMenu(5);
                userInput = "quit";
            } else if(_goals[int.Parse(userInput)-1].IsComplete())
            {
                Console.WriteLine("Goal is already complete!");
                ReturnToMenu(5);
                userInput = "quit";
            } else
            {
                userInput = "bad";
            }
        }
    }
    public void SaveGoals()
    {
        string fileName;
        Console.WriteLine("What is the name of the file?");
        fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_totalPoints);
            Console.WriteLine("Saving...");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        _goals.Clear();
        string fileName = "";
        Console.WriteLine("What is the name of the file?");
        fileName = Console.ReadLine();
        string[] fileLines = System.IO.File.ReadAllLines(fileName);
        int count = 0;
        foreach (string line in fileLines)
        {
            if (count == 0)
            {
                _totalPoints = int.Parse(line);
            }
            string[] items = line.Split("!@#");
            switch(items[0])
            {
                case "SimpleGoal:":
                    SimpleGoal simpleGoal = new SimpleGoal(int.Parse(items[3]),items[1],items[2],bool.Parse(items[4]));
                    _goals.Add(simpleGoal);
                    break;
                case "EternalGoal:":
                    EternalGoal eternalGoal = new EternalGoal(int.Parse(items[3]),items[1],items[2],int.Parse(items[4]));
                    _goals.Add(eternalGoal);
                    break;
                case "ChecklistGoal:":
                    ChecklistGoal checklistGoal = new ChecklistGoal(int.Parse(items[3]),items[1],items[2],int.Parse(items[6]),int.Parse(items[5]),int.Parse(items[4]));
                    _goals.Add(checklistGoal);
                    break;
                case "DailyGoal:":
                    DailyGoal dailyGoal = new DailyGoal(int.Parse(items[3]),items[1],items[2],DateTime.Parse(items[4]),double.Parse(items[5]));
                    _goals.Add(dailyGoal);
                    break;
            }
            count +=1;
        }
    }
    public void ReturnToMenu(int length)
    {
        Console.WriteLine($"Returning to menu in... ");
        length *=1000;
        while (length > 0)
        {
            Console.Write(length/1000);
            Thread.Sleep(1000);
            length -= 1000;
            Console.Write("\b \b");
        }
    }
    public void RemoveGoal()
    {
        int count = _goals.Count();
        string userInput = "";
        while (userInput != "quit")
        {
            userInput = DisplayGoalsMenu(userInput);
            if(userInput == count.ToString())
            {
                userInput = "quit";
            }else if(int.Parse(userInput) > 0 && int.Parse(userInput) < _goals.Count())
            {
                 _goals.RemoveAt(int.Parse(userInput)-1);
                ReturnToMenu(5);
                userInput = "quit";
            } else
            {
                userInput = "bad";
            }
        }
    }
    public string DisplayGoalsMenu(string userInput)
    {
        int count = 1;
        userInput = "";
        if (userInput == "bad")
        {
            Console.WriteLine("Invalid input, try again!\n");
        }
        count = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{count}. {goal.GetName()}");
            count+=1;
        }
        Console.WriteLine($"{count}. Quit\n");
        Console.Write("Select a choice from the menu: ");
        userInput = Console.ReadLine();
        return userInput;
    }
}

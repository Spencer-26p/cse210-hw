class DailyGoal : Goal
{
    private DateTime _lastEvent;
    private double _streak;

    public DailyGoal(int points, string name, string description,DateTime lastEvent,double streak) : base(points,name,description)
    {
        _lastEvent = lastEvent;
        _streak = streak;
    }
    public override string GetStringRepresentation()
    {
        return "DailyGoal:"+"!@#"+GetName()+"!@#"+GetDescription()+"!@#"+GetPoints()+"!@#"+_lastEvent+"!@#"+_streak;
    }
    public override int RecordEvent()
    {
        DateTime latestTime = _lastEvent.AddDays(2);
        DateTime earliestTime = _lastEvent.AddHours(16);
        DateTime currentTime = DateTime.Now;
        if (currentTime >= latestTime)
        {
            _streak = 0;
        }
        if(currentTime < earliestTime)
        {
            Console.WriteLine("You've already done this activity today!");
            return 0;
        } else 
        {
            int points = GetPoints();
            int returnPoints = (int)Math.Round(points * (1 + (_streak*0.10)));
            _streak +=1;
            Console.WriteLine($"Congratulations, you recieved {returnPoints} points! You have a streak of {_streak}");
            _lastEvent = currentTime;
            return returnPoints;
        }
    }
    public override string GetGoalInfo()
    {
        string check = " ";
        if (IsComplete())
        {
            check = "X";
        }
        return ($"[{check}] {GetName()} ({GetDescription()}) -- Streak: {_streak}");    
    }
}
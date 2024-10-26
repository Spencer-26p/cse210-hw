class ChecklistGoal : Goal
{
    private int _eventCount;
    private int _bonusPoints;
    private int _eventTarget;

    public ChecklistGoal(int points, string name, string description, int eventTarget, int bonusPoints, int eventCount) : base(points,name,description)
    {
        _bonusPoints = bonusPoints;
        _eventTarget = eventTarget;
        _eventCount = eventCount;
    }
    public override int RecordEvent()
    {
        _eventCount += 1;
        if (IsComplete())
        {
            Console.WriteLine($"Congratulations, you recieved {GetPoints() + GetBonusPoints()} points!");
            return GetPoints() + GetBonusPoints();
        } else
        {
            Console.WriteLine($"Congratulations, you recieved {GetPoints()} points!");
            return GetPoints();
        }
    }
    public int GetBonusPoints()
    {
        return _bonusPoints;
    }
    public int GetEventCount()
    {
        return _eventCount;
    }
    public int GetEventTarget()
    {
        return _eventTarget;
    }
    public override string GetGoalInfo()
    {
        string check = " ";
        if (IsComplete())
        {
            check = "X";
        }
        return ($"[{check}] {GetName()} ({GetDescription()}) -- Currently Completed: {GetEventCount()}/{GetEventTarget()}");    
    }
    public override bool IsComplete()
    {
        if (_eventCount == _eventTarget)
        {
            return true;
        } else
        {
            return false;
        }
    }
    public override string GetStringRepresentation()
    {
        return "ChecklistGoal:"+"!@#"+GetName()+"!@#"+GetDescription()+"!@#"+GetPoints()+"!@#"+GetEventCount()+"!@#"+GetBonusPoints()+"!@#"+GetEventTarget();
    }
}
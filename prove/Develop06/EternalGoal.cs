using System.Dynamic;

class EternalGoal : Goal
{
    private int _totalCount;

    public EternalGoal(int points, string name, string description, int totalCount) : base(points,name,description)
    {
        _totalCount = totalCount;
    }
    public override int RecordEvent()
    {
        _totalCount +=1;
        Console.WriteLine($"Congratulations, you recieved {GetPoints()} points!");
        return GetPoints();
    }
    public int GetEventCount()
    {
        return _totalCount;
    }
    public void SetTotalCount(int totalCount)
    {
        _totalCount = totalCount;
    }
    public override bool IsComplete()
    {
        return false;
    }
    public int GetTotalCount()
    {
        return _totalCount;
    }
    public override string GetStringRepresentation()
    {
        return "EternalGoal:"+"!@#"+GetName()+"!@#"+GetDescription()+"!@#"+GetPoints()+"!@#"+GetTotalCount();
    }
    public override string GetGoalInfo()
    {
        string check = " ";
        if (IsComplete())
        {
            check = "X";
        }
        return ($"[{check}] {GetName()} ({GetDescription()}) -- Currently Completed: {GetEventCount()} times.");    
    }
}
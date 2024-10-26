using System.Runtime.InteropServices;

class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(int points, string name, string description,bool isComplete) : base(points, name, description)
    {
        _isComplete = isComplete;
    }
    public override string GetStringRepresentation()
    {
        return "SimpleGoal:"+"!@#"+GetName()+"!@#"+GetDescription()+"!@#"+GetPoints()+"!@#"+IsComplete();
    }
    public override int RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations, you recieved {GetPoints()} points!");
        return GetPoints();
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
}
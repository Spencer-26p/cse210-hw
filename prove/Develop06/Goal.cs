class Goal
{
    private int _pointValue;
    private string _name;
    private string _description;

    public Goal(int points, string name, string description)
    {
        _pointValue = points;
        _name = name;
        _description = description;
    }
    public virtual int RecordEvent()
    {
        return _pointValue;
    }
    public int GetPoints()
    {
        return _pointValue;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    
    public virtual string GetGoalInfo()
    {
        string check = " ";
        if (IsComplete())
        {
            check = "X";
        }
        return ($"[{check}] {_name} ({_description})");
    }
    public virtual string GetStringRepresentation()
    {
        return "";
    }
    public virtual bool IsComplete()
    {
        return false;
    } 
}


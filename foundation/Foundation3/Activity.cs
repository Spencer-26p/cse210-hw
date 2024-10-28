class Activity
{
    private string _date;
    private double _length;
    public Activity(string date,double length)
    {
        _date = date;
        _length = length;
    }
    public virtual double GetDistance()
    {
        return Math.Round(GetSpeed()/60 * GetLength(),2);
    }

    public string GetSummary()
    {
        return GetDate() + " " + GetName() + " (" + GetLength() + " min): Distance " + GetDistance() + " miles, Speed " + GetSpeed() + " mph, Pace: " + GetPace() + " minutes per mile";   
    }
    public virtual string GetName()
    {
        return "";
    }
    public string GetDate()
    {
        return _date;
    }
    public double GetLength()
    {
        return _length;
    }
    public virtual double GetSpeed()
    {
        return Math.Round((GetDistance()/GetLength()) * 60,2);
    }
    public virtual double GetPace()
    {
        return Math.Round(GetLength()/GetDistance(),2);
    }
}
class Running : Activity
{
    private double _distance;

    public Running(string date,double length,double distance) : base(date,length)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override string GetName()
    {
        return "Running";   
    }
}
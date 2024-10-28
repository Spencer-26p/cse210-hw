class Swimming : Activity
{
    private double _laps;

    public Swimming(string date,double length, double laps) : base(date,length)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return Math.Round((_laps * 50 / 1000 * 0.62),2);
    }
    public override string GetName()
    {
        return "Swimming";   
    }
}
class Cycling : Activity
{
    private double _speed;

    public Cycling(string date,double length,double speed) : base(date,length)
    {
        _speed = speed;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override string GetName()
    {
        return "Cycling";   
    }
}
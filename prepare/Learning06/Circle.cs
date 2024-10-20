class Circle : Shape
{
    private double _radius;

    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        return 3.141592653 * Math.Pow(_radius,2);
    }
}
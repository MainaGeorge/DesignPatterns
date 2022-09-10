namespace DesignPatterns.Composite;

public class Square : Shape
{
    public Square() : base("Square")
    {
    }

    public override string Draw()
    {
        return $"{Name}";
    }
}
namespace DesignPatterns.Composite;

public class Circle : Shape
{
    public Circle() : base("Circle")
    {
    }

    public override string Draw()
    {
        return $"{Name}";
    }
}
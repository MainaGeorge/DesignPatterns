namespace DesignPatterns.Template;

public class Circle : Shape
{
    public Circle(int brushSize, string color) : base(brushSize, color)
    {
    }

    public Circle()
    {
    }

    protected override string DrawShape()
    {
        return $"drawing a {Color} circle with brush size {BrushSize} pixels";
    }
}
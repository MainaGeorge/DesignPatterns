namespace DesignPatterns.Template;

public class Square : Shape
{
    public Square()
    {
    }
    public Square(int brushSize, string color) : base(brushSize, color)
    {
    }

    protected override string DrawShape()
    {
        return $"drawing a {Color} square with brush size {BrushSize} pixels";
    }
}
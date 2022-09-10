namespace DesignPatterns.Composite;

public interface IDrawable
{
    string Draw();
}
public abstract class Shape : IDrawable
{
    public string Name { get; }

    protected Shape(string name)
    {
        Name = name;
    }

    public abstract string Draw();
}
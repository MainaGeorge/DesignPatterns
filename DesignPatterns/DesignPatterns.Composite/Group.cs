using System.Text;

namespace DesignPatterns.Composite;

public class Group : IDrawable
{
    public HashSet<IDrawable> DrawableObjects { get; } = new();
    private IEnumerable<string>? _drawableNames;

    public void AddDrawableObject(IDrawable drawable)
    {
        if (drawable != this)
            DrawableObjects.Add(drawable);
    }
    public string Draw()
    {
        var stringBuilder = new StringBuilder();
        foreach (var drawableObject in DrawableObjects)
            stringBuilder.Append(drawableObject.Draw()).Append(' ');

        var drawableMessage = stringBuilder.ToString();
        _drawableNames = drawableMessage.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        return drawableMessage;
    }

    public int GetNumberOfDrawableObjectOfType<T>() where T : Shape
    {
        var count = 0;
        foreach (var obj in DrawableObjects)
            switch (obj)
            {
                case T:
                    count++;
                    break;
                case Group g:
                    count += g.DrawableObjects.OfType<T>()?.Count() ?? 0;
                    break;
            }
        return count;
    }

    public int GetDrawnMessagesOfConcreteShape(string shapeName)
    {
        return _drawableNames?.Count(n => n.Equals(shapeName, StringComparison.CurrentCultureIgnoreCase)) ?? 0;
    }
}
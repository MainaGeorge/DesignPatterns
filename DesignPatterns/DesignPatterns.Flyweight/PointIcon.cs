namespace DesignPatterns.Flyweight;

public class PointIcon
{
    private readonly string _iconFilepath;
    private readonly PointType _pointType;
    public override string ToString()
    {
        return $"{_pointType} icon form {_iconFilepath}";
    }

    public PointIcon(string iconFilepath, PointType pointType)
    {
        _iconFilepath = iconFilepath;
        _pointType = pointType;
    }
}
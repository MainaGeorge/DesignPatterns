namespace DesignPatterns.Strategy;

public class HighContrastImageFilter : IImageFilter
{
    public string ApplyFilter(string filename)
    {
        return "applied high contrast filter";
    }
}
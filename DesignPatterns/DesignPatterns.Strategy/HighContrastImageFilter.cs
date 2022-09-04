namespace DesignPatterns.Strategy;

public class HighContrastImageFilter : IImageFilter
{
    public string ApplyFilter(string filename) => "applied high contrast filter";
}
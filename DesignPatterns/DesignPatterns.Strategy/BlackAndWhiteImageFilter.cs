namespace DesignPatterns.Strategy;

public class BlackAndWhiteImageFilter : IImageFilter
{
    public string ApplyFilter(string filename) => "applied black and white filter";
}
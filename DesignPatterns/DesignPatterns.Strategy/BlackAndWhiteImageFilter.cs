namespace DesignPatterns.Strategy;

public class BlackAndWhiteImageFilter : IImageFilter
{
    public string ApplyFilter(string filename)
    {
        return "applied black and white filter";
    }
}
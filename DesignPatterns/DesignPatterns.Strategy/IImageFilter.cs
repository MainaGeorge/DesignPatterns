namespace DesignPatterns.Strategy;

public interface IImageFilter
{
    string ApplyFilter(string filename);
}
namespace DesignPatterns.Strategy;

public class PngImageCompressor : IImageCompressor
{
    public string Compress(string filename)
    {
        return "compressed image using PNG algorithm";
    }
}
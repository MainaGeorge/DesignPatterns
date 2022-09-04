namespace DesignPatterns.Strategy;

public class PngImageCompressor : IImageCompressor
{
    public string Compress(string filename) => "compressed image using PNG algorithm";
}
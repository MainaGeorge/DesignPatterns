namespace DesignPatterns.Strategy;

public class JpegImageCompressor : IImageCompressor
{
    public string Compress(string filename) => "compressed image using JPEG algorithm";
}
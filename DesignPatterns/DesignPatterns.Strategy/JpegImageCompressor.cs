namespace DesignPatterns.Strategy;

public class JpegImageCompressor : IImageCompressor
{
    public string Compress(string filename)
    {
        return "compressed image using JPEG algorithm";
    }
}
namespace DesignPatterns.Strategy
{
    public class ImageStorage
    {
        public static string StoreImage(string filename, IImageCompressor compressor, IImageFilter filter)
        {
            var compressedImage = compressor.Compress(filename);
            var appliedFilter = filter.ApplyFilter(filename);

            return $"{compressedImage} and {appliedFilter}";
        }
    }
}
using DesignPatterns.Strategy;

namespace DesignPatterns.Tests
{
    public class StrategyTests
    {
        [Theory]
        [InlineData("compressed image using JPEG algorithm and applied black and white filter")]
        public void ImageStorage_CompressesAndFilters_BlackAndWhiteWithJpeg(string expectedMessage)
        {
            var compressor = new JpegImageCompressor();
            var filter = new BlackAndWhiteImageFilter();

            var storedImageMessage = ImageStorage.StoreImage("someImage", compressor, filter);

            Assert.True(expectedMessage.Equals(storedImageMessage, StringComparison.CurrentCultureIgnoreCase));
        }

        [Theory]
        [InlineData("compressed image using PNG algorithm and applied high contrast filter")]
        public void ImageStorage_CompressesAndFilters_HighContrastWithPng(string expectedMessage)
        {
            var compressor = new PngImageCompressor();
            var filter = new HighContrastImageFilter();

            var storedImageMessage = ImageStorage.StoreImage("someImage", compressor, filter);

            Assert.True(expectedMessage.Equals(storedImageMessage, StringComparison.CurrentCultureIgnoreCase));
        }
    }
}

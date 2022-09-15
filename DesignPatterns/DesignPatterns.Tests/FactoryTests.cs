using DesignPatterns.Factory;

namespace DesignPatterns.Tests
{
    public class FactoryTests
    {
        [Fact]
        public void Factory_DefersViewCreation_ToSubClass()
        {
            var defaultRenderer = new HtmlRenderer();
            var clientRenderer = new ClientHtmlRenderer();
            var clientTwoRenderer = new ClientTwoHtmlRenderer();

            Assert.Equal("rendering content with Karma View Engine", defaultRenderer.RenderContent("content"));
            Assert.Equal("rendering content with Beta View Engine", clientTwoRenderer.RenderContent("content"));
            Assert.Equal("rendering content with Kilo View Engine", clientRenderer.RenderContent("content"));
        }
    }
}

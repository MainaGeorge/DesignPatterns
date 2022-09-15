using DesignPatterns.Template;

namespace DesignPatterns.Tests
{
    public class TemplateTests
    {
        [Theory]
        [InlineData("black")]
        public void Template_CorrectlySetsShapeColor(string color)
        {
            var circle = new Circle();
            var square = new Square();

            var drawnCircle = circle.Draw();
            var drawnSquare = square.Draw();

            Assert.Contains(color, drawnSquare);
            Assert.Contains(color, drawnCircle);

        }

        [Theory]
        [InlineData(2)]
        public void Template_CorrectlySetsBrushSize(int brushSize)
        {
            var circle = new Circle();
            var square = new Square();

            var drawnCircle = circle.Draw();
            var drawnSquare = square.Draw();

            Assert.Contains(brushSize.ToString(), drawnSquare);
            Assert.Contains(brushSize.ToString(), drawnCircle);

        }

        [Theory]
        [InlineData(4, "red")]
        public void ConcreteShape_CanSetTemplateBrushSizeAndColor(int brushSize, string color)
        {
            var circle = new Circle(brushSize, color);
            var drawnCircle = circle.Draw();

            Assert.Contains(color, drawnCircle);
            Assert.Contains(brushSize.ToString(), drawnCircle);
        }
    }
}

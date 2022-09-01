using DesignPatterns.State;

namespace DesignPatterns.Tests
{
    public class StateTests
    {
        [Theory]
        [InlineData("stopped selection of content", "started selection of content")]
        public void State_ProducesRightResult_WithSelectionTool
            (string mouseUpMessage, string mouseDownMessage)
        {
            var canvas = new Canvas(new SelectionTool());

            Assert.Equal(canvas.MouseDown(), mouseDownMessage);
            Assert.Equal(canvas.MouseUp(), mouseUpMessage);
        }

        [Theory]
        [InlineData("completed deletion selected content", "started deletion of content")]
        public void State_ProducesRightResult_WithDeletionTool
            (string mouseUpMessage, string mouseDownMessage)
        {
            var canvas = new Canvas(new DeletionTool());

            Assert.Equal(canvas.MouseDown(), mouseDownMessage);
            Assert.Equal(canvas.MouseUp(), mouseUpMessage);
        }

        [Theory]
        [InlineData("brushed selected content", "started selection of content to brush")]
        public void State_ProducesRightResult_WithBrushTool
            (string mouseUpMessage, string mouseDownMessage)
        {
            var canvas = new Canvas(new BrushTool());

            Assert.Equal(canvas.MouseDown(), mouseDownMessage);
            Assert.Equal(canvas.MouseUp(), mouseUpMessage);
        }
    }
}

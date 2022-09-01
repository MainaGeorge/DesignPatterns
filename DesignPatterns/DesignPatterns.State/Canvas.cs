namespace DesignPatterns.State
{
    public class Canvas
    {
        private readonly ITool _tool;
        public Canvas(ITool tool)
        {
            _tool = tool;
        }

        public string MouseUp() => _tool.MouseUp();
        public string MouseDown() => _tool.MouseDown();
    }
}
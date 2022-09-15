namespace DesignPatterns.State
{
    public class Canvas
    {
        private readonly ITool _tool;
        public Canvas(ITool tool)
        {
            _tool = tool;
        }

        public string MouseUp()
        {
            return _tool.MouseUp();
        }

        public string MouseDown()
        {
            return _tool.MouseDown();
        }
    }
}
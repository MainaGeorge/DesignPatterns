namespace DesignPatterns.State
{
    public class DeletionTool : ITool
    {
        public string MouseUp()
        {
            return "completed deletion selected content";
        }

        public string MouseDown()
        {
            return "started deletion of content";
        }
    }
}

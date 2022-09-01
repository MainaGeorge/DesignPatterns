namespace DesignPatterns.State
{
    public class DeletionTool : ITool
    {
        public string MouseUp() => "completed deletion selected content";
        public string MouseDown() => "started deletion of content";
    }
}

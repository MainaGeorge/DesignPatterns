namespace DesignPatterns.State;

public class SelectionTool : ITool
{
    public string MouseUp()
    {
        return "stopped selection of content";
    }

    public string MouseDown()
    {
        return "started selection of content";
    }
}
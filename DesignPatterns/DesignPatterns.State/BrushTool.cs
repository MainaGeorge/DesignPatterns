namespace DesignPatterns.State;

public class BrushTool : ITool
{
    public string MouseUp()
    {
        return "brushed selected content";
    }

    public string MouseDown()
    {
        return "started selection of content to brush";
    }
}
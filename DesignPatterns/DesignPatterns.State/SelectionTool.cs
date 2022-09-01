namespace DesignPatterns.State;

public class SelectionTool : ITool
{
    public string MouseUp() => "stopped selection of content";
    public string MouseDown() => "started selection of content";
}
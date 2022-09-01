namespace DesignPatterns.State;

public class BrushTool : ITool
{
    public string MouseUp() => "brushed selected content";
    public string MouseDown() => "started selection of content to brush";
}
namespace DesignPatterns.Momento
{
    public class EditorState
    {
        public string? Title { get; set; }
        public string? Content { get; set; }

        public EditorState(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }
}
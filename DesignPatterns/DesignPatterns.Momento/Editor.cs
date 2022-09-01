namespace DesignPatterns.Momento
{
    public class Editor
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public Editor(string title, string content)
        {
            Title = title;
            Content = content;
        }

        public EditorState SetState()
        {
            return new EditorState(Title!, Content!);
        }

        public void UndoChanges(EditorState state)
        {
            if (state is null || state.Title is null || state.Content is null)
                throw new InvalidOperationException("Can not revert to a non existent state");
            Title = state.Title;
            Content = state.Content;
        }

    }
}
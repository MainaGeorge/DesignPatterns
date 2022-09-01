namespace DesignPatterns.Tests
{
    public class MomentoTests
    {
        [Theory]
        [InlineData("javascript", "objects")]
        public void Momento_SetsStateCorrectly(string title, string content)
        {
            var history = new StateHistory<EditorState>();
            var editor = new Editor(title, content);

            history.PushState(editor.SetState());
            var state = history.PopState();

            Assert.Equal(title, state.Title);
            Assert.Equal(content, state.Content);
        }

        [Theory]
        [InlineData("StateHistory does not contain any items")]
        public void Momento_HistoryThrowsError_IfPopedWhenEmpty(string errorMessage)
        {
            var history = new StateHistory<EditorState>();

            var error = Assert.Throws<InvalidOperationException>(() => history.PopState());
            Assert.Equal(errorMessage, error.Message);
        }

        [Theory]
        [InlineData("javascript", "objects", "Can not revert to a non existent state")]
        public void Momento_EditorThrowsError_RevertedToNonExistentState(string title, string content, string errorMessage)
        {
            var editor = new Editor(title, content);

            var error = Assert.Throws<InvalidOperationException>(() => editor.UndoChanges(null));
            Assert.Equal(errorMessage, error.Message);
        }

        [Theory]
        [InlineData("javascript", "objects")]
        public void Momento_EditorCorrectlyReturnsToPreviousState(string title, string content)
        {
            var history = new StateHistory<EditorState>();
            var editor = new Editor(title, content);

            history.PushState(editor.SetState());
            editor.Title = "new title";
            editor.Content = "new content";

            editor.UndoChanges(history.PopState());

            Assert.Equal(title, editor.Title);
            Assert.Equal(content, editor.Content);
        }
    }
}

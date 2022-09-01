using DesignPatterns.Momento;

namespace DesignPatterns.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor("html basics", "paragraphs");
            var history = new StateHistory<EditorState>();
            history.PushState(editor.SetState());

            editor.Content = "links and images";

            Console.WriteLine($"current state of the editor: Title:{editor.Title} and Content:{editor.Content} ");

            editor.UndoChanges(history.PopState());
            Console.WriteLine($"current state of the editor: Title:{editor.Title} and Content:{editor.Content} ");
        }
    }
}
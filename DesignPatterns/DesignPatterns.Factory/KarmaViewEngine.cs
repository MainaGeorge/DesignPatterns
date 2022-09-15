namespace DesignPatterns.Factory
{
    public class KarmaViewEngine : IViewEngine
    {
        public override string ToString()
        {
            return "Karma View Engine";
        }
        public string Render(string html)
        {
            return $"rendering {html} with {this}";
        }
    }
}
namespace DesignPatterns.Factory
{
    public class BetaViewEngine : IViewEngine
    {
        public override string ToString()
        {
            return "Beta View Engine";
        }
        public string Render(string html)
        {
            return $"rendering {html} with {this}";
        }
    }
}
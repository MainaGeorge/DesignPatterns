namespace DesignPatterns.Factory
{
    public class KiloViewEngine : IViewEngine
    {
        public override string ToString()
        {
            return "Kilo View Engine";
        }
        public string Render(string html)
        {
            return $"rendering {html} with {this}";
        }
    }
}
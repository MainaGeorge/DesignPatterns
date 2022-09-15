namespace DesignPatterns.Factory
{
    public class HtmlRenderer
    {
        public string RenderContent(string htmlContent)
        {
            var viewEngine = ViewEngineFactory();
            return viewEngine.Render(htmlContent);
        }

        public virtual IViewEngine ViewEngineFactory() => new KarmaViewEngine();
    }
}
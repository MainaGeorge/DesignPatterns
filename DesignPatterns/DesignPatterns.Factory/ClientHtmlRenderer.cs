namespace DesignPatterns.Factory
{
    public class ClientHtmlRenderer : HtmlRenderer
    {
        public override IViewEngine ViewEngineFactory()
        {
            return new KiloViewEngine();
        }
    }
}
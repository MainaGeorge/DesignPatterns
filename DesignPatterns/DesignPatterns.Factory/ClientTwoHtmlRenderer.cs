namespace DesignPatterns.Factory
{
    public class ClientTwoHtmlRenderer : HtmlRenderer
    {
        public override IViewEngine ViewEngineFactory()
        {
            return new BetaViewEngine();
        }
    }
}
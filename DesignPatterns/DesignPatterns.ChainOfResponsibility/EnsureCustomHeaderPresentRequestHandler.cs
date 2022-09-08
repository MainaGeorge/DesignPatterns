namespace DesignPatterns.ChainOfResponsibility
{
    public class EnsureCustomHeaderPresentRequestHandler : RequestHandler
    {
        private readonly string _customHeader;

        public EnsureCustomHeaderPresentRequestHandler(RequestHandler? handler, string customHeader) : base("Custom Header", handler)
        {
            _customHeader = customHeader;
        }

        protected override bool HandleRequest(Request request)
        {
            return request.ContainsHeader(_customHeader);
        }
    }
}
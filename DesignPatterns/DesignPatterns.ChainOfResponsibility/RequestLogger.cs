namespace DesignPatterns.ChainOfResponsibility
{
    public class RequestLogger : RequestHandler
    {
        public RequestLogger(RequestHandler? handler) : base("Request Logger", handler)
        {
        }

        public bool LogginSucceeded { get; set; } = true;
        protected override bool HandleRequest(Request request)
        {
            return LogginSucceeded;
        }
    }
}
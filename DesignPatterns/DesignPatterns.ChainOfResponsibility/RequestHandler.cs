namespace DesignPatterns.ChainOfResponsibility
{
    public abstract class RequestHandler
    {
        protected string Name { get; set; }
        protected readonly RequestTracer _tracer = RequestTracer.Instance;
        private readonly RequestHandler? _handler;

        protected RequestHandler(string name, RequestHandler? handler)
        {
            Name = name;
            _handler = handler;
        }
        protected abstract bool HandleRequest(Request request);

        public void Handle(Request request)
        {
            if (HandleRequest(request))
            {
                _tracer.AddToHistory(Name);
                _handler?.Handle(request);
            }
        }

        public int GetNumberOfHandlersRun => _tracer.HistoryCount;
        public List<string> GetRunHandlers() => _tracer.GetHistory();
    }
}
namespace DesignPatterns.ChainOfResponsibility
{
    public class RequestTracer
    {
        private static readonly RequestTracer _tracer = new();
        private Stack<string> _requestTrace = new();
        public static RequestTracer Instance => _tracer;

        private RequestTracer() { }
        public void AddToHistory(string trace) => _requestTrace.Push(trace);
        public List<string> GetHistory() => _requestTrace.ToList();
        public int HistoryCount => _requestTrace.Count;
        public void ResetStackWithHistory() => _requestTrace = new Stack<string>();
    }
}
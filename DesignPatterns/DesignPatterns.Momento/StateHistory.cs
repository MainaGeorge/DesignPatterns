namespace DesignPatterns.Momento
{
    public class StateHistory<T> where T : class
    {
        private readonly Stack<T> _history = new Stack<T>();

        public void PushState(T state)
        {
            _history.Push(state);
        }

        public T PopState()
        {
            if (!_history.Any()) throw new InvalidOperationException("StateHistory does not contain any items");
            return _history.Pop();
        }
    }
}
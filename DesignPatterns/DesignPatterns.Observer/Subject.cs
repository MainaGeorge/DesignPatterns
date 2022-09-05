namespace DesignPatterns.Observer
{
    public abstract class Subject
    {
        private readonly List<ISubscriber> _observer = new();
        public void AddSubscriber(ISubscriber subscriber)
        {
            _observer.Add(subscriber);
        }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            _observer.Remove(subscriber);
        }

        public void Notify(object data)
        {
            foreach (var subscriber in _observer)
                subscriber.Notify(data);
        }
    }
}
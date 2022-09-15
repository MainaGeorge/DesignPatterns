namespace DesignPatterns.Iterator;

public class BrowserHistoryLinkedList
{
    private readonly LinkedList<string> _history = new();
    public void Push(string url)
    {
        _history.AddLast(url);
    }

    public string Pop()
    {
        if (_history.Count < 1)
            throw new InvalidOperationException();
        var lastItem = _history.Last?.Value;
        _history.RemoveLast();
        return lastItem!;
    }
    public BrowserHistoryLinkedListIterator GetIterator()
    {
        return new(this);
    }

    public class BrowserHistoryLinkedListIterator : IIterator<string>
    {
        private readonly BrowserHistoryLinkedList _browserBrowserHistoryLinkedList;


        public BrowserHistoryLinkedListIterator(BrowserHistoryLinkedList browserBrowserHistoryLinkedList)
        {
            _browserBrowserHistoryLinkedList = browserBrowserHistoryLinkedList;
        }
        public string Current()
        {
            return _browserBrowserHistoryLinkedList._history?.Last?.Value!;
        }

        public void MoveNext()
        {
            _browserBrowserHistoryLinkedList._history.RemoveLast();
        }

        public bool HasNext()
        {
            return _browserBrowserHistoryLinkedList._history?.Count > 0;
        }
    }
}
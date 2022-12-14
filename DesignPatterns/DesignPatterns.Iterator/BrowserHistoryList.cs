namespace DesignPatterns.Iterator;

public class BrowserHistoryList
{
    private readonly List<string> _visitedUrls = new();

    public void Push(string url)
    {
        _visitedUrls.Add(url);
    }

    public string Pop()
    {
        if (_visitedUrls.Count < 1)
            throw new InvalidOperationException();
        var lastItem = _visitedUrls[^1];
        _visitedUrls.Remove(lastItem);
        return lastItem;
    }

    public BrowserHistoryListIterator GetIterator()
    {
        return new(this);
    }

    public class BrowserHistoryListIterator : IIterator<string>
    {
        private int _index = 0;
        private readonly BrowserHistoryList _historyList;

        public BrowserHistoryListIterator(BrowserHistoryList historyList)
        {
            _historyList = historyList;
        }
        public string Current()
        {
            return _historyList._visitedUrls[_index];
        }

        public void MoveNext()
        {
            _index++;
        }

        public bool HasNext()
        {
            return _index < _historyList._visitedUrls.Count;
        }
    }
}
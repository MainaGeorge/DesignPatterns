using DesignPatterns.Iterator;

namespace DesignPatterns.Client
{
    internal static class Program
    {
        private static void Main()
        {
            var linkedListHistory = new BrowserHistoryLinkedList();
            var iterator = linkedListHistory.GetIterator();
            linkedListHistory.Push("facebook");
            linkedListHistory.Push("linked");
            linkedListHistory.Push("pirates");

            //var iterator = linkedListHistory.GetIterator();

            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Current());
                iterator.MoveNext();
            }
        }
    }
}
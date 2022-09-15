
using DesignPatterns.Iterator;

namespace DesignPatterns.Tests
{
    public class IteratorTests
    {
        [Theory]
        [InlineData("love.com", "jobs.com", "stuff.com")]
        public void ListIterator_CanIterateOver_ItemsInParentContainer(string site1, string site2, string site3)
        {
            var browserHistory = new BrowserHistoryList();
            browserHistory.Push(site1);
            browserHistory.Push(site2);
            browserHistory.Push(site3);

            var expectedVisitedSites = new List<string> { site1, site2, site3 };
            var actualVisitedSites = new List<string>();


            var iterator = browserHistory.GetIterator();
            while (iterator.HasNext())
            {
                actualVisitedSites.Add(iterator.Current());
                iterator.MoveNext();
            }

            Assert.Equal(expectedVisitedSites.Count, actualVisitedSites.Count);
            Assert.Equal(expectedVisitedSites, actualVisitedSites);
        }

        [Theory]
        [InlineData("love.com", "jobs.com", "stuff.com")]
        public void LinkedListIterator_CanIterateOver_ItemsInParentContainer(string site1, string site2, string site3)
        {
            var browserHistory = new BrowserHistoryList();
            browserHistory.Push(site1);
            browserHistory.Push(site2);
            browserHistory.Push(site3);

            var expectedVisitedSites = new List<string> { site1, site2, site3 };
            var actualVisitedSites = new List<string>();


            var iterator = browserHistory.GetIterator();
            while (iterator.HasNext())
            {
                actualVisitedSites.Add(iterator.Current());
                iterator.MoveNext();
            }

            Assert.Equal(expectedVisitedSites.Count, actualVisitedSites.Count);
            Assert.Equal(expectedVisitedSites, actualVisitedSites);
        }
    }
}

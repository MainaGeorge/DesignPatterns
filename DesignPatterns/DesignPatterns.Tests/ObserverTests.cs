using DesignPatterns.Observer;

namespace DesignPatterns.Tests
{
    public class ObserverTests
    {
        [Fact]
        public void Subject_PassesValuesToSubscribers()
        {
            var subject = new DataSource();
            var firstSubscriber = new FirstSubscriber();
            var secondSubscriber = new SecondSubscriber();

            subject.AddSubscriber(firstSubscriber);
            subject.AddSubscriber(secondSubscriber);

            const string firstMessage = "First Message";
            subject.Data = "First Message";

            Assert.Equal(firstMessage, firstSubscriber.Data);

            const int secondMessage = 1;
            subject.RemoveSubscriber(firstSubscriber);
            subject.Notify(secondMessage);

            Assert.Equal(secondMessage, secondSubscriber.Data);
            Assert.Equal(firstMessage, firstSubscriber.Data);

        }
    }
}

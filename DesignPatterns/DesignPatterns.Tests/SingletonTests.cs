namespace DesignPatterns.Tests
{
    public class SingletonTests
    {
        [Fact]
        public void SingletonAlwaysCreatesOneInstance()
        {
            var instance = Singleton.Singleton.Instance;
            var instance2 = Singleton.Singleton.Instance;
            var instance3 = Singleton.Singleton.Instance;

            Assert.Equal(instance, instance2);
            Assert.Equal(instance3, instance);
            Assert.Equal(instance2, instance3);
        }
    }
}
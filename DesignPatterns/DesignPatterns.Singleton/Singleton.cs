namespace DesignPatterns.Singleton
{
    public sealed class Singleton
    {
        private static readonly Singleton _instance = new();

        private Singleton()
        {
        }

        public static int SomethingRandom => 20;
        public static Singleton Instance => _instance;

    }
}
namespace DesignPatterns.Prototype
{
    public static class Utility
    {
        private static readonly Random _random = new Random();

        public static int GetNewPrice()
        {
            return _random.Next(100_000, 500_000);
        }
    }
}

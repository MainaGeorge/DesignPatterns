namespace DesignPatterns.Builder
{
    public partial class Product : IProduct
    {
        public string Name { get; private set; }
        public int Price { get; private set; }
        public string? PhotoUrl { get; private set; }
        public string? Description { get; private set; }

        private Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }


}
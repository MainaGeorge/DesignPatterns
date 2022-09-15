namespace DesignPatterns.Decorator
{
    public class Product
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }

        public Product(int id, decimal price, string name)
        {
            Id = id;
            Price = price;
            Name = name;
        }

        public static IEnumerable<Product> GetProducts()
        {
            return new List<Product>
        {
            new(1, 25, "sweater"),
            new(2, 25, "pullover"),
            new(3, 15, "pineapple"),
            new(4, 10, "apple"),
            new(5, 25, "pants")
        };
        }
    }
}
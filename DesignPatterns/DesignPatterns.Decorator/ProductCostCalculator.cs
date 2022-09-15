namespace DesignPatterns.Decorator;

public class ProductCostCalculator : ICalculateCost
{
    private readonly IEnumerable<Product> _products;

    public ProductCostCalculator(IEnumerable<Product> products)
    {
        _products = products;
    }
    public decimal GetCost()
    {
        return _products.Sum(p => p.Price);
    }
}
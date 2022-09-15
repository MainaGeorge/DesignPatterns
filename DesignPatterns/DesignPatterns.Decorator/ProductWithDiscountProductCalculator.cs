namespace DesignPatterns.Decorator;

public class ProductWithDiscountProductCalculator : ICalculateCost
{
    private readonly ICalculateCost _productCostCalculator;
    private readonly int _discountPercentage;

    public ProductWithDiscountProductCalculator(ICalculateCost productCostCalculator, int discountPercentage)
    {
        _productCostCalculator = productCostCalculator;
        _discountPercentage = discountPercentage;
    }
    public decimal GetCost()
    {
        return 0.01M * (100 - _discountPercentage) * _productCostCalculator.GetCost();
    }
}
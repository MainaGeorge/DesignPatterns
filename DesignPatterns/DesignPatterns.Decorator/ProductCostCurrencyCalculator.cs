namespace DesignPatterns.Decorator;

public class ProductCostCurrencyCalculator : ICalculateCost
{
    private readonly ICalculateCost _productCostCalculator;
    private readonly string _currency;

    private readonly Dictionary<string, decimal> _currencyMap = new()
    {
        { "PLN", 3.0M },
        { "GBP", 0.5M },
        { "EUR", 0.75M },
        { "YEN", 2.0M },
        {"USD" , 1.0M}
    };

    public ProductCostCurrencyCalculator(ICalculateCost productCostCalculator, string currency)
    {
        _productCostCalculator = productCostCalculator;
        _currency = currency;
    }
    public decimal GetCost()
    {
        var currency = _currency.ToUpper();
        if (!_currencyMap.ContainsKey(currency))
            throw new ArgumentException($"Could not find the currency {nameof(_currency)} in our supported currencies");

        return _productCostCalculator.GetCost() * _currencyMap[currency];
    }
}
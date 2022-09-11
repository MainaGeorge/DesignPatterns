using DesignPatterns.Decorator;

namespace DesignPatterns.Tests
{
    public class DecoratorTests
    {
        [Theory]
        [InlineData(100, 50, 75)]
        public void DecoratorCanCalculatePrice_InDifferentCurrency(decimal priceInDollars, decimal priceInGbp, decimal priceInEuro)
        {
            var products = Product.GetProducts();

            var productsCostCalculator = new ProductCostCalculator(products);
            var costInDollars = new ProductCostCurrencyCalculator(productsCostCalculator, "USD").GetCost();
            var costInEuros = new ProductCostCurrencyCalculator(productsCostCalculator, "EUR").GetCost();
            var costInPounds = new ProductCostCurrencyCalculator(productsCostCalculator, "GBP").GetCost();

            Assert.Equal(priceInDollars, costInDollars);
            Assert.Equal(priceInEuro, costInEuros);
            Assert.Equal(priceInGbp, costInPounds);
        }

        [Theory]
        [InlineData(90, 45, 67.5)]
        public void DecoratorCanCalculatePrice_WithDiscounts(decimal discountedDollarPrice
            , decimal discountedPricePounds, decimal discountedPriceEuros)
        {
            var products = Product.GetProducts();

            var discountedProductCostCalculator = new ProductWithDiscountProductCalculator(new ProductCostCalculator(products), 10);
            var costInDollars = new ProductCostCurrencyCalculator(discountedProductCostCalculator, "USD").GetCost();
            var costInEuros = new ProductCostCurrencyCalculator(discountedProductCostCalculator, "EUR").GetCost();
            var costInPounds = new ProductCostCurrencyCalculator(discountedProductCostCalculator, "GBP").GetCost();

            Assert.Equal(costInDollars, discountedDollarPrice);
            Assert.Equal(costInPounds, discountedPricePounds);
            Assert.Equal(costInEuros, discountedPriceEuros);

        }
    }
}

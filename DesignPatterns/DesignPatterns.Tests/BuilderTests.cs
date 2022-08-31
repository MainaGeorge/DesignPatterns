using static DesignPatterns.Builder.Product;

namespace DesignPatterns.Tests
{
    public class BuilderTests
    {
        [Theory]
        [InlineData("washing powder", 20)]
        public void Builder_SetsRequiredValues_PriceAndName_Correctly(string name, int price)
        {
            var product = new ProductBuilder(name, price).Build();

            Assert.Equal(name, product.Name);
            Assert.Equal(price, product.Price);
        }

        [Theory]
        [InlineData("washing powder", 20, "description", "some url")]
        public void Builder_SetsOptionalValues_Correctly_WhenProvided(string name, int price, string description, string photoUrl)
        {
            var product = new ProductBuilder(name, price)
                .WithDescription(description)
                .WithPhotoUrl(photoUrl)
                .Build();

            Assert.Equal(name, product.Name);
            Assert.Equal(price, product.Price);
            Assert.Equal(description, product.Description);
            Assert.Equal(photoUrl, product.PhotoUrl);
        }
    }
}

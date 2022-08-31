namespace DesignPatterns.Builder
{
    public partial class Product
    {
        public class ProductBuilder
        {
            private readonly Product _product;

            public ProductBuilder(string name, int price)
            {
                _product = new Product(name, price);
            }

            public ProductBuilder WithPhotoUrl(string photoUrl)
            {
                _product.PhotoUrl = photoUrl;
                return this;
            }

            public ProductBuilder WithDescription(string description)
            {
                _product.Description = description;
                return this;
            }

            public Product Build()
            {
                return _product;
            }
        }
    }


}
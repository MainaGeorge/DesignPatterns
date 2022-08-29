using DesignPatterns.Prototype;

namespace DesignPatterns.Tests
{
    public class PrototypeTests
    {
        [Fact]
        public void Prototype_CreatesCopies_OfExistingObjects()
        {
            var electricCar = new ElectricCar("new Model")
            {
                Price = 200_000
            };

            var anotherElectricCar = electricCar.Clone();

            Assert.Equal(electricCar.ModelName, anotherElectricCar.ModelName);
            Assert.Equal(electricCar.Price, anotherElectricCar.Price);
        }

        [Fact]
        public void Prototype_ObjectsCanBeManipulatedIndependently()
        {
            var electricCar = new ElectricCar("new Model")
            {
                Price = 200_000
            };

            var anotherElectricCar = electricCar.Clone();

            anotherElectricCar.ModelName = "Newer model";
            anotherElectricCar.Price = electricCar.Price + Utility.GetNewPrice();

            Assert.NotEqual(anotherElectricCar.Price, electricCar.Price);
            Assert.NotEqual(electricCar.ModelName, anotherElectricCar.ModelName);
        }
    }
}

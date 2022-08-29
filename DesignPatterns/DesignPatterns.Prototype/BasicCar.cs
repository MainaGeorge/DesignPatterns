namespace DesignPatterns.Prototype
{
    public abstract class BasicCar
    {
        public string ModelName { get; set; }
        public int Price { get; set; }

        protected BasicCar(string modelName)
        {
            ModelName = modelName;
        }
        public abstract BasicCar Clone();
    }
}
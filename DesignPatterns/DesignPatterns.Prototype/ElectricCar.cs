namespace DesignPatterns.Prototype;

public class ElectricCar : BasicCar
{
    public ElectricCar(string modelName) : base(modelName)
    {
    }

    public override BasicCar Clone()
    {
        return (ElectricCar)this.MemberwiseClone();
    }
}
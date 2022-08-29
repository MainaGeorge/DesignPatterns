namespace DesignPatterns.Prototype;

public class Ford : BasicCar
{
    public Ford(string name) : base(name)
    {
    }

    public override BasicCar Clone()
    {
        return (Ford)this.MemberwiseClone();
    }
}
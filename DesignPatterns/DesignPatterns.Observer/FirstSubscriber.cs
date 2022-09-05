namespace DesignPatterns.Observer;

public class FirstSubscriber : ISubscriber
{
    public object? Data { get; private set; }
    public object Notify(object value)
    {
        Data = value;
        return value;
    }
}
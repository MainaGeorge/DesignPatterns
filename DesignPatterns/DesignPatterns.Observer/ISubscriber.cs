namespace DesignPatterns.Observer;

public interface ISubscriber
{
    object Notify(object value);
}
namespace DesignPatterns.Iterator
{
    public interface IIterator<out T>
    {
        T Current();
        void MoveNext();
        bool HasNext();
    }
}
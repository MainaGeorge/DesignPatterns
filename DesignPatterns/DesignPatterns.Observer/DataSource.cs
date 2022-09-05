namespace DesignPatterns.Observer;

public class DataSource : Subject
{
    private object _data = new();
    public object Data
    {
        get => _data;
        set
        {
            _data = value;
            Notify(_data);
        }
    }


}
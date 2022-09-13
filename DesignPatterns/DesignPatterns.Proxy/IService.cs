namespace DesignPatterns.Proxy
{
    public interface IService<T> where T : class
    {
        T? GetEmployee(int id);
        List<T> GetEmployees();
    }
}
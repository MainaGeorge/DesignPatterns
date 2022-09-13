namespace DesignPatterns.Proxy
{
    public class EmployeeService : IService<Employee>
    {
        private readonly List<Employee> _employees = new()
        {
            new (1, "Ollie"),
            new (2, "Maina"),
            new (3, "Nuria"),
            new (4, "Martinez")
        };
        public Employee? GetEmployee(int id) => _employees.FirstOrDefault(e => e.Id == id);

        public List<Employee> GetEmployees() => _employees;
    }
}
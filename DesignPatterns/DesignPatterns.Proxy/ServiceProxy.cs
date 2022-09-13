namespace DesignPatterns.Proxy
{
    public class ServiceProxy : IService<Employee>
    {
        public static Stack<string> ActionLogs { get; } = new();
        private readonly IService<Employee> _service;
        private readonly List<Employee> _employees = new();
        private readonly Dictionary<int, Employee> _employeesDictionary = new();
        private readonly Employee _employee;

        public ServiceProxy(IService<Employee> service, Employee adminEmployee)
        {
            _service = service;
            _employee = adminEmployee;
        }

        public Employee? GetEmployee(int id)
        {
            Authenticate();
            if (_employeesDictionary.ContainsKey(id))
            {
                ActionLogs.Push("Reading Employee from cache");
                return _employeesDictionary[id];
            }

            ActionLogs.Push("Loading Employee from service");
            var employee = _service.GetEmployee(id);
            if (employee != null)
                _employeesDictionary[id] = employee;

            return employee;
        }

        public List<Employee> GetEmployees()
        {
            Authenticate();
            if (_employees.Count == 0)
            {
                ActionLogs.Push("Loading Employees from service");
                _employees.AddRange(_service.GetEmployees());
            }
            else
            {
                ActionLogs.Push("Reading Employees from cache");
            }

            return _employees;
        }

        public static int GetNumberOfSpecificLogs(string logMessage)
        {
            return ActionLogs.Count(l => l.Equals(logMessage));
        }

        private void Authenticate()
        {
            if (!_employee.Name.Equals("Admin"))
                throw new InvalidOperationException("You don't have permission to access the data");
        }
    }
}
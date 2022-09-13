using DesignPatterns.Proxy;
using System.Runtime.CompilerServices;

namespace DesignPatterns.Tests
{
    public class ProxyTests
    {
        [Fact]
        public void Proxy_CanCacheData()
        {
            var employeeService = new EmployeeService();
            var employeeServiceProxy = new ServiceProxy(employeeService, new Employee(2, "Admin"));

            employeeServiceProxy.GetEmployees();
            employeeServiceProxy.GetEmployee(2);

            Assert.Equal(1, ServiceProxy.GetNumberOfSpecificLogs("Loading Employee from service"));
            Assert.Equal(1, ServiceProxy.GetNumberOfSpecificLogs("Loading Employees from service"));

            Assert.Equal(0, ServiceProxy.GetNumberOfSpecificLogs("Reading Employees from cache"));
            Assert.Equal(0, ServiceProxy.GetNumberOfSpecificLogs("Reading Employee from cache"));

            employeeServiceProxy.GetEmployees();
            employeeServiceProxy.GetEmployee(2);
            employeeServiceProxy.GetEmployees();
            employeeServiceProxy.GetEmployee(2);

            Assert.Equal(1, ServiceProxy.GetNumberOfSpecificLogs("Loading Employee from service"));
            Assert.Equal(1, ServiceProxy.GetNumberOfSpecificLogs("Loading Employees from service"));
            Assert.Equal(2, ServiceProxy.GetNumberOfSpecificLogs("Reading Employees from cache"));
            Assert.Equal(2, ServiceProxy.GetNumberOfSpecificLogs("Reading Employee from cache"));

            employeeServiceProxy.GetEmployee(3);
            Assert.Equal(2, ServiceProxy.GetNumberOfSpecificLogs("Loading Employee from service"));
        }

        [Fact]
        public void Proxy_CanAuthenticateEmployee()
        {
            var employeeService = new EmployeeService();
            var employeeServiceProxy = new ServiceProxy(employeeService, new Employee(2, "random employee"));

            var error = Assert.Throws<InvalidOperationException>(() => employeeServiceProxy.GetEmployees());
            Assert.Equal("You don't have permission to access the data", error.Message);
        }
    }
}

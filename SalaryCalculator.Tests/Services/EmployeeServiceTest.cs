using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalaryCalculator.API.Repositories.Interfaces;
using SalaryCalculator.API.Services;

namespace SalaryCalculator.Tests.Services
{
    [TestClass]
    public class EmployeeServiceTest
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeServiceTest(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [TestMethod]
        public void GetEmployee()
        {
            // Arrange
            EmployeeService Service = new EmployeeService(_employeeRepository);

            // Act

            // Assert
        }

        [TestMethod]
        public void GetAllEmployees()
        {
            // Arrange
            EmployeeService Service = new EmployeeService(_employeeRepository);

            // Act

            // Assert
        }

        [TestMethod]
        public void InsertEmployee()
        {
            // Arrange
            EmployeeService Service = new EmployeeService(_employeeRepository);

            // Act

            // Assert
        }

        [TestMethod]
        public void UpdateEmployee()
        {
            // Arrange
            EmployeeService Service = new EmployeeService(_employeeRepository);

            // Act

            // Assert
        }

        [TestMethod]
        public void DeleteEmployee()
        {
            // Arrange
            EmployeeService Service = new EmployeeService(_employeeRepository);

            // Act

            // Assert
        }
    }
}

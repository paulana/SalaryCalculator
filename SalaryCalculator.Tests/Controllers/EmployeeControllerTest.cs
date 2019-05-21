using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalaryCalculator.API.Controllers;
using SalaryCalculator.API.Services.Interfaces;

namespace SalaryCalculator.Tests.Controllers
{
    [TestClass]
    public class EmployeeControllerTest
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeControllerTest(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [TestMethod]
        public void GetEmployee()
        {
            // Arrange
            EmployeeController controller = new EmployeeController(_employeeService);

            // Act

            // Assert
        }

        [TestMethod]
        public void GetAllEmployees()
        {
            // Arrange
            EmployeeController controller = new EmployeeController(_employeeService);

            // Act

            // Assert
        }

        [TestMethod]
        public void UpdateEmployee()
        {
            // Arrange
            EmployeeController controller = new EmployeeController(_employeeService);

            // Act

            // Assert
        }

        [TestMethod]
        public void DeleteEmployee()
        {
            // Arrange
            EmployeeController controller = new EmployeeController(_employeeService);

            // Act

            // Assert
        }
    }
}

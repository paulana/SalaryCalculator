using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalaryCalculator.API.Repositories.Interfaces;
using SalaryCalculator.API.Services;
using SalaryCalculator.API.Services.Interfaces;

namespace SalaryCalculator.Tests.Services
{
    [TestClass]
    public class CalculationServiceTest
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IDependentRepository _dependentRepository;

        public CalculationServiceTest(IEmployeeRepository employeeRepository, IDependentRepository dependentRepository)
        {
            _employeeRepository = employeeRepository;
            _dependentRepository = dependentRepository;
        }

        [TestMethod]
        public void GetCalculation()
        {
            // Arrange
            CalculationService Service = new CalculationService(_dependentRepository, _employeeRepository);

            // Act

            // Assert
        }
    }
}

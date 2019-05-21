using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalaryCalculator.API.Controllers;
using SalaryCalculator.API.Services.Interfaces;

namespace SalaryCalculator.Tests.Controllers
{
    [TestClass]
    public class CalculationControllerTest
    {
        private readonly ICalculationService _calculationService;

        public CalculationControllerTest(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }

        [TestMethod]
        public void GetCalculation()
        {
            // Arrange
            CalculationController controller = new CalculationController(_calculationService);

            // Act

            // Assert
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalaryCalculator.API.Controllers;
using SalaryCalculator.API.Services.Interfaces;

namespace SalaryCalculator.Tests.Controllers
{
    [TestClass]
    public class DependentControllerTest
    {
        private readonly IDependentService _dependentService;

        public DependentControllerTest(IDependentService dependentService)
        {
            _dependentService = dependentService;
        }

        [TestMethod]
        public void GetDependent()
        {
            // Arrange
            DependentController controller = new DependentController(_dependentService);

            // Act

            // Assert
        }

        [TestMethod]
        public void GetAllDependents()
        {
            // Arrange
            DependentController controller = new DependentController(_dependentService);

            // Act

            // Assert
        }

        [TestMethod]
        public void UpdateDependent()
        {
            // Arrange
            DependentController controller = new DependentController(_dependentService);

            // Act

            // Assert
        }

        [TestMethod]
        public void DeleteDependent()
        {
            // Arrange
            DependentController controller = new DependentController(_dependentService);

            // Act

            // Assert
        }
    }
}

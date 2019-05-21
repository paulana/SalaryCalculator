using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalaryCalculator.API.Repositories.Interfaces;
using SalaryCalculator.API.Services;

namespace SalaryCalculator.Tests.Services
{
    [TestClass]
    public class DependentServiceTest
    {
        private readonly IDependentRepository _dependentRepository;

        public DependentServiceTest(IDependentRepository dependentRepository)
        {
            _dependentRepository = dependentRepository;
        }

        [TestMethod]
        public void GetDependent()
        {
            // Arrange
            DependentService Service = new DependentService(_dependentRepository);

            // Act

            // Assert
        }

        [TestMethod]
        public void GetAllDependents()
        {
            // Arrange
            DependentService Service = new DependentService(_dependentRepository);

            // Act

            // Assert
        }

        [TestMethod]
        public void InsertDependent()
        {
            // Arrange
            DependentService Service = new DependentService(_dependentRepository);

            // Act

            // Assert
        }

        [TestMethod]
        public void UpdateDependent()
        {
            // Arrange
            DependentService Service = new DependentService(_dependentRepository);

            // Act

            // Assert
        }

        [TestMethod]
        public void DeleteDependent()
        {
            // Arrange
            DependentService Service = new DependentService(_dependentRepository);

            // Act

            // Assert
        }
    }
}

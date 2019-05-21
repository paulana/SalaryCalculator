using SalaryCalculator.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalaryCalculator.API.Repositories.Interfaces
{
    /// <summary>
    /// Interface for Calculation Repository
    /// </summary>
    public interface IDependentRepository : IRepository<Dependent>
    {
    }
}
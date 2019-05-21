using SalaryCalculator.API.Repositories.Interfaces;
using SalaryCalculator.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalaryCalculator.API.Repositories
{
    public class DependentRepository : Repository<Dependent>, IDependentRepository
    {
    }
}
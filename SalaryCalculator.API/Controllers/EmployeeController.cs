using SalaryCalculator.API.Services.Interfaces;
using SalaryCalculator.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;

namespace SalaryCalculator.API.Controllers
{
    /// <summary>
    /// Employees Controller
    /// </summary>
    public class EmployeeController : ApiController
    {
        private readonly IEmployeeService _employeeService;

        /// <summary>
        /// Constructor for Employees Controller
        /// </summary>
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        [ResponseType(typeof(Employee))]
        [Route("v1/Employee/{guid}")]
        public async Task<IHttpActionResult> Get(Guid guid)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [ResponseType(typeof(Employee))]
        [Route("v1/Employee/")]
        public async Task<IHttpActionResult> Put(Employee model)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [ResponseType(typeof(Employee))]
        [Route("v1/Employee/")]
        public async Task<IHttpActionResult> Post(Employee model)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        [ResponseType(typeof(bool))]
        [Route("v1/Employee/{guid}")]
        public async Task<IHttpActionResult> Delete(Guid guid)
        {
            throw new NotImplementedException();
        }
    }
}

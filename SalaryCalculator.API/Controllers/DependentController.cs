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
    /// Dependents Controller
    /// </summary>
    public class DependentController : ApiController
    {
        private readonly IDependentService _dependentService;

        /// <summary>
        /// Constructor for Dependents Controller
        /// </summary>
        public DependentController(IDependentService dependentService)
        {
            _dependentService = dependentService;
        }

        [HttpGet]
        [ResponseType(typeof(Dependent))]
        [Route("v1/Dependent/{guid}")]
        public async Task<IHttpActionResult> Get(Guid guid)
        {
            return Ok(await _dependentService.Get(guid));
        }

        [HttpPut]
        [ResponseType(typeof(Dependent))]
        [Route("v1/Dependent/")]
        public async Task<IHttpActionResult> Put(Dependent model)
        {
            return Ok(await _dependentService.Put(model));
        }

        [HttpPost]
        [ResponseType(typeof(Dependent))]
        [Route("v1/Dependent/")]
        public async Task<IHttpActionResult> Post(Dependent model)
        {
            return Ok(await _dependentService.Post(model));
        }

        [HttpDelete]
        [ResponseType(typeof(bool))]
        [Route("v1/Dependent/{guid}")]
        public async Task<IHttpActionResult> Delete(Guid guid)
        {
            return Ok(await _dependentService.Delete(guid));
        }
    }
}

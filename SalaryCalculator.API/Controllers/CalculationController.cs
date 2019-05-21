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
    /// Calculations Controller
    /// </summary>
    public class CalculationController : ApiController
    {
        private readonly ICalculationService _calculationService;

        /// <summary>
        /// Constructor for Calculations Controller
        /// </summary>
        public CalculationController(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }

        [HttpGet]
        [ResponseType(typeof(SalaryCalculationResponse))]
        [Route("v1/Calculator")]
        public async Task<IHttpActionResult> Get(SalaryCalculationRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

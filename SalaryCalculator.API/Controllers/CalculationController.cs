using SalaryCalculator.API.Services.Interfaces;
using SalaryCalculator.Common.Models;
using System.Threading.Tasks;
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
            var response = _calculationService.Calculate(request);

            if (response == null)
                return BadRequest("Employee not found.");

            return Ok(request);
        }
    }
}

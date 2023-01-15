using CalculatorTest;
using CalculatorTest.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ISimpleCalculator _calculator;
        private readonly IDiagnostics _diagnostics;

        public CalculatorController(ISimpleCalculator calculator, IDiagnostics diagnostics)
        {
            _calculator = calculator;
            _diagnostics = diagnostics;
        }

        [HttpGet]
        [Route("add/{a}/{b}")]
        public ActionResult<int> Add(int a, int b)
        {
            int result = _calculator.Add(a, b);
            return Ok(result);
        }
        [HttpGet]
        [Route("subtract/{a}/{b}")]
        public ActionResult<int> Subtract(int a, int b)
        {
            int result = _calculator.Subtract(a, b);
            return Ok(result);
        }
        [HttpGet]
        [Route("multiply/{a}/{b}")]
        public ActionResult<int> Multiply(int a, int b)
        {
            int result = _calculator.Multiply(a, b);
            return Ok(result);
        }
        [HttpGet]
        [Route("divide/{a}/{b}")]
        public ActionResult<int> Divide(int a, int b)
        {
            int result = _calculator.Divide(a, b);
            return Ok(result);
        }
    }
}
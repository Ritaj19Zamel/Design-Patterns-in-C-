using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using PayrollSystem.Core;

namespace PayrollSystem.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    class PayrollCalculatorController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public ActionResult<decimal> calculate(Employee employee)
        {
            var calculator = new PayrollCalculator();
            return Ok(calculator.Calculate(employee));
        }
    }
}

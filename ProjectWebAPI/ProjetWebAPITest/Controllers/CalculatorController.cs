using Microsoft.AspNetCore.Mvc;

namespace ProjetWebAPITest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sun(string firstNumber, string secondnumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondnumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondnumber);

                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("subtraction/{firstNumber}/{secondnumber}")]
        public IActionResult Subtraction(string firstNumber, string secondnumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondnumber))
            {
                var sub = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondnumber);

                return Ok(sub.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("multiplication/{firstNumber}/{secondnumber}")]
        public IActionResult Multiplication(string firstNumber, string secondnumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondnumber))
            {
                var mult = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondnumber);

                return Ok(mult.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("division/{firstNumber}/{secondnumber}")]
        public IActionResult Division(string firstNumber, string secondnumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondnumber))
            {
                var div = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondnumber);

                return Ok(div.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("average/{firstNumber}/{secondnumber}")]
        public IActionResult Average(string firstNumber, string secondnumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondnumber))
            {
                var aver = (ConvertToDecimal(firstNumber) / ConvertToDecimal(secondnumber)) / 2;

                return Ok(aver.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("Squareroot/{firstNumber}")]
        public IActionResult Squareroot(string firstNumber)
        {
            if (IsNumeric(firstNumber))
            {
                var Squareroot = Math.Sqrt((double)ConvertToDecimal(firstNumber));

                return Ok(Squareroot.ToString());
            }

            return BadRequest("Invalid Input");
        }

        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber;

            return isNumber = double.TryParse(strNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);
        }

        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;

            if (decimal.TryParse(strNumber, out decimalValue))
            {
                return decimalValue;
            }

            return 0;
        }
    }
}
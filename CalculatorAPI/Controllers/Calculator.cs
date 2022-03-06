using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class Calculator : ControllerBase
    {
        [HttpGet(Name = "Calculate")]
        public double Calculate(double number1, double number2, String Action)
        {
            double result = 0;
            if (Action == "Addition")
                result = number1 + number2;
            if (Action == "Multiplication")
                result = number1 * number2;
            if (Action == "Subtraction")
                result = number1 - number2;
            if (Action == "Division" && number2 != 0)
                result = number1 / number2;
            if (Action == "Division" && number2 == 0)
                result = 0;
            return result;
        }
    }
}

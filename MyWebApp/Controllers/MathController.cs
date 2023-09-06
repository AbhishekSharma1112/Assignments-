using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

namespace MyWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : Controller
    {
        private readonly IMath _math;
        public MathController(IMath math)
        {
            _math = math;
        }

        [HttpGet("add")]
        public  int Add([FromQuery] int x, [FromQuery] int y)
        {
            return _math.Add(x,y);
        }

        [HttpGet("subtract")]
        public int Subtract([FromQuery] int x, [FromQuery] int y)
        {
            return _math.Substract(x, y);
        }

        [HttpGet("multiply")]
        public int Multiply([FromQuery] int x, [FromQuery] int y)
        {
            return _math.Multiply(x, y);
        }

        [HttpGet("divide")]
        public int Divide([FromQuery] int x, [FromQuery] int y)
        {
            if(x == 0 || y == 0)
            {
                return 0;
            }
            return _math.Divide(x, y);
        }


    }
}

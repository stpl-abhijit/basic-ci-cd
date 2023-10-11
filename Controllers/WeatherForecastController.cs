using Microsoft.AspNetCore.Mvc;

namespace basic_ci_cd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                //Just check ci cd
            })
            .ToArray();
        }


        [HttpGet("test-data")]
        public IActionResult DataRetrive()
        {
            return Ok("returndata");
        }

        [HttpGet("new-data-one")]
        public IActionResult NewDataOne()
        {
            return Ok("NewDataOne");
        }

        [HttpGet("vijay-sir-test")]
        public IActionResult VijaySirTest()
        {
            return Ok("VijaySirTest");
        }
        [HttpGet("another-one-implementation")]
        public IActionResult Another()
        {
            return Ok("another-one-implementation");
        }
    }
}
using AspNetTopics.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace AspNetTopics.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            var user1 = new User { Id = 1, FirstName = "Mostafa", LastName = "Hamed" };

            var user2 = new User { Id = 2, FirstName = "Rwan", LastName = "Abdelrheem" };

            // Serialization
            var userJson = JsonSerializer.Serialize(user1);

            // Deserialization
            var userObj = JsonSerializer.Deserialize<User>(userJson);


            return Ok(new { UserInJson = userJson , FirstName = userObj.FirstName}) ;
        }

        
    }
}

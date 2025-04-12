using MediatrStudying.Controllers.DItesting;
using Microsoft.AspNetCore.Mvc;

namespace MediatrStudying.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        IDItesting iD;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IDItesting iD)
        {
            _logger = logger;
            this.iD= iD;
        }

        [HttpGet(Name ="ggg")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost("sad", Name = "pppp")]
        public string Set()
        {
            return "post";
        }

        [HttpPost("asd",Name = "setterweatherforecast")]
       
        public string Setter()
        {
            return iD.Logger();
        }

    }
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherOverview : ControllerBase
    {
        private readonly IPressure _pressure;
        private readonly IMoisture _moisture;
        private readonly ITemperature _temperature;

        public string Overview
        {
            get
            { var temp = _temperature.TemperatureValue() < 20;
                var pres = _pressure.PressureValue() < 700;
                var moist = _moisture.MoistureContent() > 50;
                if (temp&&pres&&moist) { return "bad"; } else if (!temp&&!pres&&!moist) { return "good"; } else { return "ok"; }
            }
        }
        

        // Constructor injection
        public WeatherOverview(IPressure pressure, IMoisture moisture, Temperature temperature)
        {
            _pressure = pressure;
            _moisture = moisture;
            _temperature = temperature;

            
        }
        [HttpGet("status")]
        public IActionResult Get()
        {
            // Access the property 
            return Ok(new { status = Overview });
        }
    }

       



    }
    //public class Test2Controller : ControllerBase
    //{
    //    [HttpGet]   // GET /api/test2
    //    public IActionResult ListProducts()
    //    {
    //        return Ok( "TEST1");
    //    }

    //    [HttpGet("{id}")]   // GET /api/test2/xyz
    //    public IActionResult GetProduct(string id)
    //    {
    //         return Ok( "TEST2");
    //    }

    //    [HttpGet("int/{id:int}")] // GET /api/test2/int/3
    //    public IActionResult GetIntProduct(int id)
    //    {
    //        return Ok("TEST3");
    //    }

    //    [HttpGet("int2/{id}")]  // GET /api/test2/int2/3
    //    public IActionResult GetInt2Product(int id)
    //    {
    //        return Ok("TEST4");
    //    }
    //}



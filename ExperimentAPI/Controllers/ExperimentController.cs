using ExperimentAPI.Response;
using Microsoft.AspNetCore.Mvc;

namespace ExperimentAPI.Controllers
{
    [ApiController]
    [Route("experiment")]
    public class ExperimentController : ControllerBase
    {

        private readonly ILogger<ExperimentController> _logger;

        public ExperimentController(ILogger<ExperimentController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("button_color/{device_token}")]
        public IActionResult GetButtonColor(string deviceToken)
        {
            return Ok(new ExperimentResponse("test", "test2"));
        }

        [HttpGet]
        [Route("price/{device_token}")]
        public IActionResult GetPrice(string deviceToken)
        {
            return Ok(new { Price = "test" });
        }
    }
}
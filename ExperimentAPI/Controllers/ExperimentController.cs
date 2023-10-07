using ExperimentAPI.Response;
using Microsoft.AspNetCore.Mvc;
using ExperimentAPI.Services;
using ExperimentAPI.Interfaces;

namespace ExperimentAPI.Controllers
{
    [ApiController]
    [Route("experiment")]
    public class ExperimentController : ControllerBase
    {

        private readonly ILogger<ExperimentController> _logger;
        private readonly IService _experimentService;

        public ExperimentController(ILogger<ExperimentController> logger, IService experimentService)
        {
            _logger = logger;
            _experimentService = experimentService;
        }

        [HttpGet]
        [Route("button_color/{device_token}")]
        public IActionResult GetButtonColor(string deviceToken)
        {
            return Ok(new ExperimentResponse(_experimentService.GetColors(), "test2"));
        }

        [HttpGet]
        [Route("price/{device_token}")]
        public IActionResult GetPrice(string deviceToken)
        {
            return Ok(new { Price = "test" });
        }
    }
}

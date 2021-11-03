using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers {
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SampleController: ControllerBase {

        [HttpGet]
        public IActionResult Greet() {
            return Ok(new { Greeting = "Good afternoon", By = "Vivek" });
        }
    }
}
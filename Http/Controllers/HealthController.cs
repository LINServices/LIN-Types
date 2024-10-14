namespace Http.Controllers;

[Route("[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok("Server its running");

    [HttpHead]
    public IActionResult Head() => Ok();
}
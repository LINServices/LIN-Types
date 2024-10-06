namespace Http.Controllers;

[Route("[controller]")]
public class HealthController : ControllerBase
{

    [HttpGet]
    public IActionResult Get()
    {
        return Ok("OK");
    }

}
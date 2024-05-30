namespace Http.Controllers;


[Route("health")]
public class HealthController : ControllerBase
{


    [HttpGet]
    public IActionResult Get()
    {
        return Ok("OK");
    }


}
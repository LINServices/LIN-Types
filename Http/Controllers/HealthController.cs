namespace Http.Controllers;



[Route("health")]
public class HealthController : ControllerBase
{


    [HttpGet]
    public string Get()
    {
        return "OK";
    }


}
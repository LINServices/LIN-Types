using System.Reflection;

namespace Http.Controllers;

[Route("[controller]")]
public class HealthController : ControllerBase
{
    [HttpHead]
    public IActionResult Head() => Ok();

    [HttpGet("version")]
    public IActionResult Version()
    {
        var version = Assembly.GetEntryAssembly()?.GetName().Version?.ToString() ?? "unknown";
        return Ok(new { version });
    }
}
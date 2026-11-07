using Microsoft.AspNetCore.Mvc;

namespace HelpDesk.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    // TODO 1: etiqueta que diz "este método responde a GET"
    public IActionResult Get()
    {
      // TODO 2: devolver 200 OK com uma mensagem dizendo que a API funciona
      return Ok("This API is running!");
    }
}

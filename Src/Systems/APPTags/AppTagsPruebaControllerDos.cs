using Microsoft.AspNetCore.Mvc;

namespace WepAPI.Src.APPTags.Modules.Users;

[ApiController]
[ApiVersion("1.0")]
[Route("api/app-tags/v{version:apiVersion}/prueba-dos")]
[ApiExplorerSettings(GroupName = "app-tags-v1")]
[Tags("AppTags - Prueba Dos")]

public class AppTagsPruebaControllerDos : ControllerBase
{

    [HttpGet]
    public async Task<IActionResult> PruebaMethod()
    {

        return Ok(new { message = "prueba desde app controller" });
    }

    [HttpGet("hola")]
    public async Task<IActionResult> PruebaMethod2()
    {

        return Ok(new { message = "prueba desde app controller" });
    }

}
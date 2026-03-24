using Microsoft.AspNetCore.Mvc;

namespace WepAPI.Src.APPTags.Modules.Users;

[ApiController] // Version del controlador 
[ApiVersion("1.0")] // Prefijo, nombre sistema, version de api y nombre controlador
[Route("api/app-tags/v{version:apiVersion}/prueba-dos")]
[ApiExplorerSettings(GroupName = "app-tags-v1")] // Para agruparlo en documentacion interactiva
[Tags("AppTags - Prueba Dos")] // Nombre de la sub carpeta en documentacion


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
using Microsoft.AspNetCore.Mvc;

namespace WepAPI.Src.APPTags.Modules.Users;

[ApiController]
[ApiVersion("1.0")] //Version del controlador 
[Route("api/app-tags/v{version:apiVersion}/prueba")] //Prefijo, nombre sistema, version de api y nombre controlador
[ApiExplorerSettings(GroupName = "app-tags-v1")] //Para agruparlo en documentacion interactiva
[Tags("AppTags - Prueba")] //Nombre de la sub carpeta en documentacion

public class AppTagsPruebaController : ControllerBase
{
   
    [HttpGet]
    public async Task<IActionResult> PruebaMethod()
    {
       
        return Ok( new { message = "prueba desde app controller"});
    }

}
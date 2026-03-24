using Microsoft.AspNetCore.Mvc;

namespace WepAPI.Src.APPTags.Modules.Users;

[ApiController]
[ApiVersion("1.0")]
[Route("api/app-tags/v{version:apiVersion}/prueba")]
[ApiExplorerSettings(GroupName = "app-tags-v1")]
[Tags("AppTags - Prueba")]

public class AppTagsPruebaController : ControllerBase
{
   
    [HttpGet]
    public async Task<IActionResult> PruebaMethod()
    {
       
        return Ok( new { message = "prueba desde app controller"});
    }

}
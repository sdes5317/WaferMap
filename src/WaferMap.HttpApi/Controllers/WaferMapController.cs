using WaferMap.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace WaferMap.Controllers;

/* Inherit your controllers from this class.
 */

[ApiController]
[Route("[controller]/[action]")]
public class WaferMapController : AbpControllerBase
{
    public WaferMapController()
    {
        LocalizationResource = typeof(WaferMapResource);
    }
    [HttpGet]
    public string Hello()
    {
        return "Hello World!";
    }
}

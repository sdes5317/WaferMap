using System;
using System.Collections.Generic;
using System.Text;
using WaferMap.Localization;
using Volo.Abp.Application.Services;

namespace WaferMap;

/* Inherit your application services from this class.
 */
public abstract class WaferMapAppService : ApplicationService
{
    protected WaferMapAppService()
    {
        LocalizationResource = typeof(WaferMapResource);
    }
}

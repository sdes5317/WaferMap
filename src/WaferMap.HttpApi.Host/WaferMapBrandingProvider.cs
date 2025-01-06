using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace WaferMap;

[Dependency(ReplaceServices = true)]
public class WaferMapBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "WaferMap";
}

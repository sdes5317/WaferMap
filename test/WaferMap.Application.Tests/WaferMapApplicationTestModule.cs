using Volo.Abp.Modularity;

namespace WaferMap;

[DependsOn(
    typeof(WaferMapApplicationModule),
    typeof(WaferMapDomainTestModule)
    )]
public class WaferMapApplicationTestModule : AbpModule
{

}
